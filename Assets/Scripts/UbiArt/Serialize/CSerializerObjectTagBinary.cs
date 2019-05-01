using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UbiArt.CRC;
using UnityEngine;

namespace UbiArt {
	public class CSerializerObjectTagBinary : CSerializerObject {
		public Reader reader;
		public static Dictionary<UAFInfo, uint> fieldCRC = new Dictionary<UAFInfo, uint>();
		protected Stack<long> endPos = new Stack<long>();


		public CSerializerObjectTagBinary(Reader reader) {
			this.reader = reader;
			flagsOwn = Flags.Flags0 | Flags.Flags4; // 0x11
		}

		public override Pointer Position => Pointer.Current(reader);
		public override Pointer Length => new Pointer((uint)reader.BaseStream.Length, Pointer.Current(reader).file);

		public override void ResetPosition() {
			reader.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
		}

		public override void Serialize(ref object obj, Type type, string name = null) {
			if (Type.GetTypeCode(type) != TypeCode.Object) {
				switch (Type.GetTypeCode(type)) {
					case TypeCode.Boolean:
						uint tmp = reader.ReadUInt32();
						if (tmp == 1) {
							obj = true;
						} else if (tmp != 0) {
							throw new Exception(Position + ": Bool with name " + name + " was " + tmp + "!");
							//obj = false;
						} else {
							obj = false;
						}
						//obj = (object)reader.ReadBoolean();
						break;
					case TypeCode.Byte: obj = (object)reader.ReadByte(); break;
					case TypeCode.Char: obj = (object)reader.ReadChar(); break;
					case TypeCode.String: obj = (object)reader.ReadString(); break;
					case TypeCode.Single: obj = (object)reader.ReadSingle(); break;
					case TypeCode.Double: obj = (object)reader.ReadDouble(); break;
					case TypeCode.UInt16: obj = (object)reader.ReadUInt16(); break;
					case TypeCode.UInt32: obj = (object)reader.ReadUInt32(); break;
					case TypeCode.UInt64: obj = (object)reader.ReadUInt64(); break;
					case TypeCode.Int16: obj = (object)reader.ReadInt16(); break;
					case TypeCode.Int32: obj = (object)reader.ReadInt32(); break;
					case TypeCode.Int64: obj = (object)reader.ReadInt64(); break;
					default: throw new Exception("Unsupported TypeCode " + Type.GetTypeCode(type));
				}
			} else if (type == typeof(Vector2)) {
				obj = reader.ReadVector2();
			} else if (type == typeof(Vector3)) {
				obj = reader.ReadVector3();
			} else if (type == typeof(Vector4)) {
				obj = reader.ReadVector4();
			} else if (type == typeof(Color)) {
				obj = reader.ReadColor();
			} else if (type == typeof(byte[])) {
				int numBytes = reader.ReadInt32();
				obj = reader.ReadBytes(numBytes);
			} else {
				var ctor = type.GetConstructor(Type.EmptyTypes);
				if (ctor == null) {
					throw new Exception("Constructor is null");
				}
				obj = ctor.Invoke(new object[] { });
				if (obj is ICSerializable) {
					IncreaseLevel();
					bool entered = GetTagCode(type) == 200 && !type.IsDefined(typeof(SerializeEmbedAttribute), false) && ReadTag(type.Name, 200);
					((ICSerializable)obj).Serialize(this, name);
					if(entered) reader.BaseStream.Position = endPos.Pop();
					DecreaseLevel();
				}
			}
		}

		public override void Serialize(object containerObj, FieldInfo f, Type type = null, string name = null, int? index = null) {
			long position = reader.BaseStream.Position;
			Type objType = type ?? f.FieldType;
			if (endPos.Count > 0 && position >= endPos.Peek()) {
			} else if (name != null && !objType.IsDefined(typeof(SerializeEmbedAttribute), false)) {
				uint uafType = index.HasValue ? 200 + (uint)index.Value : GetTagCode(objType);
				if (ReadTag(name, uafType)) {
					Pointer pos = log ? new Pointer((uint)position, MapLoader.Loader.GetFileByReader(reader)) : null;
					bool isBigObject = log && (typeof(CSerializable).IsAssignableFrom(f.FieldType) || typeof(IObjectContainer).IsAssignableFrom(f.FieldType));
					if (log && isBigObject) {
						MapLoader.Loader.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + "(" + f.DeclaringType + ") " + f.Name + ":");
					}
					object obj = null;
					Serialize(ref obj, objType, name: name);
					if (type != null) ConvertTypeAfter(ref obj, name, type, f.FieldType);
					f.SetValue(containerObj, obj);
					
					reader.BaseStream.Position = endPos.Pop();
					if (log && !isBigObject) {
						MapLoader.Loader.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + "(" + f.DeclaringType + ") " + f.Name + " - " + obj);
					}
				}
			} else {
				Pointer pos = log ? new Pointer((uint)position, MapLoader.Loader.GetFileByReader(reader)) : null;
				bool isBigObject = log && (typeof(CSerializable).IsAssignableFrom(f.FieldType) || typeof(IObjectContainer).IsAssignableFrom(f.FieldType));
				if (log && isBigObject) {
					MapLoader.Loader.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + "(" + f.DeclaringType + ") " + f.Name + ":");
				}
				object obj = null;

