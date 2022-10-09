
using UbiArt.FileFormat;
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System.Text;
using Cysharp.Threading.Tasks;
using UbiArt.Bundle;
using UbiArt.UV;
using UbiCanvas.Helpers;
using System.Linq;
using Codice.CM.Common;

namespace UbiArt {
	public class Context {

		#region Constructors
		public Context(string basePath, Settings settings, ISerializerLog serializerLog = null, IFileManager fileManager = null, ISystemLog systemLog = null) {
			// Set properties from parameters
			FileManager = fileManager ?? new DefaultFileManager();
			SystemLog = systemLog;
			SerializerLog = serializerLog ?? new EmptySerializerLog();
			BasePath = NormalizePath(basePath, true);
			Settings = settings;

			// Initialize properties
			ObjectStorage = new Dictionary<string, object>();
			Cache = new SerializableCache(SystemLog);
			AdditionalSettings = new Dictionary<Type, object>();
			Files = new List<UbiArtFile>();

			InitStringCache();
		}

		#endregion

		#region Abstraction

#nullable enable
		public IFileManager FileManager { get; }
		public ISystemLog? SystemLog { get; }
#nullable restore

		#endregion

		#region Internal Fields

		internal object _threadLock = new object();

		#endregion

		#region Public Properties

		public string BasePath { get; }
		public SerializableCache Cache { get; }
		public ISerializerLog SerializerLog { get; }
		public List<UbiArtFile> Files { get; }

		#endregion

		#region Settings

		public Settings Settings { get; }

		protected Dictionary<Type, object> AdditionalSettings { get; }
		public T GetSettings<T>(bool throwIfNotFound = true) {
			var s = AdditionalSettings.TryGetValue(typeof(T), out object settings) ? settings : null;

			if (s != null)
				return (T)s;

			if (throwIfNotFound)
				throw new ContextException($"The requested serializer settings of type {typeof(T)} could not be found");

			return default;
		}
		public T AddSettings<T>(T settings) {
			AdditionalSettings[typeof(T)] = settings;
			return settings;
		}
		public void AddSettings(object settings, Type settingsType) {
			AdditionalSettings[settingsType] = settings;
		}
		public void RemoveSettings<T>() {
			AdditionalSettings.Remove(typeof(T));
		}
		public bool HasSettings<T>() {
			return AdditionalSettings.ContainsKey(typeof(T));
		}

		#endregion
		
		#region Storage

		protected Dictionary<string, object> ObjectStorage { get; }

		public T GetStoredObject<T>(string id, bool throwIfNotFound = false) {
			if (ObjectStorage.ContainsKey(id))
				return (T)ObjectStorage[id];

			if (throwIfNotFound)
				throw new ContextException($"The requested object with ID {id} could not be found");

			return default;
		}

		public void RemoveStoredObject(string id) {
			ObjectStorage.Remove(id);
		}

		public T StoreObject<T>(string id, T obj) {
			ObjectStorage[id] = obj;
			return obj;
		}

		#endregion

		#region Files


		private char SeparatorChar => FileManager.SeparatorCharacter switch
        {
            PathSeparatorChar.ForwardSlash => '/',
            PathSeparatorChar.BackSlash => '\\',
            _ => '/',
        };

		public Stream GetFileStream(string relativePath) {
			Stream str = FileManager.GetFileReadStream(GetAbsoluteFilePath(NormalizePath(relativePath, false)));
			return str;
		}
		public UbiArtFile GetFile(string relativePath) {
			string path = NormalizePath(relativePath, false);
			return Files.FirstOrDefault<UbiArtFile>(f => f.FilePath?.ToLower() == path?.ToLower() || f.Alias?.ToLower() == relativePath?.ToLower());
		}
		public virtual string GetAbsoluteFilePath(string relativePath) => BasePath + relativePath;
        public virtual string NormalizePath(string path, bool isDirectory)
        {
            // Get the path separator character
            string separatorChar = SeparatorChar.ToString();

            // Normalize the path
            string newPath = FileManager.SeparatorCharacter switch
            {
                PathSeparatorChar.ForwardSlash => path.Replace('\\', '/'),
                PathSeparatorChar.BackSlash => path.Replace('/', '\\'),
                _ => throw new ArgumentOutOfRangeException(nameof(FileManager.SeparatorCharacter), FileManager.SeparatorCharacter, null)
            };

            // Make sure a directory path ends with the separator
            if (isDirectory && !newPath.EndsWith(separatorChar) && !String.IsNullOrWhiteSpace(path)) 
                newPath += separatorChar;
            
            return newPath;
		}
		public T AddFile<T>(T file) where T : UbiArtFile {
			if (Files.Any(x => x.FilePath == file.FilePath))
				throw new ContextException($"A file with the path '{file.FilePath}' has already been added to the context");

			Files.Add(file);

			SystemLog?.LogTrace("Added file {0}", file.FilePath);

			return file;
		}
		public void RemoveFile(string filePath) => RemoveFile(GetFile(filePath));
		public void RemoveFile(UbiArtFile file) {
			if (file is null)
				return;

			Files.Remove(file);
			file.Dispose();

			SystemLog?.LogTrace("Removed file {0}", file.FilePath);
		}
		public bool FileExists(UbiArtFile file) {
			return Files.Contains(file);
		}
		public bool FileExists(string relativePath) {
			UbiArtFile f = GetFile(relativePath);
			return f != null;
		}
		#endregion

