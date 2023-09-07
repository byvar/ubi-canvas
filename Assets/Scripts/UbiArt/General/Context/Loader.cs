using System;
using System.Collections.Generic;
using System.IO;
using UbiArt.Bundle;
using UbiArt.UV;
using UbiArt.FileFormat;
using System.Threading.Tasks;
using System.Linq;
using UbiArt.ITF;

namespace UbiArt {
	public class Loader {

		#region Constructors
		public Loader(Context context) {
			Context = context;
		}

		#endregion

		#region Public Properties

		public Context Context { get; }
		public Settings Settings => Context.Settings;
		public SerializableCache Cache => Context.Cache;
		public IFileManager FileManager => Context.FileManager;

		public bool IsInitialized { get; protected set; }

		#endregion


		public string LoadingState = "Loading";

		public bool LoadAnimations { get; set; } = false;
		public bool LoadAllPaths { get; set; } = false;

		public ITF.RO2_GameManagerConfig_Template gameConfig;
		public ITF.Ray_GameManagerConfig_Template gameConfigRO;
		public ITF.RewardContainer_Template rewardList;

		public UV.UVAtlasManager uvAtlasManager;
		public SceneConfig.SceneConfigManager sceneConfigManager;
		public Localisation.Localisation_Template localisation;
		public Dictionary<StringID, UbiArtFile> files = new Dictionary<StringID, UbiArtFile>();
		public List<Tuple<string, UbiArtFile>> virtualFiles = new List<Tuple<string, UbiArtFile>>();

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

		// Load from IPK
		public Dictionary<string, BinaryBigFile> BigFiles { get; private set; } = new Dictionary<string, BinaryBigFile>();
		public Dictionary<string, BundleFile> Bundles { get; private set; } = new Dictionary<string, BundleFile>();

		// Types
		public Dictionary<StringID, ICSerializable> tpl => Context.Cache.Structs.GetValueOrDefault(typeof(GenericFile<ITF.Actor_Template>));
		public Dictionary<StringID, ICSerializable> fcg => Context.Cache.Structs.GetValueOrDefault(typeof(GenericFile<ITF.FriseConfig>));
		public Dictionary<StringID, ICSerializable> isg => Context.Cache.Structs.GetValueOrDefault(typeof(GenericFile<CSerializable>));
		public Dictionary<StringID, ICSerializable> isc => Context.Cache.Structs.GetValueOrDefault(typeof(ContainerFile<ITF.Scene>));
		public Dictionary<StringID, ICSerializable> anm => Context.Cache.Structs.GetValueOrDefault(typeof(Animation.AnimTrack));
		public Dictionary<StringID, ICSerializable> tex => Context.Cache.Structs.GetValueOrDefault(typeof(TextureCooked));
		public Dictionary<StringID, Path> Paths { get; private set; } = new Dictionary<StringID, Path>();
		public Dictionary<StringID, Path> CookedPaths { get; private set; } = new Dictionary<StringID, Path>();

		public List<Actor> LoadedActors = new List<Actor>();

