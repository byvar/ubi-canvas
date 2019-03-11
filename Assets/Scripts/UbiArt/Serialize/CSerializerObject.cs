using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UbiArt {
	public abstract class CSerializerObject {
		public SerializeFlags flags;

		public CSerializerObject() {
		}

		public abstract void Serialize(ref object obj, Type type, string name = null);
		public abstract void Serialize(object o, FieldInfo f, Type type = null, string name = null, int? index = null);
		public abstract void Serialize(object o, FieldInfo f, SerializeAttribute a, Type type = null);
		public abstract void Serialize<T>(ref T obj, Type type = null, string name = null, int? index = null);
		public abstract Pointer Position {
			get;
		}

		public bool HasFlags(SerializeFlags flags) {
			return ((this.flags & flags) == flags);
		}
	}
}