		#region String Cache
		public Dictionary<StringID, string> StringCache = new Dictionary<StringID, string>();

		protected void InitStringCache() {
			// Init String Cache
			foreach (uint sid in ObjectFactory.classes.Keys) {
				StringCache.Add(new StringID(sid), ObjectFactory.classes[sid].Name);
			}
		}

		public void AddToStringCache(object obj) {
			if (obj != null) {
				Type type = obj.GetType();
				if (type == typeof(string)) {
					string str = ((string)obj);
					if (!string.IsNullOrEmpty(str)) {
						StringCache[new StringID(str)] = str;
					}
				} else if (type == typeof(CString)) {
					string str = ((CString)obj).str;
					if (!string.IsNullOrEmpty(str)) {
						StringCache[new StringID(str)] = str;
					}
				} else if (type == typeof(BasicString)) {
					string str = ((BasicString)obj).str;
					if (!string.IsNullOrEmpty(str)) {
						StringCache[new StringID(str)] = str;
					}
				} else if (type == typeof(Path)) {
					Path p = ((Path)obj);
					if (!p.IsNull) {
						StringCache[p.stringID] = p.FullPath;
					}
				} else if (type == typeof(PathRef)) {
					PathRef p = ((PathRef)obj);
					if (!p.IsNull) {
						StringCache[p.stringID] = p.FullPath;
					}
				}
			}
		}
		#endregion


		#region Events

		public event EventHandler Disposed;

		#endregion

		#region Dispose

		public void Close() {
			foreach (var file in Files)
				file?.Dispose();

			SerializerLog.Dispose();
		}
		public void Dispose() {
			Close();
			Disposed?.Invoke(this, EventArgs.Empty);
		}

		#endregion


		public string loadingState = "Loading";
		public string pathFolder;
		public string pathFile;

		public bool loadAnimations = false;

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
		public Dictionary<string, BinaryBigFile> bigFiles = new Dictionary<string, BinaryBigFile>();
		public Dictionary<string, BundleFile> bundles = new Dictionary<string, BundleFile>();

		// Types
		public Dictionary<StringID, ICSerializable> tpl => Cache.Structs[typeof(GenericFile<ITF.Actor_Template>)];
		public Dictionary<StringID, ICSerializable> fcg => Cache.Structs[typeof(GenericFile<ITF.FriseConfig>)];
		public Dictionary<StringID, ICSerializable> isg => Cache.Structs[typeof(GenericFile<CSerializable>)];
		public Dictionary<StringID, ICSerializable> isc => Cache.Structs[typeof(ContainerFile<ITF.Scene>)];
		public Dictionary<StringID, ICSerializable> anm => Cache.Structs[typeof(Animation.AnimTrack)];
		public Dictionary<StringID, ICSerializable> tex => Cache.Structs[typeof(TextureCooked)];
		public Dictionary<StringID, Path> paths = new Dictionary<StringID, Path>();

		public ContainerFile<ITF.Scene> mainScene;

