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
	public class CListO<T> : CList<T> where T : ICSerializable, new() {

		public override void Serialize(CSerializerObject s, string name) {
			//UnityEngine.Debug.Log("Serializing List: " + name);
			uint count = (uint)container.Count;
			count = s.Serialize<uint>(count, name: name);
			if(count != container.Count) Resize((int)count);
			string typeName = "VAL";
			if (count > 0 && s.GetTagCode(typeof(T)) == 200) {
				typeName = null;
			}
			for (int i = 0; i < count; i++) {
				T obj = container[i];
				if (s.ArrayEntryStart(name: name, index: i)) {
					obj = s.SerializeObject<T>(obj, name: typeName);
					s.ArrayEntryStop();
				}
				container[i] = obj;
			}
		}
	}
}
