using System.Collections.Generic;

namespace UbiArt {
	// For serializing primitives
	[SerializeEmbed]
	public class CListP<T> : CList<T> {
		public CListP() { }
		public CListP(List<T> list) : base(list) { }

		public override void Serialize(CSerializerObject s, string name) {
			uint count = (uint)container.Count;
			count = s.Serialize<uint>(count, name: name);
			if(count != container.Count) Resize((int)count);
			string typeName = "VAL";
			if (count > 0 && !s.IsValueType(typeof(T))) {
				typeName = null;
			}
			for (int i = 0; i < count; i++) {
				T obj = container[i];
				if (s.ArrayEntryStart(name: name, index: i)) {
					obj = s.Serialize<T>(obj, name: typeName);
					s.ArrayEntryStop();
				}
				container[i] = obj;
			}
		}
	}
}