		protected bool GameFileExists(Path p, bool ckd) {
			string cookedFolder = ckd ? Settings.ITFDirectory : "";
			if (Settings.loadFromIPK && Settings.bundles != null) {
				Path path = ckd ? new Path(cookedFolder + p.folder, p.filename + (ckd ? ".ckd" : ""), cooked: true) : p;
				string[] bnames = Settings.bundles;
				foreach (var bname in bnames) {
					if (bundles.ContainsKey(bname) && bundles[bname].HasReadFile(path)) return true;
				}
				return false;
			} else {
				return FileManager.FileExists(BasePath + cookedFolder + p.folder + p.filename + (ckd ? ".ckd" : ""));
			}
		}
		public Stream GetGameFileStream(Path p, bool ckd) {
			string cookedFolder = ckd ? Settings.ITFDirectory : "";
			if (Settings.loadFromIPK && Settings.bundles != null) {
				Path path = ckd ? new Path(cookedFolder + p.folder, p.filename + (ckd ? ".ckd" : ""), cooked: true) : p;
				string[] bnames = Settings.bundles;
				foreach (var bname in bnames) {
					if (bundles.ContainsKey(bname) && bundles[bname].HasReadFile(path)) return bundles[bname].GetFileStream(path);
				}
				return null;
			} else {
				return FileManager.GetFileReadStream(BasePath + cookedFolder + p.folder + p.filename + (ckd ? ".ckd" : ""));
			}
		}
		protected async UniTask PrepareGameFile(Path p, bool ckd) {
			string cookedFolder = ckd ? Settings.ITFDirectory : "";
			if (Settings.loadFromIPK && Settings.bundles != null) {
				string s = loadingState;
				loadingState = "Downloading\n" + p.FullPath;
				await PrepareGameFile_Internal();
				loadingState = s;

				async UniTask PrepareGameFile_Internal() {
					Path path = ckd ? new Path(cookedFolder + p.folder, p.filename + (ckd ? ".ckd" : ""), cooked: true) : p;
					string[] bnames = Settings.bundles;
					// Loop 1: try to find an already loaded bundle and an already loaded file
					foreach (var bname in bnames) {
						if (bundles.ContainsKey(bname) && bundles[bname].HasReadFile(path)) return;
					}
					// Loop 2: try to find an already loaded bundle and an already loaded file
					foreach (var bname in bnames) {
						if (bundles.ContainsKey(bname)) {
							byte[] data = await bundles[bname].GetFile(this, bigFiles[bname].Deserializer, path);
							if (data != null) return;
						}
					}
					// Loop 3: load new bundles until you find the file
					foreach (var bname in bnames) {
						if (!bundles.ContainsKey(bname)) {
							string fileName = $"{bname}_{Settings.PlatformString}.ipk";
							string fullPath = $"{BasePath}{fileName}";
							await FileSystem.PrepareBigFile(fullPath, 0);
							if (!FileManager.FileExists(fullPath)) continue;
							bigFiles[bname] = new BinaryBigFile(this, fileName) {
								Alias = bname
							};
							bundles[bname] = new BundleFile();
							await bundles[bname].SerializeAsync(bigFiles[bname].Deserializer, bname);
						}
						if (bundles.ContainsKey(bname)) {
							byte[] data = await bundles[bname].GetFile(this, bigFiles[bname].Deserializer, path);
							if (data != null) return;
						}
					}
				}
			} else {
				await FileSystem.PrepareFile(BasePath + cookedFolder + p.folder + p.filename + (ckd ? ".ckd" : ""));
			}
		}

