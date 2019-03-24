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
		public abstract void SerializeBytes(ref byte[] obj, int numBytes);
		public abstract Pointer Position {
			get;
		}
		public abstract Pointer Length {
			get;
		}
		public abstract void ResetPosition();

		public bool HasFlags(SerializeFlags flags) {
			switch (flags) {
				case SerializeFlags.Flags8:
					if((this.flags & SerializeFlags.Flags_x30) == SerializeFlags.None) {
						return ((this.flags & SerializeFlags.Flags6) != SerializeFlags.None);
					}
					return false;
				case SerializeFlags.Flags9:
					return (((this.flags & (SerializeFlags.Flags4 | SerializeFlags.Flags7)) == SerializeFlags.None) &&
						((this.flags & SerializeFlags.Default) != SerializeFlags.None));
				case SerializeFlags.Flags10:
					return (((this.flags & SerializeFlags.Flags1) != SerializeFlags.None) &&
						((this.flags & SerializeFlags.Flags_xC0) != SerializeFlags.None));
				default:
					return ((this.flags & flags) != SerializeFlags.None);
			}
		}
	}
}
