using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt {
	public class CSerializerObjectBinaryWriter : CSerializerObject {
		public Writer writer;
		
		public CSerializerObjectBinaryWriter(Writer writer) {
			this.writer = writer;
			flagsOwn = Flags.Flags0 | Flags.Flags4; // 0x11
		}

		public override Pointer Position => Pointer.Current(writer);
		public override Pointer Length => new Pointer((uint)writer.BaseStream.Length, Pointer.Current(writer).file);

		public override void ResetPosition() {
			writer.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
		}

		public override void Serialize(ref object obj, Type type, string name = null) {
			if (Type.GetTypeCode(type) != TypeCode.Object) {
				switch (Type.GetTypeCode(type)) {
					case TypeCode.Boolean: writer.Write((bool)obj); break;
					case TypeCode.Byte: writer.Write((byte)obj); break;
					case TypeCode.Char: writer.Write((char)obj); break;
					case TypeCode.String: writer.Write((string)obj); break;
					case TypeCode.Single: writer.Write((float)obj); break;
					case TypeCode.Double: writer.Write((double)obj); break;
					case TypeCode.UInt16: writer.Write((ushort)obj); break;
					case TypeCode.UInt32: writer.Write((uint)obj); break;
					case TypeCode.UInt64: writer.Write((ulong)obj); break;
					case TypeCode.Int16: writer.Write((short)obj); break;
					case TypeCode.Int32: writer.Write((int)obj); break;
					case TypeCode.Int64: writer.Write((long)obj); break;
					default: throw new Exception("Unsupported TypeCode " + Type.GetTypeCode(type));
				}
			} else if (type == typeof(CString)) {
				writer.Write16(obj != null ? ((CString)obj).str : null);
			} else if (type == typeof(byte[])) {
				writer.Write(((byte[])obj).Length);
				writer.Write((byte[])obj);
			} else {
				if (obj == null) {
					var ctor = type.GetConstructor(Type.EmptyTypes);
					if (ctor != null) {
						obj = ctor.Invoke(new object[] { });
					}
				}
				if(obj != null && obj is ICSerializable) {
					IncreaseLevel();
					((ICSerializable)obj).Serialize(this, name);
					DecreaseLevel();
				}
			}
		}

		public override void Serialize(object containerObj, FieldInfo f, Type type = null, string name = null, int? index = null) {
			Pointer pos = log ? Position : null;
			bool isBigObject = log && (typeof(CSerializable).IsAssignableFrom(f.FieldType) || typeof(IObjectContainer).IsAssignableFrom(f.FieldType));
			object obj = f.GetValue(containerObj);
			if (type != null) ConvertTypeBefore(ref obj, name, type, f.FieldType);
			if (log && isBigObject) {
				MapLoader.Loader.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + "(" + f.DeclaringType + ") " + f.Name + ":");
			} else if (log && !isBigObject) {
				MapLoader.Loader.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + "(" + f.DeclaringType + ") " + f.Name + " - " + obj);
			}
			//MapLoader.Loader.print(name);
			Serialize(ref obj, type ?? f.FieldType, name: name);
		}

		public override void Serialize(object o, FieldInfo f, SerializeAttribute a, Type type = null) {
			if (((a.version & Settings.s.versionFlags) == Settings.s.versionFlags) && (a.flags == SerializeFlags.None || (flags & a.flags) != SerializeFlags.None)) {
				Serialize(o, f, type: type, name: a.Name);
			}
		}

		public override void Serialize<T>(ref T obj, Type type = null, string name = null, int? index = null) {
			Pointer pos = log && index.HasValue ? Position : null;
			bool isBigObject = log && index.HasValue && (typeof(CSerializable).IsAssignableFrom(typeof(T)) || typeof(IObjectContainer).IsAssignableFrom(typeof(T)));
			if (log && index.HasValue && isBigObject) {
				MapLoader.Loader.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + name + "[" + index.Value + "]:");
			} else if (log && index.HasValue && !isBigObject) {
				MapLoader.Loader.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + name + "[" + index.Value + "] - " + obj);
			}
			object obj2 = obj;
			Serialize(ref obj2, type ?? typeof(T), name: name);
		}

		public override void SerializeBytes(ref byte[] obj, int numBytes) {
			writer.Write(obj);
		}

		public override void SerializeFileSize(ref uint obj) {
			//throw new NotImplementedException();
		}

		public override void SerializePureBinary<T>(ref T obj, Type type = null, string name = null, int? index = null) {
			Serialize<T>(ref obj, type: type, name: name, index: index);
		}
	}
}
