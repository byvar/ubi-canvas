
using UbiArt.FileFormat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using System.Collections;
using System.Threading.Tasks;
using Asyncoroutine;

namespace UbiArt {
	public class MapLoader {
		public string loadingState = "Loading";
		public string gameDataBinFolder;
		public string pathFolder;
		public string pathFile;
		//public string lvlName;

		public Material baseMaterial;
		public Material baseTransparentMaterial;
		public Material baseLightMaterial;
		public Material collideMaterial;
		public Material collideTransparentMaterial;

		public bool allowDeadPointers = false;
		public bool forceDisplayBackfaces = false;
		public bool blockyMode = false;

		public Dictionary<StringID, FileWithPointers> files = new Dictionary<StringID, FileWithPointers>();
		public delegate void SerializeAction(CSerializerObject s);
		public struct ObjectPlaceHolder {
			public Path path;
			public SerializeAction action;
			public ObjectPlaceHolder(Path path, SerializeAction action) {
				this.path = path;
				this.action = action;
			}
		}
		public Queue<ObjectPlaceHolder> pathsToLoad = new Queue<ObjectPlaceHolder>();

		public Dictionary<StringID, CList<Generic<ITF.FriseConfig>>> fcg = new Dictionary<StringID, CList<Generic<ITF.FriseConfig>>>();
		public Dictionary<StringID, CList<Generic<ITF.GFXMaterialShader_Template>>> msh = new Dictionary<StringID, CList<Generic<ITF.GFXMaterialShader_Template>>>();
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
				ITF.Scene mainScene = null;
				if (pathFile.EndsWith(".isc.ckd") || pathFile.EndsWith(".isc")) {
					Path p = new Path(pathFolder, pathFile);
					Load(p, (CSerializerObject s) => {
						s.flags |= SerializeFlags.Flags7 | SerializeFlags.Flags0;
						bool readScene = true;
						s.Serialize(ref readScene);
						if (readScene) { // Read scene
							s.Serialize(ref mainScene);
							print("Read:" + s.Position + " - Length:" + s.Length + " - " + (s.Position == s.Length ? "good!" : "bad!"));
						}
					});
				}
				bool ckd = true;
				while (pathsToLoad.Count > 0) {
					ObjectPlaceHolder o = pathsToLoad.Dequeue();
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
					await WaitFrame();
				}
				if (mainScene != null) {
					foreach (ITF.Frise f in mainScene.FRISE) {
						GameObject gao = f.Gao;
					}
					foreach (Generic<ITF.Actor> a in mainScene.ACTORS) {
						GameObject gao = a.obj.Gao;
					}
				}
			} catch (Exception ex) {
				Debug.LogError(ex.ToString());
			} finally {
				foreach (KeyValuePair<StringID, FileWithPointers> kv in files) {
					kv.Value.Dispose();
				}
				files.Clear();
			}
		}

		public void Load(Path path, SerializeAction action) {
			if (path.IsNull) return;
			if (files.ContainsKey(path.stringID)) {
				FileWithPointers f = files[path.stringID];
				CSerializerObject s = f.serializer;
				s.ResetPosition();
				action(s);
			} else {
				pathsToLoad.Enqueue(new ObjectPlaceHolder(path, action));
			}
		}

		// Defining it this way, clicking the print will go straight to the code you want
		public Action<object> print = MonoBehaviour.print;


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
			return null;
		}

		public FileWithPointers GetFileByWriter(Writer writer) {
			foreach (KeyValuePair<StringID, FileWithPointers> kv in files) {
				FileWithPointers file = kv.Value;
				if (file != null && writer.Equals(file.writer)) {
					return file;
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