		public async UniTask LoadInit() {
			try {

				Path pAtlas = new Path("", "atlascontainer.ckd");
				LoadFile<UVAtlasManager>(pAtlas, result => uvAtlasManager = result);
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
					LoadFile<ContainerFile<ITF.Scene>>(p, result => {
						mainScene = result;
						Settings.isCatchThemAll = false;
					});
				}
				await LoadLoop();
				if (mainScene != null && mainScene.obj != null) {
					GameObject sceneGao = await mainScene.obj.GetGameObject();
				}
			} finally {
			}
		}
		protected async UniTask LoadLoop() {
			try {
				string state = loadingState;
				TimeController.StartStopwatch();
				while (pathsToLoad.Count > 0) {
					ObjectPlaceHolder o = pathsToLoad.Dequeue();
					if (o.path != null) {
						StringID id = o.path.stringID;
						paths[id] = o.path;
						if (!files.ContainsKey(id)) {
							bool ckd = Settings.cooked && !o.path.specialUncooked;
							string cookedFolder = ckd ? Settings.ITFDirectory : "";
							await PrepareGameFile(o.path, ckd);
							if (GameFileExists(o.path, ckd)) {
								files.Add(id, new BinaryGameFile(this, o.path.filename, o.path, ckd));
								loadingState = state + "\n" + o.path.FullPath;
								await TimeController.WaitIfNecessary();
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
								SystemLog?.LogInfo($"{s.CurrentPointer}: Did not fully serialize file! Length: {s.Length:X8}");
							}
							f.Dispose();
						}
					} else if (o.virtualFile != null) {
						using (MemoryStream str = new MemoryStream(o.virtualFile.Item2.AMData)) {
							UbiArtFile f = new BinaryStreamFile(this, o.virtualFile.Item1, str);
							Tuple<string, UbiArtFile> t = new Tuple<string, UbiArtFile>(o.virtualFile.Item1, f);
							virtualFiles.Add(t);
							CSerializerObject s = f.Deserializer;
							s.ResetPosition();
							o.action(s);
							f.Dispose();
							virtualFiles.Remove(t);
						}
					}
					await TimeController.WaitIfNecessary();
					loadingState = state;
				}
			} finally {
				TimeController.StopStopwatch();
				foreach (KeyValuePair<StringID, UbiArtFile> kv in files) {
					kv.Value.Dispose();
				}
				files.Clear();
				Dispose();
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
				case "ipk":
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
					SystemLog?.LogInfo($"{s.CurrentPointer}: Did not fully serialize file! Length: {s.Length:X8}");
				}
			} else {
				pathsToLoad.Enqueue(new ObjectPlaceHolder(path, action));
			}
		}

		public void Load(ArchiveMemory mem, string name, SerializeAction action) {
			pathsToLoad.Enqueue(new ObjectPlaceHolder(name, mem, action));
		}

		public async UniTask<ContainerFile<ITF.Actor>> LoadExtraActor(string pathFile, string pathFolder) {
			if (pathFile.EndsWith(".act") || pathFile.EndsWith(".act.ckd")) {
				Path p = new Path(pathFolder, pathFile);
				Context l = this;
				ContainerFile<ITF.Actor> a = null;
				l.LoadFile<ContainerFile<ITF.Actor>>(p, result => a = result);
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
				b.AddFile(f.Item1.CookedPath(this), f.Item2);
			}
			TimeController.StartStopwatch();
			await b.WriteBundle(this, path);
			TimeController.StopStopwatch();
		}

		public void LoadFile<T>(Path path, Action<T> onResult) where T : class, ICSerializable, new() {
			var t = Cache.Get<T>(path.stringID);
			if (t != null) {
				onResult(t);
			} else {
				Load(path, (CSerializerObject s) => {
					var cachedObject = Cache.Get<T>(path.stringID);
					if (cachedObject == null) {
						cachedObject = s.SerializeObject<T>(cachedObject);
						Cache.Add<T>(path.stringID, cachedObject);
					}
					onResult(cachedObject);
				});
			}
		}

		public void LoadTexture(Path path, Action<TextureCooked> onResult) {
			LoadFile<TextureCooked>(path, (result) => {
				if (result != null && result.atlas == null)
					result.atlas = uvAtlasManager.GetAtlasIfExists(path);
				onResult(result);
			});
		}

		public void LoadGenericFile(Path path, Action<GenericFile<CSerializable>> onResult) => LoadFile<GenericFile<CSerializable>>(path, onResult);

		public void LoadUncooked<T>(string path, Action<T> onResult) where T : class, ICSerializable, new() {
			Path pGeneric = new Path(path) { specialUncooked = true };
			LoadFile<T>(pGeneric, onResult);
		}

		public void LoadSaveFile(string path, Action<RO2_SaveData> onResult) => LoadUncooked<RO2_SaveData>(path, onResult);
		public void LoadSaveFileOrigins(string path, Action<Ray_SaveData> onResult) => LoadUncooked<Ray_SaveData>(path, onResult);

		public async UniTask WriteActor(string path, ITF.Actor act) {
			TimeController.StartStopwatch();
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
					CSerializerObjectBinaryWriter w = new CSerializerObjectBinaryWriter(this, writer);
					Context.ConfigureSerializeFlagsForExtension(ref w.flags, ref w.flagsOwn, "act");
					object toWrite = container;
					w.Serialize(ref toWrite, container.GetType(), name: act.USERFRIENDLY);
					serializedData = stream.ToArray();
				}
			}
			await TimeController.WaitIfNecessary();
			// Write serialized data to file
			Util.ByteArrayToFile(path, serializedData);
			TimeController.StopStopwatch();
		}
	}
}