using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt {
	public class Generic<T> : ICSerializable {
		[Serialize("$ClassName$")] public StringID className;
		public T obj;

		public void Serialize(CSerializerObject s, string name) {
			s.Serialize(this, GetType().GetField(nameof(className)),
				(SerializeAttribute)GetType().GetField(nameof(className)).GetCustomAttributes(typeof(SerializeAttribute), false).First());
			if (className.IsNull) {
				obj = default;
			} else {
				if (ClassCRC.classes.ContainsKey(className.stringID)) {
					MapLoader.Loader.print(className.stringID.ToString("X8") + " - " + ClassCRC.classes[className.stringID]);
					s.Serialize(ref obj, ClassCRC.classes[className.stringID], name: ClassCRC.classes[className.stringID].Name);
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