		protected bool GameFileExists(Path p, bool ckd) {
			string cookedFolder = ckd ? Settings.ITFDirectory : "";
			if (Settings.loadFromIPK && Settings.bundles != null) {
				Path path = ckd ? new Path($"{cookedFolder}{p.folder}", $"{p.filename}{(ckd ? ".ckd" : "")}", cooked: true) : p;
				string[] bnames = Settings.bundles;
				foreach (var bname in bnames) {
					if (Bundles.ContainsKey(bname) && Bundles[bname].HasReadFile(path)) return true;
				}
				return false;
			} else {
				return FileManager.FileExists($"{Context.BasePath}{cookedFolder}{p.folder}{p.filename}{(ckd ? ".ckd" : "")}");
			}
		}
		public Stream GetGameFileStream(Path p, bool ckd) {
			string cookedFolder = ckd ? Settings.ITFDirectory : "";
			if (Settings.loadFromIPK && Settings.bundles != null) {
				Path path = ckd ? new Path($"{cookedFolder}{p.folder}", $"{p.filename}{(ckd ? ".ckd" : "")}", cooked: true) : p;
				string[] bnames = Settings.bundles;
				foreach (var bname in bnames) {
					if (Bundles.ContainsKey(bname) && Bundles[bname].HasReadFile(path)) return Bundles[bname].GetFileStream(path);
				}
				return null;
			} else {
				return FileManager.GetFileReadStream($"{Context.BasePath}{cookedFolder}{p.folder}{p.filename}{(ckd ? ".ckd" : "")}");
			}
		}
		public async Task LoadBundles() {
			string[] bnames = Settings.bundles;
			foreach (var bname in bnames) {
				await LoadBundle(bname);
			}
		}
		public async Task LoadBundle(string bname) {
			if (!Bundles.ContainsKey(bname)) {
				string fileName = $"{bname}_{Settings.PlatformString}.ipk";
				string fullPath = $"{Context.BasePath}{fileName}";
				await FileManager.PrepareBigFile(fullPath, 0);
				if (!FileManager.FileExists(fullPath)) return;
				BigFiles[bname] = new BinaryBigFile(Context, fileName) {
					Alias = bname
				};
				Bundles[bname] = new BundleFile();
				await Bundles[bname].SerializeAsync(BigFiles[bname].Deserializer, bname);
			}
		}
		public bool AnyBundleContainsFile(Path path) => Bundles.Any(b => b.Value.ContainsFile(path));
		public Path GetPathFromBundleByStringID(StringID id) => Bundles.Values.FirstOrDefault(b => b.GetPathByStringID(id) != null)?.GetPathByStringID(id);

		public async Task<byte[]> GetFileFromBundles(Path p, bool ckd) {
			string cookedFolder = ckd ? Settings.ITFDirectory : "";
			Path path = ckd ? new Path($"{cookedFolder}{p.folder}", $"{p.filename}{(ckd ? ".ckd" : "")}", cooked: true) : p;
			string[] bnames = Settings.bundles;
			// Loop 1: try to find an already loaded bundle and an already loaded file
			foreach (var bname in bnames) {
				if (Bundles.ContainsKey(bname) && Bundles[bname].HasReadFile(path)) {
					byte[] data = await Bundles[bname].GetFile(Context, BigFiles[bname].Deserializer, path);
					if (data != null) return data;
				}
			}
			// Loop 2: try to find an already loaded bundle and an already loaded file
			foreach (var bname in bnames) {
				if (Bundles.ContainsKey(bname)) {
					byte[] data = await Bundles[bname].GetFile(Context, BigFiles[bname].Deserializer, path);
					if (data != null) return data;
				}
			}
			// Loop 3: load new bundles until you find the file
			foreach (var bname in bnames) {
				if (!Bundles.ContainsKey(bname)) {
					string fileName = $"{bname}_{Settings.PlatformString}.ipk";
					string fullPath = $"{Context.BasePath}{fileName}";
					await FileManager.PrepareBigFile(fullPath, 0);
					if (!FileManager.FileExists(fullPath)) continue;
					BigFiles[bname] = new BinaryBigFile(Context, fileName) {
						Alias = bname
					};
					Bundles[bname] = new BundleFile();
					await Bundles[bname].SerializeAsync(BigFiles[bname].Deserializer, bname);
				}
				if (Bundles.ContainsKey(bname)) {
					byte[] data = await Bundles[bname].GetFile(Context, BigFiles[bname].Deserializer, path);
					if (data != null) return data;
				}
			}
			return null;
		}
		protected async Task PrepareGameFile(Path p, bool ckd) {
			string cookedFolder = ckd ? Settings.ITFDirectory : "";
			if (Settings.loadFromIPK && Settings.bundles != null) {
				string s = LoadingState;
				LoadingState = $"Downloading\n{p.FullPath}";
				await PrepareGameFile_Internal();
				LoadingState = s;

				async Task PrepareGameFile_Internal() {
					Path path = ckd ? new Path($"{cookedFolder}{p.folder}", $"{p.filename}{(ckd ? ".ckd" : "")}", cooked: true) : p;
					string[] bnames = Settings.bundles;
					// Loop 1: try to find an already loaded bundle and an already loaded file
					foreach (var bname in bnames) {
						if (Bundles.ContainsKey(bname) && Bundles[bname].HasReadFile(path)) return;
					}
					// Loop 2: try to find an already loaded bundle and an already loaded file
					foreach (var bname in bnames) {
						if (Bundles.ContainsKey(bname)) {
							byte[] data = await Bundles[bname].GetFile(Context, BigFiles[bname].Deserializer, path);
							if (data != null) return;
						}
					}
					// Loop 3: load new bundles until you find the file
					foreach (var bname in bnames) {
						if (!Bundles.ContainsKey(bname)) {
							string fileName = $"{bname}_{Settings.PlatformString}.ipk";
							string fullPath = $"{Context.BasePath}{fileName}";
							await FileManager.PrepareBigFile(fullPath, 0);
							if (!FileManager.FileExists(fullPath)) continue;
							BigFiles[bname] = new BinaryBigFile(Context, fileName) {
								Alias = bname
							};
							Bundles[bname] = new BundleFile();
							await Bundles[bname].SerializeAsync(BigFiles[bname].Deserializer, bname);
						}
						if (Bundles.ContainsKey(bname)) {
							byte[] data = await Bundles[bname].GetFile(Context, BigFiles[bname].Deserializer, path);
							if (data != null) return;
						}
					}
				}
			} else {
				await FileManager.PrepareFile($"{Context.BasePath}{cookedFolder}{p.folder}{p.filename}{(ckd ? ".ckd" : "")}");
			}
		}

