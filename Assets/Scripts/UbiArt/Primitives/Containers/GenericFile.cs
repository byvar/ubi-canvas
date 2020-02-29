using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt {
	public class GenericFile<T> : ICSerializable, IObjectContainer {
		[Serialize("read"       )] public bool read = true;
		[Serialize("sizeof"     )] public uint sizeOf;
		[Serialize("$ClassName$")] public StringID className;
		public T obj;

		public bool IsNull {
			get {
				return className != null ? className.IsNull : true;
			}
		}

		public void Serialize(CSerializerObject s, string name) {
			if (Settings.s.engineVersion > Settings.EngineVersion.RO) {
				s.Serialize(ref read, name: "read");
				if (s.HasSerializerFlags(CSerializerObject.Flags.StoreObjectSizes)
					&& !s.Embedded
					&& Settings.s.engineVersion > Settings.EngineVersion.RO
					&& !(s is CSerializerObjectTagBinary)) {
					s.Serialize(ref sizeOf, name: "sizeof");
				}
				Pointer pos = s.Position;
				if (Settings.s.engineVersion <= Settings.EngineVersion.RO) {
					s.Serialize(ref className, name: "NAME");
				} else {
					s.Serialize(ref className, name: "$ClassName$");
				}
				/*s.Serialize(this, GetType().GetField(nameof(className)),
					(SerializeAttribute)GetType().GetField(nameof(className)).GetCustomAttributes(typeof(SerializeAttribute), false).First());*/
				if (className.IsNull) {
					obj = default;
				} else {
					if (ObjectFactory.classes.ContainsKey(className.stringID)) {
						/*if (s.log) {
							MapLoader.Loader.Log(pos + ":" + new string(' ', (s.Indent + 1) * 2) + "$ClassName$ - " + className.stringID.ToString("X8") + "(" + ObjectFactory.classes[className.stringID] + ")");
						}*/
						Type type = ObjectFactory.classes[className.stringID];
						if (type.ContainsGenericParameters) {
							if (!typeof(T).IsGenericType) {
								Debug.LogError(s.Position + " - Generic parameters error with type " + type + ". Expecting type " + typeof(T) + ".");
								throw new Exception(s.Position + " - Generic parameters error with type " + type + ". Expecting type " + typeof(T) + ".");
							}
							type = type.MakeGenericType(typeof(T).GetGenericArguments());
						}
						s.Serialize(ref obj, type);
					} else {
						Debug.LogError("CRC " + className.stringID.ToString("X8")
							+ " found at " + s.Position
							+ " while reading container of type " + typeof(T) + " is not yet supported!");
						throw new NotImplementedException("CRC " + className.stringID.ToString("X8")
							+ " found at position " + s.Position
							+ " while reading container of type " + typeof(T) + " is not yet supported!");
					}
				}
			} else {
				Type type = typeof(T);
				s.Serialize(ref obj, type);
			}
			if (s.Length != null) {
				if (s.Position != s.Length) {
					throw new Exception("File reading check failed. Position:" + s.Position + " - Length:" + s.Length);
				} else if (s.Position.file != null) {
					MapLoader.Loader.print("Finished reading file: " + s.Position.file.name);
				}
			}
		}
	}
}
