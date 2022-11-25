﻿using System;
using UbiArt.ITF;

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
			Reinit(s.Context, s.Settings);
			Pointer pos = s.CurrentPointer;
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
							s.Context.SystemLogger?.LogError(s.CurrentPointer + " - Generic parameters error with type " + type + ". Expecting type " + typeof(T) + ".");
							throw new Exception(s.CurrentPointer + " - Generic parameters error with type " + type + ". Expecting type " + typeof(T) + ".");
						}
						type = type.MakeGenericType(typeof(T).GetGenericArguments());
					}
					obj = s.SerializeGeneric<T>(obj, type);
				} else {
					if (s is CSerializerObjectTagBinary) {
						s.Context.SystemLogger?.LogWarning("CRC " + className.stringID.ToString("X8")
							+ " found at " + s.CurrentPointer
							+ " while reading container of type " + typeof(T) + " is not yet supported!");
						className.stringID = 0xFFFFFFFF;
					} else {
						s.Context.SystemLogger?.LogError("CRC " + className.stringID.ToString("X8")
							+ " found at " + s.CurrentPointer
							+ " while reading container of type " + typeof(T) + " is not yet supported!");
						throw new NotImplementedException("CRC " + className.stringID.ToString("X8")
							+ " found at position " + s.CurrentPointer
							+ " while reading container of type " + typeof(T) + " is not yet supported!");
					}
				}
			}
		}


		Settings previousSettings = null;
		protected virtual void Reinit(Context c, Settings settings) {
			if (previousSettings != null) {
				if (previousSettings.game != settings.game) {
					if (obj != null) {
						if (obj is ITF.Event e) {
							if (e.IsAdventuresExclusive()) MakeNull();
						}
					}
				}
			}
			previousSettings = settings;
		}

		public void MakeNull() {
			className = null;
			obj = null;
		}
	}
}