		public async Task LoadInitial() {
			// Load UV Atlas manager for textures
			Path pAtlas = new Path("", "atlascontainer.ckd");
			LoadFile<UVAtlasManager>(pAtlas, result => uvAtlasManager = result);

			// Load localization
			Path pLoc = new Path("enginedata/localisation/", "localisation.loc8") { specialUncooked = true };
			LoadFile<Localisation.Localisation_Template>(pLoc, result => localisation = result);

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
			LoadFile<SceneConfig.SceneConfigManager>(pSgsContainer, result => sceneConfigManager = result);*/
			//LoadGenericFile("enginedata/gameconfig/ghostconfig.isg", (isg) => { });
			//LoadSaveFile("RaymanSave_0", (save) => { });
			//LoadSaveFileOrigins("Savegame_0", null);

			await LoadLoop();
		}

		public async Task<ContainerFile<ITF.Scene>> LoadScene(Path path) {
			try {
				ContainerFile<ITF.Scene> scene = null;
				var pathFile = path.filename;
				if (pathFile.EndsWith(".isc.ckd") || pathFile.EndsWith(".isc") || pathFile.EndsWith(".tsc.ckd") || pathFile.EndsWith(".tsc")) {
					LoadFile<ContainerFile<ITF.Scene>>(path, result => {
						scene = result;
					});
				}
				await LoadLoop();
				return scene;
			} finally {
			}
		}
		public async Task LoadLoop() {
			try {
				string state = LoadingState;
				Context.AsyncController.StartAsync();
				while (pathsToLoad.Count > 0) {
					ObjectPlaceHolder o = pathsToLoad.Dequeue();
					if (o.path != null) {
						StringID id = o.path.stringID;
						Paths[id] = o.path;
						if (!files.ContainsKey(id)) {
							bool ckd = Settings.cooked && !o.path.specialUncooked;
							string cookedFolder = ckd ? Settings.ITFDirectory : "";
							await PrepareGameFile(o.path, ckd);
							if (GameFileExists(o.path, ckd)) {
								Path ckdPath = ckd ? new Path($"{cookedFolder}{o.path.folder}", $"{o.path.filename}{(ckd ? ".ckd" : "")}", cooked: true) : o.path;
								CookedPaths[id] = ckdPath;
								files.Add(id, new BinaryGameFile(Context, o.path.filename, o.path, ckd));
								LoadingState = $"{state}\n{o.path.FullPath}";
								await Context.AsyncController.WaitIfNecessary();
							}
						}
						if (files.ContainsKey(id)) {
							UbiArtFile f = files[id];
							CSerializerObject s = f.Deserializer;
							s.ResetPosition();
							o.action(s);
							if (s.CurrentPosition == s.Length) {
								//SystemLog?.LogInfo($"{s.CurrentPointer}: OK");
							} else if (s.CurrentPosition != 0) {
								Context.SystemLogger?.LogInfo($"{s.CurrentPointer}: Did not fully serialize file! Length: {s.Length:X8}");
							}
							f.Dispose();
						} else {
							if (LoadAllPaths) {
								Context.SystemLogger?.LogInfo($"Path does not exist: {o.path.FullPath}");
							}
						}
					} else if (o.virtualFile != null) {
						using (MemoryStream str = new MemoryStream(o.virtualFile.Item2.AMData)) {
							UbiArtFile f = new BinaryStreamFile(Context, o.virtualFile.Item1, str);
							Tuple<string, UbiArtFile> t = new Tuple<string, UbiArtFile>(o.virtualFile.Item1, f);
							virtualFiles.Add(t);
							CSerializerObject s = f.Deserializer;
							s.ResetPosition();
							o.action(s);
							f.Dispose();
							virtualFiles.Remove(t);
						}
					}
					await Context.AsyncController.WaitIfNecessary();
					LoadingState = state;
				}
			} finally {
				Context.AsyncController.StopAsync();
				foreach (KeyValuePair<StringID, UbiArtFile> kv in files) {
					kv.Value.Dispose();
				}
				files.Clear();
			}
		}

