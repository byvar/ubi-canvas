using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt {
	public class Generic<T> : CSerializable, IObjectContainer {
		[Serialize("$ClassName$")] public StringID className;
		public T obj;

		public bool IsNull {
			get {
				return className != null ? className.IsNull : true;
			}
		}

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
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
					if (s.log) {
						MapLoader.Loader.Log(pos + ":" + new string(' ', (s.Indent + 1) * 2) + "$ClassName$ - " + className.stringID.ToString("X8") + "(" + ObjectFactory.classes[className.stringID] + ")");
					}
					s.Serialize(ref obj, ObjectFactory.classes[className.stringID], name: ObjectFactory.classes[className.stringID].Name);
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
