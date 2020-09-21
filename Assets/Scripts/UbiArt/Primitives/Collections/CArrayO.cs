using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt {
	// For serializing ICSerializable objects
	[SerializeEmbed]
	public class CArrayO<T> : CArray<T> where T : ICSerializable, new() {
		public override void Serialize(CSerializerObject s, string name) {
			uint count = (uint)Count;
			count = s.Serialize<uint>(count, name: name);
			if (count != (uint)Count) {
				Array.Resize(ref container, (int)count);
			}
			string typeName = "VAL";
			if (count > 0 && s.GetTagCode(typeof(T)) == 200) {
				typeName = null;
			}
			//s.EnterEmbed();
			for (int i = 0; i < count; i++) {
				T obj = container[i];
				if (s.ArrayEntryStart(name: name, index: i)) {
					obj = s.SerializeObject<T>(obj, name: typeName);
					s.ArrayEntryStop();
				}
				container[i] = obj;
			}
			//s.ExitEmbed();
		}
	}
}