		public static void ConfigureSerializeFlagsForExtension(ref SerializeFlags flags, ref CSerializerObject.SerializerProperty ownFlags, string extension) {
			switch (extension) {
				case "isc":
				case "tsc":
				case "act":
				case "ipk":
				case "gf":
					flags |= SerializeFlags.Flags7;
					break;
				case "fcg":
				case "msh":
				case "tpl":
				case "isg":
				case "gmt":
				case "cache":
					flags |= SerializeFlags.Flags7;
					ownFlags |= CSerializerObject.SerializerProperty.StoreObjectSizes;
					break;
				case null: // Save files
				case "":
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
				case "ipk":
				case "asc":
				case "m3d":
				case "gf":
				case null:
					return true;
				default:
					return false;
			}
		}

		protected void Load(Path path, SerializeAction action) {
			if (path == null || path.IsNull) return;
			if (files.ContainsKey(path.stringID)) {
				UbiArtFile f = files[path.stringID];
				CSerializerObject s = f.Deserializer;
				s.ResetPosition();
				action(s);
				if (s.CurrentPosition == s.Length) {
					//SystemLog?.LogInfo($"{s.CurrentPointer}: OK");
				} else if(s.CurrentPosition != 0) {
					Context.SystemLogger?.LogInfo($"{s.CurrentPointer}: Did not fully serialize file! Length: {s.Length:X8}");
				}
			} else {
				pathsToLoad.Enqueue(new ObjectPlaceHolder(new Path(path), action));
			}
		}

		public void Load(ArchiveMemory mem, string name, SerializeAction action) {
			pathsToLoad.Enqueue(new ObjectPlaceHolder(name, mem, action));
		}

		public async Task<ContainerFile<ITF.Actor>> LoadExtraActor(string pathFile, string pathFolder) {
			if (pathFile.EndsWith(".act") || pathFile.EndsWith(".act.ckd")) {
				Path p = new Path(pathFolder, pathFile);
				Loader l = this;
				ContainerFile<ITF.Actor> a = null;
				l.LoadFile<ContainerFile<ITF.Actor>>(p, result => a = result);
				await LoadLoop();
				return a;
			}
			return null;
		}

		public async Task<CSerializable> Clone(CSerializable cs, string extension) {
			CSerializable c = cs.Clone(extension);
			await LoadLoop();
			return c;
		}

