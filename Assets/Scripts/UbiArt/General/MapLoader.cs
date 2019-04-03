
using UbiArt.FileFormat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using System.Collections;
using System.Threading.Tasks;
using Asyncoroutine;
using System.Text;

namespace UbiArt {
	public class MapLoader {
		public string loadingState = "Loading";
		public string gameDataBinFolder;
		public string pathFolder;
		public string pathFile;
		//public string lvlName;
		public string logFile;

		public Material baseMaterial;
		public Material baseTransparentMaterial;
		public Material baseLightMaterial;
		public Material collideMaterial;
		public Material collideTransparentMaterial;

		public bool allowDeadPointers = false;
		public bool forceDisplayBackfaces = false;
		public bool blockyMode = false;
		public bool logEnabled = false;
		public StringBuilder log = new StringBuilder();

		public UV.UVAtlasManager uvAtlasManager;
		public Dictionary<StringID, FileWithPointers> files = new Dictionary<StringID, FileWithPointers>();
		public List<Tuple<string, FileWithPointers>> virtualFiles = new List<Tuple<string, FileWithPointers>>();
		public delegate void SerializeAction(CSerializerObject s);
		public struct ObjectPlaceHolder {
			public Path path;
			public Tuple<string, ArchiveMemory> virtualFile;
			public SerializeAction action;
			public ObjectPlaceHolder(Path path, SerializeAction action) {
				this.path = path;
				virtualFile = null;
				this.action = action;
			}
			public ObjectPlaceHolder(string name, ArchiveMemory mem, SerializeAction action) {
				virtualFile = new Tuple<string, ArchiveMemory>(name, mem);
				this.path = null;
				this.action = action;
			}
		}
		public Queue<ObjectPlaceHolder> pathsToLoad = new Queue<ObjectPlaceHolder>();

		public Dictionary<StringID, GenericFile<ITF.Actor_Template>> tpl = new Dictionary<StringID, GenericFile<ITF.Actor_Template>>();
		public Dictionary<StringID, GenericFile<ITF.FriseConfig>> fcg = new Dictionary<StringID, GenericFile<ITF.FriseConfig>>();
		public Dictionary<StringID, GenericFile<ITF.GFXMaterialShader_Template>> msh = new Dictionary<StringID, GenericFile<ITF.GFXMaterialShader_Template>>();
		public Dictionary<StringID, GenericFile<CSerializable>> isg = new Dictionary<StringID, GenericFile<CSerializable>>();
		public Dictionary<StringID, SceneFile> isc = new Dictionary<StringID, SceneFile>();
		public Dictionary<StringID, TextureCooked> tex = new Dictionary<StringID, TextureCooked>();

		public Globals globals = null;
		public Settings settings = null;

		private static MapLoader loader = null;
		public static MapLoader Loader {
			get {
				if (loader == null) {
					loader = new MapLoader();
				}
				return loader;
			}
		}

		public MapLoader() {
		}

		public async Task LoadAll() {
			try {
				Path pAtlas = new Path("", "atlascontainer.ckd");
				Load(pAtlas, (CSerializerObject s) => {
					s.Serialize(ref uvAtlasManager);
					print("Read:" + s.Position + " - Length:" + s.Length + " - " + (s.Position == s.Length ? "good!" : "bad!"));
				});
				SceneFile mainScene = null;
				if (pathFile.EndsWith(".isc.ckd") || pathFile.EndsWith(".isc")) {
					Path p = new Path(pathFolder, pathFile);
					Load(p, (CSerializerObject s) => {
						s.log = logEnabled;
						s.Serialize(ref mainScene);
						isc[p.stringID] = mainScene;
						Settings.s.isCatchThemAll = false;
					});
				}
				bool ckd = true;
				while (pathsToLoad.Count > 0) {
					ObjectPlaceHolder o = pathsToLoad.Dequeue();
					if (o.path != null) {
						StringID id = o.path.stringID;
						if (!files.ContainsKey(id)) {
							await PrepareFile(gameDataBinFolder + "/" + o.path.folder + o.path.filename + (ckd ? ".ckd" : ""));
							if (FileSystem.FileExists(gameDataBinFolder + "/" + o.path.folder + o.path.filename + (ckd ? ".ckd" : ""))) {
								files.Add(id, new BinarySerializedFile(o.path.filename, o.path, ckd));
							}
						}
						if (files.ContainsKey(id)) {
							FileWithPointers f = files[id];
							CSerializerObject s = f.serializer;
							s.ResetPosition();
							o.action(s);
						}
					} else if(o.virtualFile != null) {
						using (MemoryStream str = new MemoryStream(o.virtualFile.Item2.AMData)) {
							FileWithPointers f = new BinarySerializedFile(o.virtualFile.Item1, str);
							Tuple<string, FileWithPointers> t = new Tuple<string, FileWithPointers>(o.virtualFile.Item1, f);
							virtualFiles.Add(t);
							CSerializerObject s = f.serializer;
							s.ResetPosition();
							o.action(s);
							f.Dispose();
							virtualFiles.Remove(t);
						}
					}
					await WaitFrame();
				}
				if (mainScene != null && mainScene.scene != null) {
					GameObject sceneGao = mainScene.scene.Gao;
				}
			} catch (Exception ex) {
				Debug.LogError(ex.ToString());
			} finally {
				foreach (KeyValuePair<StringID, FileWithPointers> kv in files) {
					kv.Value.Dispose();
				}
				files.Clear();
				WriteLog();
			}
		}

