using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UbiArt {
	public abstract class CSerializerObject {
		public SerializeFlags flags;
		public Flags flagsOwn;
		protected int indent;
		public int Indent => indent;
		public bool log = false;
		protected Stack<int> embeddedLevels = new Stack<int>();
		protected bool embedded = false;
		public bool Embedded => embeddedLevels.Count > 0 && embeddedLevels.Peek() == indent;

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
		public void EnterEmbed() {
			embedded = true;
		}
		public void ExitEmbed() {
			embedded = false;
		}
		protected void IncreaseLevel() {
			if (!embedded) {
				indent++;
			} else {
				embeddedLevels.Push(indent);
				embedded = false;
			}
		}
		protected void DecreaseLevel() {
			if (!embedded) {
				if (embeddedLevels.Count > 0 && embeddedLevels.Peek() == indent) {
					embeddedLevels.Pop();
					embedded = true;
				} else {
					indent--;
				}
			}
		}

		public bool HasFlags(SerializeFlags flags) {
			switch (flags) {
				case SerializeFlags.Flags8:
					if ((this.flagsOwn & (Flags.Flags4 | Flags.Flags5)) == Flags.None) {
						return ((this.flags & SerializeFlags.Flags6) != SerializeFlags.None);
					}
					return false;
				case SerializeFlags.Flags9:
					if ((this.flagsOwn & (Flags.Flags4 | Flags.Flags7)) == Flags.None) {
						return ((this.flags & SerializeFlags.Default) != SerializeFlags.None);
					}
					return false;
				case SerializeFlags.Flags10:
					return (((this.flagsOwn & Flags.Flags0) != Flags.None) &&
						((this.flags & SerializeFlags.Flags_xC0) != SerializeFlags.None));
				default:
					return ((this.flags & flags) != SerializeFlags.None);
			}
		}
		public bool HasSerializerFlags(Flags flags) {
			return ((this.flagsOwn & flags) != Flags.None);
		}

		[Flags]
		public enum Flags {
			None = 0,
			Flags0 = 1,
			Flags1 = 1 << 1,
			Flags2 = 1 << 2,
			StoreObjectSizes = 1 << 3,
			Flags4 = 1 << 4,
			Flags5 = 1 << 5,
			Flags6 = 1 << 6,
			Flags7 = 1 << 7,
			Flags8 = 1 << 8,
			Flags9 = 1 << 9,
			Flags10 = 1 << 10,
			Flags11 = 1 << 11,
			Flags12 = 1 << 12,
			Flags13 = 1 << 13,
			Flags14 = 1 << 14,
			Flags15 = 1 << 15,
			Flags16 = 1 << 16,
			Flags17 = 1 << 17,
			Flags18 = 1 << 18,
			Flags19 = 1 << 19,
			Flags20 = 1 << 20,
			Flags21 = 1 << 21,
			Flags22 = 1 << 22,
			Flags23 = 1 << 23,
			Flags24 = 1 << 24,
			Flags25 = 1 << 25,
			Flags26 = 1 << 26,
			Flags27 = 1 << 27,
			Flags28 = 1 << 28,
			Flags29 = 1 << 29,
			Flags30 = 1 << 30,
			Flags31 = 1 << 31,
		}
	}
}
