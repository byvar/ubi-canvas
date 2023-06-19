using System;

namespace UbiArt {
	// TODO: No such thing actually exists in UbiArt. It's done in ITF::CSerializerLoadInPlace::Init.
	public class GenericFile<T> : ICSerializable, IObjectContainer {
		[Serialize("read"       )] public bool read = true;
		[Serialize("sizeof"     )] public uint sizeOf = 0x100000;
		[Serialize("$ClassName$")] public StringID className;
		public T obj;

		public bool IsNull {
			get {
				return className != null ? className.IsNull : true;
			}
		}

		public GenericFile() {
			className = new StringID();
		}

		public GenericFile(T obj) {
			if (obj != null && obj is CSerializable ct && ct.ClassCRC.HasValue) {
				className = new StringID(ct.ClassCRC.Value);
				this.obj = obj;
			} else {
				className = new StringID();
			}
		}

		public void Serialize(CSerializerObject s, string name) {
			if (s.Settings.engineVersion > Settings.EngineVersion.RO) {
				read = s.Serialize<bool>(read, name: "read");
				if (s.HasProperty(CSerializerObject.SerializerProperty.StoreObjectSizes)
					&& !s.Embedded
					&& s.Settings.engineVersion > Settings.EngineVersion.RO
					&& !(s is CSerializerObjectTagBinary)) {
					sizeOf = s.Serialize<uint>(sizeOf, name: "sizeof");
				}
				Pointer pos = s.CurrentPointer;
				if (s.Settings.engineVersion <= Settings.EngineVersion.RO) {
					className = s.SerializeObject<StringID>(className, name: "NAME");
				} else {
					className = s.SerializeObject<StringID>(className, name: "$ClassName$");
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
								s.Context.SystemLogger?.LogError(s.CurrentPointer + " - Generic parameters error with type " + type + ". Expecting type " + typeof(T) + ".");
								throw new Exception(s.CurrentPointer + " - Generic parameters error with type " + type + ". Expecting type " + typeof(T) + ".");
							}
							type = type.MakeGenericType(typeof(T).GetGenericArguments());
						}
						obj = s.SerializeGeneric<T>(obj, type);
					} else {
						s.Context.SystemLogger?.LogError("CRC " + className.stringID.ToString("X8")
							+ " found at " + s.CurrentPointer
							+ " while reading container of type " + typeof(T) + " is not yet supported!");
						throw new NotImplementedException("CRC " + className.stringID.ToString("X8")
							+ " found at position " + s.CurrentPointer
							+ " while reading container of type " + typeof(T) + " is not yet supported!");
					}
				}
			} else {
				Type type = typeof(T);
				obj = s.SerializeGeneric<T>(obj, type);
			}
		}
	}
}
