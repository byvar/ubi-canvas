using System;

namespace UbiArt {
	// For serializing primitives
	[SerializeEmbed]
	public class CArrayP<T> : CArray<T> {
		public override void Serialize(CSerializerObject s, string name) {
			uint count = (uint)Count;
			count = s.Serialize<uint>(count, name: name);
			if (count != (uint)Count) {
				Array.Resize(ref container, (int)count);
			}
			string typeName = "VAL";
			if (count > 0 && !s.IsValueType(typeof(T))) {
				typeName = null;
			}
			//s.EnterEmbed();
			for (int i = 0; i < count; i++) {
				T obj = container[i];
				if (s.ArrayEntryStart(name: name, index: i)) {
					obj = s.Serialize<T>(obj, name: typeName);
					s.ArrayEntryStop();
				}
				container[i] = obj;
			}
			//s.ExitEmbed();
		}
		public CArrayP() { }
		public CArrayP(T[] array) : base(array) { }
	}
}
