using System;
using UbiArt.Animation;
using UbiArt.ITF;

namespace UbiArt {
	public class Path : ICSerializable, IEquatable<Path> {
		public string folder;
		public string filename;
		public StringID stringID;
		public uint flags;
		public bool specialUncooked;

		public Path() {
			stringID = new StringID();
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

		public string FullPath => $"{(folder ?? "")}{(filename ?? "")}";

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
				string ext = filename.Substring(filename.IndexOf('.') + 1);
				if (removeCooked && ext.EndsWith(".ckd")) ext = ext.Substring(0, ext.Length - 4);
				return ext;
			}
			return "";
		}

		public void Serialize(CSerializerObject s, string name) {
			// null path: 0, 0, -1, 0
			folder = s.Serialize<string>(folder);
			filename = s.Serialize<string>(filename);
			stringID = s.SerializeObject<StringID>(stringID);
			if (s.Settings.engineVersion > Settings.EngineVersion.RO) {
				flags = s.Serialize<uint>(flags);
				//if (flags != 0) MapLoader.Loader.print("Path with nonzero flags: " + this + " - " + flags);
			}
			if (s.Settings.LoadAll) LoadObject(s.Context);
		}

		public void LoadObject(Context c) {
			if (!IsNull) {
				switch (GetExtension()) {
					case "anm":
						c.Loader.LoadFile<AnimTrack>(this, null);
						break;
					case "skl":
						c.Loader.LoadFile<AnimSkeleton>(this, null);
						break;
					case "pbk":
						c.Loader.LoadFile<AnimPatchBank>(this, null);
						break;
					case "fcg":
						c.Loader.LoadFile<GenericFile<FriseConfig>>(this, null);
						break;
					case "isc":
						c.Loader.LoadFile<ContainerFile<ITF.Scene>>(this, null);
						break;
					case "act":
						c.Loader.LoadFile<ContainerFile<ITF.Actor>>(this, null);
						break;
					case "tga":
					case "dds":
					case "png":
						c.Loader.LoadTexture(this, null);
						break;
					case "gmt":
						c.Loader.LoadFile<GenericFile<GameMaterial_Template>>(this, null);
						break;
					case "msh":
						c.Loader.LoadFile<GenericFile<GFXMaterialShader_Template>>(this, null);
						break;
					case "tpl":
						c.Loader.LoadFile<GenericFile<Actor_Template>>(this, null);
						break;
					case "tsc":
					case "asc":
						c.Loader.LoadGenericFile(this, null);
						break;
					case "":
						break;
					default:
						c.SystemLogger?.LogInfo($"Encountered path with extension {GetExtension()}");
						break;
				}
			}
		}

		public override string ToString() {
			if (stringID.IsNull) return "Path(null)";
			return $"Path(\"{folder}\", \"{filename}\")";
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
