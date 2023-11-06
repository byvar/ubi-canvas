using System;
using UbiArt.Animation;
using UbiArt.Engine3D;
using UbiArt.ITF;

namespace UbiArt {
	public class Path : ICSerializable, IEquatable<Path> {
		public string folder;
		public string filename;
		public StringID stringID;
		public uint flags;
		public bool specialUncooked;

		public ICSerializable Object { get; set; }

		public Path() {
			stringID = new StringID();
		}

		public Path(Path p) {
			folder = p.folder;
			filename = p.filename;
			stringID = new StringID(p.stringID?.stringID ?? 0xFFFFFFFF);
			flags = p.flags;
			specialUncooked = p.specialUncooked;
		}

		public Path(string folder, string filename, bool cooked=false) {
			folder = folder.Replace('\\', '/');
			if (folder != null && folder != "" && !folder.EndsWith("/")) folder += "/";
			if (folder != null && folder.StartsWith("/")) folder = folder.Substring(1);
			if (!cooked && filename != null && filename != "" && filename.EndsWith(".ckd")) filename = filename.Substring(0, filename.Length - 4);
			this.folder = folder;
			this.filename = filename;
			if ((folder != null && folder != "") || (filename != null && filename != "")) {
				stringID = new StringID(FullPath);
			} else {
				stringID = new StringID();
			}
		}
		public Path(string fullPath, bool cooked = false) {
			if (fullPath == null) {
				stringID = new StringID();
				return;
			}
			fullPath = fullPath.Replace('\\', '/');
			if (fullPath.Contains('/')) {
				folder = fullPath.Substring(0, fullPath.LastIndexOf('/') + 1);
				filename = fullPath.Substring(fullPath.LastIndexOf('/') + 1);
			} else {
				folder = "";
				filename = fullPath;
			}
			if (folder != null && folder != "" && !folder.EndsWith("/")) folder += "/";
			if (folder != null && folder.StartsWith("/")) folder = folder.Substring(1);
			if (!cooked && filename != null && filename != "" && filename.EndsWith(".ckd")) filename = filename.Substring(0, filename.Length - 4);
			if ((folder != null && folder != "") || (filename != null && filename != "")) {
				stringID = new StringID(FullPath);
			} else {
				stringID = new StringID();
			}
		}

		public string FullPath {
			get {
				return $"{(folder ?? "")}{(filename ?? "")}";
			}
			set {
				string fullPath = value.Replace('\\', '/');
				if (fullPath.Contains('/')) {
					folder = fullPath.Substring(0, fullPath.LastIndexOf('/') + 1);
					filename = fullPath.Substring(fullPath.LastIndexOf('/') + 1);
				} else {
					folder = "";
					filename = fullPath;
				}
				if (folder != null && folder != "" && !folder.EndsWith("/")) folder += "/";
				if (folder != null && folder.StartsWith("/")) folder = folder.Substring(1);

				if((folder != null && folder != "") || (filename != null && filename != "")) {
					stringID = new StringID(FullPath);
				} else {
					stringID = new StringID();
				}
			}
		}

		public bool IsNull {
			get {
				return ((folder == null || folder == "") && (filename == null || filename == "") && stringID.IsNull);
			}
		}

		public bool IsCooked(Context context) {
			return (folder != null && folder.StartsWith(context.Settings.ITFDirectory)) 
				|| (filename != null && filename.EndsWith(".ckd"));
		}

		public Path CookedPath(Context context) {
			if (!IsNull && !IsCooked(context)) {
				return new Path(folder != null ? context.Settings.ITFDirectory + folder : null,
					filename != null ? filename + ".ckd" : null, cooked: true);
			}
			return this;
		}

		public string GetExtension(bool removeCooked = false) {
			if (filename != null && filename.Contains('.')) {
				string filenameCopy = filename;
				if (removeCooked && filenameCopy.EndsWith(".ckd"))
					filenameCopy = filenameCopy.Substring(0, filenameCopy.Length - 4);
				if (filenameCopy.Contains('.')) {
					string ext = filenameCopy.Substring(filenameCopy.LastIndexOf('.') + 1);
					return ext;
				}
			}
			return "";
		}
		public string GetFilenameWithoutExtension(bool fullPath = false, bool removeCooked = false) {
			var basename = fullPath ? FullPath : filename; 
			if (basename != null) {
				if (basename.Contains('.')) {
					if (removeCooked && basename.EndsWith(".ckd"))
						basename = basename.Substring(0, basename.Length - 4);
					if (basename.Contains('.')) {
						basename = basename.Substring(0, basename.LastIndexOf('.'));
					}
				}
				return basename;
			}
			return "";
		}