		public async Task WriteBundle(string path, List<pair<Path, ICSerializable>> files) {
			Bundle.BundleFile b = new Bundle.BundleFile();
			foreach (pair<Path, ICSerializable> f in files) {
				b.AddFile(f.Item1.CookedPath(Context), f.Item2);
			}
			await WriteBundle(path, b);
		}
		public async Task WriteBundle(string path, Bundle.BundleFile b) {
			Context.AsyncController.StartAsync();
			await b.WriteBundle(Context, path);
			Context.AsyncController.StopAsync();
		}
		public async Task WriteFilesRaw(string path, List<pair<Path, ICSerializable>> files) {
			Bundle.BundleFile b = new Bundle.BundleFile();
			foreach (pair<Path, ICSerializable> f in files) {
				b.AddFile(f.Item1.CookedPath(Context), f.Item2);
			}
			await WriteFilesRaw(path, b);
		}
		public async Task WriteFilesRaw(string path, Bundle.BundleFile b) {
			Context.AsyncController.StartAsync();
			await b.WriteFilesRaw(Context, path);
			Context.AsyncController.StopAsync();
		}

		public void LoadFile<T>(Path path) where T : class, ICSerializable, new()
		{
			var t = Cache.Get<T>(path.stringID);
			if (t == null) {
				Load(path, (CSerializerObject s) => {
					var cachedObject = Cache.Get<T>(path.stringID);
					if (cachedObject == null) {
						cachedObject = s.SerializeObject<T>(cachedObject);
						Cache.Add<T>(path.stringID, cachedObject);
					}
				});
			}
		}

		public void LoadFile<T>(Path path, Action<T> onResult) where T : class, ICSerializable, new() {
			var t = Cache.Get<T>(path.stringID);
			if (t != null) {
				onResult?.Invoke(t);
			} else {
				Load(path, (CSerializerObject s) => {
					var cachedObject = Cache.Get<T>(path.stringID);
					if (cachedObject == null) {
						cachedObject = s.SerializeObject<T>(cachedObject);
						Cache.Add<T>(path.stringID, cachedObject);
					}
					onResult?.Invoke(cachedObject);
				});
			}
		}

		public void LoadTexture(Path path, Action<TextureCooked> onResult) {
			if (path == null) return;

			LoadFile<TextureCooked>(path, (result) => {
				if (result != null && result.atlas == null)
					result.atlas = uvAtlasManager.GetAtlasIfExists(path);
				onResult?.Invoke(result);
			});
		}

		public void LoadGenericFile(Path path, Action<GenericFile<CSerializable>> onResult) => LoadFile<GenericFile<CSerializable>>(path, onResult);

		public void LoadUncooked<T>(string path, Action<T> onResult) where T : class, ICSerializable, new() {
			Path pGeneric = new Path(path) { specialUncooked = true };
			LoadFile<T>(pGeneric, onResult);
		}

		public void LoadSaveFile(string path, Action<RO2_SaveData> onResult) => LoadUncooked<RO2_SaveData>(path, onResult);
		public void LoadSaveFileOrigins(string path, Action<Ray_SaveData> onResult) => LoadUncooked<Ray_SaveData>(path, onResult);
		public void LoadSaveFileAdventures(string path, Action<RLC_SaveData> onResult) => LoadUncooked<RLC_SaveData>(path, onResult);

		public async Task<byte[]> WriteActorFile(ITF.Actor act) {
			Context.AsyncController.StartAsync();

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
				using (Writer writer = new Writer(stream, Settings.IsLittleEndian)) {
					CSerializerObjectBinaryWriter w = new CSerializerObjectBinaryWriter(Context, writer);
					Loader.ConfigureSerializeFlagsForExtension(ref w.flags, ref w.properties, "act");
					object toWrite = container;
					w.Serialize(ref toWrite, container.GetType(), name: act.USERFRIENDLY);
					serializedData = stream.ToArray();
				}
			}
			await Context.AsyncController.WaitIfNecessary();
			Context.AsyncController.StopAsync();

			return serializedData;
		}
	}
}