using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt {
	public class Generic<T> : ICSerializable, IObjectContainer where T : CSerializable {
		[Serialize("$ClassName$")] public StringID className;
		public T obj;
		public bool serializeClassName = true;

		public Generic() {
			className = new StringID();
		}

		public Generic(T obj) {
			if (obj != null && obj.ClassCRC.HasValue) {
				className = new StringID(obj.ClassCRC.Value);
				this.obj = obj;
			} else {
				className = new StringID();
			}
		}

		public bool IsNull {
			get {
				return className == null || className.IsNull;
			}
		}

		public void SerializeClassName(CSerializerObject s) {
			if (s.Settings.engineVersion <= Settings.EngineVersion.RO) {
				className = s.SerializeObject<StringID>(className, name: "NAME");
			} else {
				className = s.SerializeObject<StringID>(className, name: "$ClassName$");
			}
		}

		public void Serialize(CSerializerObject s, string name) {
			Pointer pos = s.Position;
			if (serializeClassName) {
				SerializeClassName(s);
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
					obj = s.SerializeGeneric<T>(obj, type);
				} else {
					if (s is CSerializerObjectTagBinary) {
						Debug.LogWarning("CRC " + className.stringID.ToString("X8")
							+ " found at " + s.Position
							+ " while reading container of type " + typeof(T) + " is not yet supported!");
						className.stringID = 0xFFFFFFFF;
					} else {
						Debug.LogError("CRC " + className.stringID.ToString("X8")
							+ " found at " + s.Position
							+ " while reading container of type " + typeof(T) + " is not yet supported!");
						throw new NotImplementedException("CRC " + className.stringID.ToString("X8")
							+ " found at position " + s.Position
							+ " while reading container of type " + typeof(T) + " is not yet supported!");
					}
				}
			}
		}
	}
}
