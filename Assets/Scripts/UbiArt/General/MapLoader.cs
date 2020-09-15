
using UbiArt.FileFormat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using System.Collections;
using System.Text;
using System.Diagnostics;
using Cysharp.Threading.Tasks;

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
		public bool loadAnimations = false;

		public StringBuilder log = new StringBuilder();


		public ITF.RO2_GameManagerConfig_Template gameConfig;
		public ITF.Ray_GameManagerConfig_Template gameConfigRO;
		public ITF.RewardContainer_Template rewardList;

		public UV.UVAtlasManager uvAtlasManager;
		public SceneConfig.SceneConfigManager sceneConfigManager;
		public Localisation.Localisation_Template localisation;
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
		public Dictionary<StringID, FriseOrigins.FriseConfigOrigins> fcgOrigins = new Dictionary<StringID, FriseOrigins.FriseConfigOrigins>();
		public Dictionary<StringID, GenericFile<ITF.GFXMaterialShader_Template>> msh = new Dictionary<StringID, GenericFile<ITF.GFXMaterialShader_Template>>();
		public Dictionary<StringID, GenericFile<CSerializable>> isg = new Dictionary<StringID, GenericFile<CSerializable>>();
		public Dictionary<StringID, ContainerFile<ITF.Scene>> isc = new Dictionary<StringID, ContainerFile<ITF.Scene>>();
		public Dictionary<StringID, ContainerFile<ITF.Actor>> act = new Dictionary<StringID, ContainerFile<ITF.Actor>>();
		public Dictionary<StringID, Animation.AnimTrack> anm = new Dictionary<StringID, Animation.AnimTrack>();
		public Dictionary<StringID, Animation.AnimSkeleton> skl = new Dictionary<StringID, Animation.AnimSkeleton>();
		public Dictionary<StringID, Animation.AnimPatchBank> pbk = new Dictionary<StringID, Animation.AnimPatchBank>();
		public Dictionary<StringID, TextureCooked> tex = new Dictionary<StringID, TextureCooked>();
		public Dictionary<StringID, Path> paths = new Dictionary<StringID, Path>();
		public Dictionary<StringID, string> stringCache = new Dictionary<StringID, string>();

		public ContainerFile<ITF.Scene> mainScene;

		public Controller controller = null;
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
			// Init String Cache
			foreach (uint sid in ObjectFactory.classes.Keys) {
				stringCache.Add(new StringID(sid), ObjectFactory.classes[sid].Name);
			}
		}

		public async UniTask LoadInit() {
			try {

				Path pAtlas = new Path("", "atlascontainer.ckd");
				Load(pAtlas, (CSerializerObject s) => {
					s.Serialize(ref uvAtlasManager);
					print("Read:" + s.Position + " - Length:" + s.Length + " - " + (s.Position == s.Length ? "good!" : "bad!"));
				});
				Path pLoc = new Path("enginedata/localisation/", "localisation.loc8") { specialUncooked = true };
				Load(pLoc, (CSerializerObject s) => {
					s.Serialize(ref localisation);
					print("Read:" + s.Position + " - Length:" + s.Length + " - " + (s.Position == s.Length ? "good!" : "bad!"));

				});

				/*Path pGameConfigRO = new Path("gameconfig/", "gameconfig.isg.ckd");
				Load(pGameConfigRO, (CSerializerObject s) => {
					s.log = logEnabled;
					s.Serialize(ref gameConfigRO);
					print("Read:" + s.Position + " - Length:" + s.Length + " - " + (s.Position == s.Length ? "good!" : "bad!"));
				});*/
				//LoadGenericFile("enginedata/gameconfig/gameconfig.isg", (isg) => { gameConfig = isg.obj as ITF.RO2_GameManagerConfig_Template; });
				//LoadGenericFile("enginedata/gameconfig/rewardlist.isg", (isg) => { rewardList = isg.obj as ITF.RewardContainer_Template; });
				//LoadGenericFile("enginedata/gameconfig/homeconfig.isg", (isg) => { });
				//LoadGenericFile("enginedata/gameconfig/adventuresconfig.isg", (isg) => { });

				/*Path pSgsContainer = new Path("", "sgscontainer.ckd");
				Load(pSgsContainer, (CSerializerObject s) => {
					s.log = logEnabled;
					s.Serialize(ref sceneConfigManager);
					print("Read:" + s.Position + " - Length:" + s.Length + " - " + (s.Position == s.Length ? "good!" : "bad!"));
				});*/
				//LoadGenericFile("enginedata/gameconfig/ghostconfig.isg", (isg) => { });
				//LoadSaveFile("RaymanSave_0", (save) => { });
				//LoadSaveFileOrigins("Savegame_0", null);
				mainScene = null;
				if (pathFile.EndsWith(".isc.ckd") || pathFile.EndsWith(".isc") || pathFile.EndsWith(".tsc.ckd") || pathFile.EndsWith(".tsc")) {
					Path p = new Path(pathFolder, pathFile);
					Load(p, (CSerializerObject s) => {
						s.log = logEnabled;
						s.Serialize(ref mainScene);
						isc[p.stringID] = mainScene;
						Settings.s.isCatchThemAll = false;
					});
				}
				await LoadLoop();
				if (mainScene != null && mainScene.obj != null) {
					GameObject sceneGao = mainScene.obj.Gao;
				}
			} catch (Exception ex) {
				UnityEngine.Debug.LogError(ex.ToString());
				throw;
			}
		}
		protected async UniTask LoadLoop() {
			try {
				string state = loadingState;
				Controller.StartStopwatch();
				while (pathsToLoad.Count > 0) {
					ObjectPlaceHolder o = pathsToLoad.Dequeue();
					if (o.path != null) {
						StringID id = o.path.stringID;
						paths[id] = o.path;
						if (!files.ContainsKey(id)) {
							bool ckd = Settings.s.cooked && !o.path.specialUncooked;
							string cookedFolder = ckd ? Settings.s.ITFDirectory : "";
							await PrepareFile(gameDataBinFolder + "/" + cookedFolder + o.path.folder + o.path.filename + (ckd ? ".ckd" : ""));
							if (FileSystem.FileExists(gameDataBinFolder + "/" + cookedFolder + o.path.folder + o.path.filename + (ckd ? ".ckd" : ""))) {
								files.Add(id, new BinarySerializedFile(o.path.filename, o.path, ckd));
								loadingState = state + "\n" + o.path.FullPath;
								await Controller.WaitIfNecessary();
							}
						}
						if (files.ContainsKey(id)) {
							FileWithPointers f = files[id];
							CSerializerObject s = f.serializer;
							s.ResetPosition();
							o.action(s);
						}
					} else if (o.virtualFile != null) {
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
					await Controller.WaitIfNecessary();
					loadingState = state;
				}
			} finally {
				Controller.StopStopwatch();
				foreach (KeyValuePair<StringID, FileWithPointers> kv in files) {
					kv.Value.Dispose();
				}
				files.Clear();
				WriteLog();
			}
		}

		public static void ConfigureSerializeFlagsForExtension(ref SerializeFlags flags, ref CSerializerObject.Flags ownFlags, string extension) {
			switch (extension) {
				case "isc":
				case "tsc":
				case "act":
				case "ipk":
					flags |= SerializeFlags.Flags7;
					break;
				case "fcg":
				case "msh":
				case "tpl":
				case "isg":
					flags |= SerializeFlags.Flags7;
					ownFlags |= CSerializerObject.Flags.StoreObjectSizes;
					break;
				case null: // Save files
					flags |= SerializeFlags.Flags7;
					break;
			}
		}

		public bool IsPureBinary(string name, string extension) {
			if (name == "sgscontainer") {
				return false;
			}
			switch (extension) {
				case "anm":
				case "skl":
				case "pbk":
				case "tga":
				case "png":
				case "loc8":
				case null:
					return true;
				default:
					return false;
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
		public void Load(CString path, SerializeAction action) {
			if (path == null || path.str == null || path.str == "") return;
			Path p = new Path(path.str);
			Load(p, action);
		}

		public void Load(ArchiveMemory mem, string name, SerializeAction action) {
			pathsToLoad.Enqueue(new ObjectPlaceHolder(name, mem, action));
		}

		public async UniTask<ContainerFile<ITF.Actor>> LoadExtraActor(string pathFile, string pathFolder) {
			if (pathFile.EndsWith(".act") || pathFile.EndsWith(".act.ckd")) {
				Path p = new Path(pathFolder, pathFile);
				MapLoader l = MapLoader.Loader;
				ContainerFile<ITF.Actor> a = null;
				l.Load(p, (extS) => {
					if (l.act.ContainsKey(p.stringID)) {
						a = l.act[p.stringID];
					} else {
						extS.log = l.logEnabled;
						extS.Serialize(ref a);
						l.act[p.stringID] = a;
					}
				});
				await LoadLoop();
				return a;
			}
			return null;
		}

		public async UniTask<CSerializable> Clone(CSerializable cs, string extension) {
			CSerializable c = cs.Clone(extension);
			await LoadLoop();
			return c;
		}

		public async UniTask WriteBundle(string path, List<Pair<Path, ICSerializable>> files) {
			Bundle.BundleFile b = new Bundle.BundleFile();
			foreach (Pair<Path, ICSerializable> f in files) {
				b.AddFile(f.Item1.CookedPath, f.Item2);
			}
			Controller.StartStopwatch();
			await b.WriteBundle(path);
			Controller.StopStopwatch();
		}

		public void LoadGenericFile(string path, Action<GenericFile<CSerializable>> onResult) {
			Path pGeneric = new Path(path);
			Load(pGeneric, (CSerializerObject s) => {
				GenericFile<CSerializable> curIsg = null;
				if (isg.ContainsKey(pGeneric.stringID)) {
					curIsg = isg[pGeneric.stringID];
				} else {
					s.log = logEnabled;
					s.Serialize(ref curIsg);
					isg[pGeneric.stringID] = curIsg;
				}
				onResult(curIsg);
				print("Read:" + s.Position + " - Length:" + s.Length + " - " + (s.Position == s.Length ? "good!" : "bad!"));
			});
		}
		public void LoadSaveFile(string path, Action<RO2_SaveData> onResult) {
			Path pGeneric = new Path(path) { specialUncooked = true };
			Load(pGeneric, (CSerializerObject s) => {
				RO2_SaveData saveData = null;
				s.log = logEnabled;
				s.Serialize(ref saveData);
				onResult?.Invoke(saveData);
				print("Read:" + s.Position + " - Length:" + s.Length + " - " + (s.Position == s.Length ? "good!" : "bad!"));
			});
		}
		public void LoadSaveFileOrigins(string path, Action<Ray_SaveData> onResult) {
			Path pGeneric = new Path(path) { specialUncooked = true };
			Load(pGeneric, (CSerializerObject s) => {
				Ray_SaveData saveData = null;
				s.log = logEnabled;
				s.Serialize(ref saveData);
				onResult?.Invoke(saveData);
				print("Read:" + s.Position + " - Length:" + s.Length + " - " + (s.Position == s.Length ? "good!" : "bad!"));
			});
		}

		public async UniTask WriteActor(string path, ITF.Actor act) {
			Controller.StartStopwatch();
			// Clone actor
			CSerializable c = await Clone(act, "act");
			ITF.Actor actClone = c as ITF.Actor;
			// Reset clone transform
			actClone.SCALE = Vec2d.One;
			actClone.POS2D = Vec2d.Zero;
			actClone.RELATIVEZ = 0;
			actClone.xFLIPPED = false;
			actClone.USERFRIENDLY = "";
			// Add it to a container file
			ContainerFile<ITF.Actor> container = new ContainerFile<ITF.Actor>() {
				read = true,
				obj = actClone
			};
			// Serialize container file
			byte[] serializedData = null;
			using (MemoryStream stream = new MemoryStream()) {
				using (Writer writer = new Writer(stream, Settings.s.IsLittleEndian)) {
					CSerializerObjectBinaryWriter w = new CSerializerObjectBinaryWriter(writer);
					MapLoader.ConfigureSerializeFlagsForExtension(ref w.flags, ref w.flagsOwn, "act");
					object toWrite = container;
					w.Serialize(ref toWrite, container.GetType(), name: act.USERFRIENDLY);
					serializedData = stream.ToArray();
				}
			}
			await Controller.WaitIfNecessary();
			// Write serialized data to file
			Util.ByteArrayToFile(path, serializedData);
			Controller.StopStopwatch();
		}

		// Defining it this way, clicking the print will go straight to the code you want
		public Action<object> print = MonoBehaviour.print;
		public void Log(object obj) {
			if(logEnabled)
				log.AppendLine(obj != null ? obj.ToString() : "");
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

		protected async UniTask PrepareFile(string path) {
			if (FileSystem.mode == FileSystem.Mode.Web) {
				string state = loadingState;
				loadingState = state + "\nDownloading file: " + path;
				await FileSystem.DownloadFile(path);
				loadingState = state;
			}
		}

		protected async UniTask PrepareBigFile(string path, int cacheLength) {
			if (FileSystem.mode == FileSystem.Mode.Web) {
				string state = loadingState;
				loadingState = state + "\nInitializing bigfile: " + path + " (Cache size: " + Util.SizeSuffix(cacheLength, 0) + ")";
				await FileSystem.InitBigFile(path, cacheLength);
				loadingState = state;
			}
		}
	}
}