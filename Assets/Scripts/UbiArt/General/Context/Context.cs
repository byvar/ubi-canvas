using UbiArt.FileFormat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace UbiArt
{
	public class Context : IDisposable
	{
		#region Constructor
	
		public Context(
			string basePath, 
			Settings settings,
			ISerializerLogger serializerLogger = null,
			IFileManager fileManager = null,
			ISystemLogger systemLogger = null,
			IAsyncController asyncController = null)
		{
			// Set properties from parameters
			FileManager = fileManager ?? new DefaultFileManager();
			SystemLogger = systemLogger;
			SerializerLogger = serializerLogger ?? new EmptySerializerLogger();
			AsyncController = asyncController ?? new EmptyAsyncController();
			BasePath = NormalizePath(basePath, true);
			Settings = settings;

			// Initialize properties
			ObjectStorage = new Dictionary<string, object>();
			Cache = new SerializableCache(SystemLogger);
			AdditionalSettings = new Dictionary<Type, object>();
			Files = new List<UbiArtFile>();

			Loader = new Loader(this);

			InitStringCache();
		}

		#endregion

		#region Abstraction

#nullable enable
		public IFileManager FileManager { get; }
		public ISystemLogger? SystemLogger { get; }
		public ISerializerLogger SerializerLogger { get; }
		public IAsyncController AsyncController { get; }
#nullable restore

		#endregion

		#region Internal Fields

		internal object _threadLock = new object();

		#endregion

		#region Public Properties

		public string BasePath { get; }
		public SerializableCache Cache { get; }
		public List<UbiArtFile> Files { get; }
		public Loader Loader { get; }

		#endregion

		#region Settings

		public Settings Settings { get; protected set; }

		public void ChangeSettings(Settings newSettings) {
			Settings = newSettings;
		}

		protected Dictionary<Type, object> AdditionalSettings { get; }
		public T GetSettings<T>(bool throwIfNotFound = true)
		{
			var s = AdditionalSettings.TryGetValue(typeof(T), out object settings) ? settings : null;

			if (s != null)
				return (T)s;

			if (throwIfNotFound)
				throw new ContextException($"The requested serializer settings of type {typeof(T)} could not be found");

			return default;
		}
		public T AddSettings<T>(T settings)
		{
			AdditionalSettings[typeof(T)] = settings;
			return settings;
		}
		public void AddSettings(object settings, Type settingsType)
		{
			AdditionalSettings[settingsType] = settings;
		}
		public void RemoveSettings<T>()
		{
			AdditionalSettings.Remove(typeof(T));
		}
		public bool HasSettings<T>()
		{
			return AdditionalSettings.ContainsKey(typeof(T));
		}

		#endregion

		#region Storage

		protected Dictionary<string, object> ObjectStorage { get; }

		public T GetStoredObject<T>(string id, bool throwIfNotFound = false)
		{
			if (ObjectStorage.ContainsKey(id))
				return (T)ObjectStorage[id];

			if (throwIfNotFound)
				throw new ContextException($"The requested object with ID {id} could not be found");

			return default;
		}

		public void RemoveStoredObject(string id)
		{
			ObjectStorage.Remove(id);
		}

		public T StoreObject<T>(string id, T obj)
		{
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

		public Stream GetFileStream(string relativePath)
		{
			Stream str = FileManager.GetFileReadStream(GetAbsoluteFilePath(NormalizePath(relativePath, false)));
			return str;
		}
		public UbiArtFile GetFile(string relativePath)
		{
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
		public T AddFile<T>(T file) where T : UbiArtFile
		{
			if (Files.Any(x => x.FilePath == file.FilePath))
				throw new ContextException($"A file with the path '{file.FilePath}' has already been added to the context");

			Files.Add(file);

			SystemLogger?.LogTrace("Added file {0}", file.FilePath);

			return file;
		}
		public void RemoveFile(string filePath) => RemoveFile(GetFile(filePath));
		public void RemoveFile(UbiArtFile file)
		{
			if (file is null)
				return;

			Files.Remove(file);
			file.Dispose();

			SystemLogger?.LogTrace("Removed file {0}", file.FilePath);
		}
		public bool FileExists(UbiArtFile file)
		{
			return Files.Contains(file);
		}
		public bool FileExists(string relativePath)
		{
			UbiArtFile f = GetFile(relativePath);
			return f != null;
		}
		#endregion

		#region String Cache
		public Dictionary<StringID, string> StringCache = new Dictionary<StringID, string>();

		private List<string> AdditionalStrings = new List<string>() {
			// Evaluation
			">", ">=", "<", "<=", "&", "==", "!=",

			// Link Tags
			"After", "Ambiance", "Ambiance_Off", "Angle", "AngleOffset", "Delay", "Anim", "AnimBone", "Attack", "AutoStart",
			"BaseJump", "Before", "BlendFrise", "BoneName", "Branch", "Breakable", "Bubo", "Cam", "Camera", "ChangeScale", "Checkpoint", "CineOutro", "Curve",
			"Death", "Delay", "Disabled", "Disappear", "Door", "Drag", "Duration", "Eject", "Fishing", "Flame", "Flip", "FollowCam", "Ghost", "Hang",
			"IgnoreCamera", "Keep_Orientation", "Lock", "Lookat", "LookatPhase", "MaxSpeed", "MinSpeed", "Moving", "NoLook", "NoTree", "Node", "Number",
			"Offset", "ProceduralBone", "RadarTarget", "Roll", "RopeEnd", "SafeDistance", "Spawn", "SpawnPos", "Speed", "SpeedMax", "Screenshot",
			"TakeCamera", "Target", "Teleport", "TouchScreen", "Torture", "Trigger", "Type", "Waypoint",

			// Animation inputs
			"Move", "Jump", "Angle", "IsSprinting", "Speed", "Stance", "UTurn", "InAir", "IsPathBlocked",
			"MoveX", "MoveY", "SpeedX", "SpeedY", "SpeedZ",
			"AcrobaticStage", "StargateStage", "CoopMode", "CrushReleased", "CrushTravelTime",
			"WaitType", "DeathType", "HangType", "IdleTime",
			"GroundAngle", "OnLoop", "BounceToLayer",
			"PunchDistance", "PunchLevel", "PunchOrientation", "PunchHitType", "PunchReleaseResult", "PunchWalk",
			"ReceivedHitLevel", "ReceivedHitType",
			"AirPose", "ActionPose", "OrientationPose",
			"MoveCursor", "PrepareHitCursor", "SwimCurveCursor",
			"AngleRangeMin", "AngleRangeMax",

			// Enemy animation inputs
			"Carrying",
			"ReceivedHitCount", "ReceivedHitDirection",
			"AnimCursor", "OrientationCursor", "TargetCursor",
			"BlockingContact", "BoneAlpha", "EjectionState", "Fight", "FishingMode",
			"HasCage", "HasFruit", "Health", "HurtMode",
			"MoveAttack", "ParachuteMode", "Pedestal", "PerformCharge", "SplinterCell", "State",
			"StunBullet", "Stunned", "WallOrientation", "WindForce", "IsNaked", "InputLumsColor", "IsInAir",

			// Common BTAI node names
			"ReceiveHit", "ReceiveCrush", "Roaming", "RoamingUnderwater", "Idle", "SpotTarget", "Charge", "Stun", "TickleGeneric", "Drown",

			// RO2: Familiies
			"Rayman", "Globox", "Barbara", "Teensy",

			// Bones
			"Root",

			// Inputs
			"Axis", "Press", "Hold", "Trigger_Left", "Trigger_Right",
			"Button_A", "Button_X", "Button_Y", "Button_B", "Button_Back", "Button_Start",
		};


		protected void InitStringCache()
		{
			// Init String Cache
			foreach (uint sid in ObjectFactory.classes.Keys)
			{
				var name = ObjectFactory.classes[sid].Name;
				var stringID = new StringID(sid);
				if (stringID == new StringID(name)) { // Avoid adding "unknown" classes where the name doesn't yet match the StringID
					StringCache[new StringID(sid)] = ObjectFactory.classes[sid].Name;
				}
			}
			foreach (var str in AdditionalStrings)
			{
				var stringID = new StringID(str);
				if (!StringCache.ContainsKey(stringID)) {
					StringCache.Add(stringID, str);
				}
			}
		}

		public void AddToStringCache(object obj)
		{
			void AddString(string str) {
				if(str == null) return;
				var sid = new StringID(str);
				if (!StringCache.ContainsKey(sid)) StringCache[sid] = str;
			}

			if (obj != null)
			{
				Type type = obj.GetType();
				if (type == typeof(string))
				{
					string str = ((string)obj);
					AddString(str);
				}
				else if (type == typeof(CString))
				{
					string str = ((CString)obj).str;
					AddString(str);
				}
				else if (type == typeof(BasicString))
				{
					string str = ((BasicString)obj).str;
					AddString(str);
				}
				else if (type == typeof(Path))
				{
					Path p = ((Path)obj);
					if (!p.IsNull)
					{
						StringCache[p.stringID] = p.FullPath;
					}
				}
				else if (type == typeof(PathRef))
				{
					PathRef p = ((PathRef)obj);
					if (!p.IsNull)
					{
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

		public void Close()
		{
			foreach (var file in Files)
				file?.Dispose();

			SerializerLogger.Dispose();
		}
		public void Dispose()
		{
			Close();
			Disposed?.Invoke(this, EventArgs.Empty);
		}

		#endregion
	}
}