		public void ConfigureSerializeFlagsForExtension(ref SerializeFlags flags, ref CSerializerObject.Flags ownFlags, string extension) {
			switch (extension) {
				case "isc":
					flags |= SerializeFlags.Flags7;
					break;
				case "fcg":
				case "msh":
				case "tpl":
				case "isg":
					flags |= SerializeFlags.Flags7;
					ownFlags |= CSerializerObject.Flags.StoreObjectSizes;
					break;
			}
		}

		private void WriteLog() {
			if (logEnabled && logFile != null && logFile.Trim() != "") {
				using (StreamWriter writer = new StreamWriter(logFile)) {
					writer.WriteLine(log.ToString());
				}
			}
		}

		public void Load(Path path, SerializeAction action) {
			if (path == null || path.IsNull) return;
			if (files.ContainsKey(path.stringID)) {
				FileWithPointers f = files[path.stringID];
				CSerializerObject s = f.serializer;
				s.ResetPosition();
				action(s);
			} else {
				pathsToLoad.Enqueue(new ObjectPlaceHolder(path, action));
			}
		}

		public void Load(ArchiveMemory mem, string name, SerializeAction action) {
			pathsToLoad.Enqueue(new ObjectPlaceHolder(name, mem, action));
		}

		// Defining it this way, clicking the print will go straight to the code you want
		public Action<object> print = MonoBehaviour.print;
		public void Log(object obj) {
			if(logEnabled)
				log.AppendLine(obj != null ? obj.ToString() : "");
		}


		public static async Task WaitFrame() {
			await new WaitForEndOfFrame();
		}

		public FileWithPointers GetFileByReader(Reader reader) {
			foreach (KeyValuePair<StringID, FileWithPointers> kv in files) {
				FileWithPointers file = kv.Value;
				if (file != null && reader.Equals(file.reader)) {
					return file;
				}
			}
			foreach (Tuple<string, FileWithPointers> t in virtualFiles) {
				if (t.Item2 != null && reader.Equals(t.Item2.reader)) {
					return t.Item2;
				}
			}
			return null;
		}

		public FileWithPointers GetFileByWriter(Writer writer) {
			foreach (KeyValuePair<StringID, FileWithPointers> kv in files) {
				FileWithPointers file = kv.Value;
				if (file != null && writer.Equals(file.writer)) {
					return file;
				}
			}
			foreach (Tuple<string, FileWithPointers> t in virtualFiles) {
				if (t.Item2 != null && writer.Equals(t.Item2.writer)) {
					return t.Item2;
				}
			}
			return null;
		}

		protected async Task PrepareFile(string path) {
			if (FileSystem.mode == FileSystem.Mode.Web) {
				string state = loadingState;
				loadingState = state + "\nDownloading file: " + path;
				await FileSystem.DownloadFile(path);
				loadingState = state;
			}
		}

		protected async Task PrepareBigFile(string path, int cacheLength) {
			if (FileSystem.mode == FileSystem.Mode.Web) {
				string state = loadingState;
				loadingState = state + "\nInitializing bigfile: " + path + " (Cache size: " + Util.SizeSuffix(cacheLength, 0) + ")";
				await FileSystem.InitBigFile(path, cacheLength);
				loadingState = state;
			}
		}
	}
}