				Serialize(ref obj, objType, name: name);
				if (type != null) ConvertTypeAfter(ref obj, name, type, f.FieldType);
				f.SetValue(containerObj, obj);
				if (log && !isBigObject) {
					MapLoader.Loader.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + "(" + f.DeclaringType + ") " + f.Name + " - " + obj);
				}
			}
		}

		public override void Serialize(object o, FieldInfo f, SerializeAttribute a, Type type = null) {
			if (((a.version & Settings.s.versionFlags) == Settings.s.versionFlags) && (a.flags == SerializeFlags.None || (flags & a.flags) != SerializeFlags.None)) {
				Serialize(o, f, type: type, name: a.Name);
			}
		}

		public override void Serialize<T>(ref T obj, Type type = null, string name = null, int? index = null) {
			/*Pointer pos = log && index.HasValue ? Position : null;
			bool isBigObject = log && index.HasValue && (typeof(CSerializable).IsAssignableFrom(typeof(T)) || typeof(IObjectContainer).IsAssignableFrom(typeof(T)));
			if (log && index.HasValue && isBigObject) {
				MapLoader.Loader.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + name + "[" + index.Value + "]:");
			}*/
			long position = reader.BaseStream.Position;
			Type objType = type ?? typeof(T);
			if (endPos.Count > 0 && position >= endPos.Peek()) {
			} else if (name != null && !objType.IsDefined(typeof(SerializeEmbedAttribute), false)) {
				uint uafType = index.HasValue ? 200 + (uint)index.Value : GetTagCode(objType);
				if (ReadTag(name, uafType)) {
					Pointer pos = log ? new Pointer((uint)position, MapLoader.Loader.GetFileByReader(reader)) : null;
					bool isBigObject = log && name != null && (typeof(CSerializable).IsAssignableFrom(typeof(T)) || typeof(IObjectContainer).IsAssignableFrom(typeof(T)));
					if (log && name != null && isBigObject) {
						MapLoader.Loader.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + name + ":");
					}

					object obj2 = null;
					Serialize(ref obj2, type ?? typeof(T), name: name);
					obj = (T)obj2;

					reader.BaseStream.Position = endPos.Pop();
					if (log && name != null && !isBigObject) {
						MapLoader.Loader.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + name + " - " + obj);
					}
					
				}
			} else {
				Pointer pos = log ? new Pointer((uint)position, MapLoader.Loader.GetFileByReader(reader)) : null;
				bool isBigObject = log && index.HasValue && (typeof(CSerializable).IsAssignableFrom(typeof(T)) || typeof(IObjectContainer).IsAssignableFrom(typeof(T)));
				if (log && index.HasValue && isBigObject) {
					MapLoader.Loader.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + name + "[" + index.Value + "]:");
				}

				object obj2 = null;
				Serialize(ref obj2, type ?? typeof(T), name: name);
				obj = (T)obj2;

				if (log && index.HasValue && !isBigObject) {
					MapLoader.Loader.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + name + "[" + index.Value + "] - " + obj);
				}
			}

			/*if (log && index.HasValue && !isBigObject) {
				MapLoader.Loader.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + name + "[" + index.Value + "] - " + obj);
			}*/
		}

		public override void SerializeBytes(ref byte[] obj, int numBytes) {
			obj = reader.ReadBytes(numBytes);
		}

		public override bool ArrayEntryStart(string name, int index) {
			long position = reader.BaseStream.Position;
			if (ReadTag(name, (uint)(200 + index))) {
				Pointer pos = log ? new Pointer((uint)position, MapLoader.Loader.GetFileByReader(reader)) : null;
				if (log) {
					MapLoader.Loader.Log(Position + ":" + new string(' ', (Indent + 1) * 2) + name + "[" + index + "]:");
				}
				return base.ArrayEntryStart(name, index);
			} else return false;
		}

		public override void ArrayEntryStop() {
			base.ArrayEntryStop();
			reader.BaseStream.Position = endPos.Pop();
		}

		protected bool ReadTag(string name, uint type) {
			UAFInfo info = new UAFInfo {
				name = name,
				type = type
			};
			uint crc = reader.ReadUInt32();
			uint size = reader.ReadUInt32();
			uint requiredCRC = 0;
			if (fieldCRC.ContainsKey(info)) {
				requiredCRC = fieldCRC[info];
			} else {
				requiredCRC = GetCRC(name, type);
				fieldCRC[info] = requiredCRC;
			}
			if (crc == requiredCRC) {
				endPos.Push(reader.BaseStream.Position + size);
				return true;
			} else {
				reader.BaseStream.Seek(-8, System.IO.SeekOrigin.Current);
				return false;
			}
		}

		protected uint GetCRC(string str, uint? classTypeInt) {
			byte[] stringBytes = ASCIIEncoding.ASCII.GetBytes(str);
			Crc crc = new Crc(new Parameters("CRC-32", 32, 0x04C11DB7, 0xFFFFFFFF, false, false, 0xFFFFFFFF, 0xCBF43926));
			uint computedCRC = CrcHelper.ToUInt32(crc.ComputeHash(stringBytes));
			if (classTypeInt.HasValue) {
				byte[] classType = BitConverter.GetBytes(classTypeInt.Value);
				crc = new Crc(new Parameters("CRC-32", 32, 0x04C11DB7, computedCRC, false, false, 0xFFFFFFFF, 0xCBF43926));
				return CrcHelper.ToUInt32(crc.ComputeHash(classType));
			} else {
				return computedCRC;
			}
		}
	}
}
