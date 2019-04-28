using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

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
		public virtual bool ArrayEntryStart(string name, int index) {
			IncreaseLevel();
			return true;
		}
		public virtual void ArrayEntryStop() {
			DecreaseLevel();
		}
		public uint GetTagCode(Type type) {
			if (Type.GetTypeCode(type) != TypeCode.Object) {
				switch (Type.GetTypeCode(type)) {
					case TypeCode.Boolean: return (uint)UAFTag.Bool;
					case TypeCode.Byte: return (uint)UAFTag.UChar;
					case TypeCode.Char: return (uint)UAFTag.Char;
					case TypeCode.String: return (uint)UAFTag.String8;
					case TypeCode.Single: return (uint)UAFTag.Float;
					case TypeCode.Double: return (uint)UAFTag.Double;
					case TypeCode.UInt16: return (uint)UAFTag.UShort;
					case TypeCode.UInt32: return (uint)UAFTag.UInt;
					case TypeCode.UInt64: return (uint)UAFTag.Long;
					case TypeCode.Int16: return (uint)UAFTag.Short;
					case TypeCode.Int32: return (uint)UAFTag.Int;
					case TypeCode.Int64: return (uint)UAFTag.UInt;
					default: throw new Exception("Unsupported TypeCode " + Type.GetTypeCode(type));
				}
			} else if (typeMapping.ContainsKey(type)) {
				return (uint)typeMapping[type];
			} else {
				return 200;
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

		public enum UAFTag {
			Char = 0,
			UChar,
			Short,
			Int,
			UShort,
			UInt,
			Long,
			Float,
			Double,
			Bool,
			Vec2d,
			Vec3d,
			Matrix44,
			Unk13,
			Unk14,
			Color,
			ColorInteger,
			Angle,
			Volume,
			Path,
			StringID,
			String8,
			LocalisationID
		}
		public struct UAFInfo {
			public uint type;
			public string name;
		}

		protected Dictionary<Type, UAFTag> typeMapping = new Dictionary<Type, UAFTag> {
			{ typeof(char),           UAFTag.Char           },
			{ typeof(byte),           UAFTag.UChar          },
			{ typeof(short),          UAFTag.Short          },
			{ typeof(int),            UAFTag.Int            },
			{ typeof(ushort),         UAFTag.UShort         },
			{ typeof(uint),           UAFTag.UInt           },
			{ typeof(long),           UAFTag.Long           },
			{ typeof(ulong),          UAFTag.Long           },
			{ typeof(float),          UAFTag.Float          },
			{ typeof(double),         UAFTag.Double         },
			{ typeof(bool),           UAFTag.Bool           },
			{ typeof(Vector2),        UAFTag.Vec2d          },
			{ typeof(Vector3),        UAFTag.Vec3d          },
			{ typeof(Matrix44),       UAFTag.Matrix44       },
			{ typeof(Color),          UAFTag.Color          },
			{ typeof(ColorInteger),   UAFTag.ColorInteger   },
			{ typeof(Angle),          UAFTag.Angle          },
			{ typeof(Volume),         UAFTag.Volume         },
			{ typeof(Path),           UAFTag.Path           },
			{ typeof(StringID),       UAFTag.StringID       },
			{ typeof(string),         UAFTag.String8        },
			{ typeof(LocalisationId), UAFTag.LocalisationID },
		};
	}
}