		public void Serialize(CSerializerObject s, string name) {
			if (s.Context.HasSettings<ConversionSettings>()) {
				ConvertPath(s.Context.GetSettings<ConversionSettings>());
			}
			// null path: 0, 0, -1, 0
			folder = s.Serialize<string>(folder);
			filename = s.Serialize<string>(filename);
			stringID = s.SerializeObject<StringID>(stringID);
			if (s.Settings.EngineVersion > EngineVersion.RO) {
				flags = s.Serialize<uint>(flags);
				//if (flags != 0) MapLoader.Loader.print("Path with nonzero flags: " + this + " - " + flags);
			}
			if (s.Context.Loader.LoadAllPaths) LoadObject(s.Context);
		}

		public T GetObject<T>() where T : ICSerializable {
			return (T)Object;
		}

		public void LoadObject(Context c, bool removeCooked = false) {
			if (!IsNull) {
				switch (GetExtension(removeCooked: removeCooked)) {
					case "anm":
						c.Loader.LoadFile<AnimTrack>(this, o => Object = o);
						break;
					case "skl":
						c.Loader.LoadFile<AnimSkeleton>(this, o => Object = o);
						break;
					case "pbk":
						c.Loader.LoadFile<AnimPatchBank>(this, o => Object = o);
						break;
					case "fcg":
						c.Loader.LoadFile<GenericFile<FriseConfig>>(this, o => Object = o);
						break;
					case "isc":
					case "tsc":
						c.Loader.LoadFile<ContainerFile<ITF.Scene>>(this, o => Object = o);
						break;
					case "act":
						if (c.Settings.EngineVersion == EngineVersion.RO) {
							c.Loader.LoadFile<GenericFile<Actor_Template>>(this, o => Object = o);
						} else {
							c.Loader.LoadFile<ContainerFile<ITF.Actor>>(this, o => Object = o);
						}
						break;
					case "tga":
					case "dds":
					case "png":
						c.Loader.LoadTexture(this, o => Object = o);
						break;
					case "gmt":
						c.Loader.LoadFile<GenericFile<GameMaterial_Template>>(this, o => Object = o);
						break;
					case "msh":
						c.Loader.LoadFile<GenericFile<GFXMaterialShader_Template>>(this, o => Object = o);
						break;
					case "tpl":
						c.Loader.LoadFile<GenericFile<Actor_Template>>(this, o => Object = o);
						break;
					case "asc":
						c.Loader.LoadFile<AnimMeshVertex>(this, o => Object = o);
						break;
					case "m3d":
						c.Loader.LoadFile<Mesh3D>(this, o => Object = o);
						break;
					case "wav":
					case "tfn":
						// TODO
						break;
					case "ilu":
						// Uncompiled files! Not included in the game though.
						// These are referenced in "iluFile" in PlaySpawn_evtTemplate
						break;
					case "isg":
						c.Loader.LoadGenericFile(this, o => Object = o);
						break;
					case "":
						break;
					default:
						c.SystemLogger?.LogInfo($"Encountered path with extension {GetExtension()}");
						break;
				}
			}
		}

		public void ConvertPath(ConversionSettings conversion) {
			if(conversion == null) return;
			conversion.ConvertPath(this);
		}

		public override string ToString() {
			if (stringID.IsNull) return "Path(null)";
			return $"Path(\"{folder}\", \"{filename}\", {stringID.stringID:X8})";
		}

		/* Flags:
		 * 0x8: Contains spaces?
		 * 0x10: Unicode
		 * 0x80: Absolute path (rather than relative to the bundle)
		 */
		
		public override bool Equals(object obj) {
			return obj is Path && this == (Path)obj;
		}
		public override int GetHashCode() {
			return stringID.GetHashCode();
		}

		public bool Equals(Path other) {
			return this == (Path)other;
		}

		public static bool operator ==(Path x, Path y) {
			if (ReferenceEquals(x, y)) return true;
			if (ReferenceEquals(x, null)) return false;
			if (ReferenceEquals(y, null)) return false;
			return x.stringID == y.stringID;
		}
		public static bool operator !=(Path x, Path y) {
			return !(x == y);
		}
		public static implicit operator Path(PathRef p) {
			return new Path {
				filename = p.filename,
				folder = p.folder,
				flags = p.flags,
				stringID = p.stringID
			};
		}
	}
}
