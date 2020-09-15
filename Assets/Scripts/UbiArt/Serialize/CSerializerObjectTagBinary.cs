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
		protected bool fakeSerializeMode = false;


		public CSerializerObjectTagBinary(Reader reader) {
			this.reader = reader;
			flagsOwn = Flags.Flags0 | Flags.Flags7; // 0x81
		}

		public override Pointer Position => Pointer.Current(reader);
		public override Pointer Length => new Pointer((uint)reader.BaseStream.Length, Pointer.Current(reader).file);

		public override void ResetPosition() {
			reader.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
		}

		public override void Serialize(ref object obj, Type type, string name = null) {
			if (fakeSerializeMode) {
				FakeSerialize(ref obj, type, name: name);
				return;
			}
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
					case TypeCode.String: obj = (object)reader.ReadString(); AddToStringCache(obj); break;
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
			} else if (type == typeof(CString)) {
				obj = new CString(reader.ReadString16());
				AddToStringCache(obj);
			} else if (type == typeof(byte[])) {
				int numBytes = reader.ReadInt32();
				obj = reader.ReadBytes(numBytes);
			} else {
				if (obj == null) {
					var ctor = type.GetConstructor(Type.EmptyTypes);
					if (ctor == null) {
						throw new Exception("Constructor is null");
					}
					obj = ctor.Invoke(new object[] { });
				}
				if (obj is ICSerializable) {
					IncreaseLevel();
					bool entered = false;
					if (GetTagCode(type) == 200
						&& !type.IsDefined(typeof(SerializeEmbedAttribute), false)) {
						string typename = type.Name;
						if (obj is CSerializable) typename = ((CSerializable)obj).ClassName;
						entered = ReadTag(typename, 200);
					}
					((ICSerializable)obj).Serialize(this, name);
					if (log && entered && endPos.Peek() != reader.BaseStream.Position) {
						Pointer pos = new Pointer((uint)reader.BaseStream.Position, MapLoader.Loader.GetFileByReader(reader));
						MapLoader.Loader.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + "ERROR: NOT FULLY READ");
					}
					if (entered) reader.BaseStream.Position = endPos.Pop();
					DecreaseLevel();
					AddToStringCache(obj);
				}
			}
		}

		public void FakeSerialize(ref object obj, Type type, string name = null) {
			if (obj != null) {
				return;
			}
			if (Type.GetTypeCode(type) != TypeCode.Object) {
				switch (Type.GetTypeCode(type)) {
					case TypeCode.Boolean: obj = default(bool); break;
					case TypeCode.Byte: obj = default(byte); break;
					case TypeCode.Char: obj = default(char); break;
					case TypeCode.String: obj = ""; break;
					case TypeCode.Single: obj = default(float); break;
					case TypeCode.Double: obj = default(double); break;
					case TypeCode.UInt16: obj = default(ushort); break;
					case TypeCode.UInt32: obj = default(uint); break;
					case TypeCode.UInt64: obj = default(ulong); break;
					case TypeCode.Int16: obj = default(short); break;
					case TypeCode.Int32: obj = default(int); break;
					case TypeCode.Int64: obj = default(long); break;
					default: throw new Exception("Unsupported TypeCode " + Type.GetTypeCode(type));
				}
			} else if (type == typeof(Vec2d)) {
				obj = default(Vec2d);
			} else if (type == typeof(Vec3d)) {
				obj = default(Vec3d);
			} else if (type == typeof(Vector4)) {
				obj = default(Vector4);
			} else if (type == typeof(Color)) {
				obj = default(Color);
			} else if (type == typeof(CString)) {
				obj = new CString();
			} else if (type == typeof(byte[])) {
				obj = new byte[0];
			} else {
				var ctor = type.GetConstructor(Type.EmptyTypes);
				if (ctor == null) {
					throw new Exception("Constructor is null");
				}
				obj = ctor.Invoke(new object[] { });
				if (obj is ICSerializable) {
					IncreaseLevel();
					((ICSerializable)obj).Serialize(this, name);
					DecreaseLevel();
				}
			}
		}

		public override void Serialize(object containerObj, FieldInfo f, Type type = null, string name = null, int? index = null) {
			long position = reader.BaseStream.Position;
			Type objType = type ?? f.FieldType;
			if (endPos.Count > 0 && position >= endPos.Peek()) {
				if (f.GetValue(containerObj) == null) {
					bool prevFakeSerializeMode = fakeSerializeMode;
					fakeSerializeMode = true;
					object obj = null;
					Serialize(ref obj, objType, name: name);
					if (type != null) ConvertTypeAfter(ref obj, name, type, f.FieldType);
					f.SetValue(containerObj, obj);
					fakeSerializeMode = prevFakeSerializeMode;
				}
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

					if (log && endPos.Peek() != reader.BaseStream.Position) {
						Pointer posNew = new Pointer((uint)reader.BaseStream.Position, MapLoader.Loader.GetFileByReader(reader));
						MapLoader.Loader.Log(posNew + ":" + new string(' ', (Indent + 1) * 2) + "ERROR: NOT FULLY READ");
					}
					reader.BaseStream.Position = endPos.Pop();
					if (log && !isBigObject) {
						MapLoader.Loader.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + "(" + f.DeclaringType + ") " + f.Name + " - " + obj);
					}
				} else {
					if (f.GetValue(containerObj) == null) {
						bool prevFakeSerializeMode = fakeSerializeMode;
						fakeSerializeMode = true;
						object obj = null;
						Serialize(ref obj, objType, name: name);
						if (type != null) ConvertTypeAfter(ref obj, name, type, f.FieldType);
						f.SetValue(containerObj, obj);
						fakeSerializeMode = prevFakeSerializeMode;
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

		public override void Serialize<T>(ref T obj, Type type = null, string name = null, int? index = null) {
			/*Pointer pos = log && index.HasValue ? Position : null;
			bool isBigObject = log && index.HasValue && (typeof(CSerializable).IsAssignableFrom(typeof(T)) || typeof(IObjectContainer).IsAssignableFrom(typeof(T)));
			if (log && index.HasValue && isBigObject) {
				MapLoader.Loader.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + name + "[" + index.Value + "]:");
			}*/
			long position = reader.BaseStream.Position;
			Type objType = type ?? typeof(T);
			if (endPos.Count > 0 && position >= endPos.Peek()) {
				if (obj == null) {
					bool prevFakeSerializeMode = fakeSerializeMode;
					fakeSerializeMode = true;
					object obj2 = null;
					Serialize(ref obj2, type ?? typeof(T), name: name);
					obj = (T)obj2;
					fakeSerializeMode = prevFakeSerializeMode;
				}
			} else if (name != null && !objType.IsDefined(typeof(SerializeEmbedAttribute), false)) {
				uint uafType = index.HasValue ? 200 + (uint)index.Value : GetTagCode(objType);
				if (ReadTag(name, uafType)) {
					Pointer pos = log ? new Pointer((uint)position, MapLoader.Loader.GetFileByReader(reader)) : null;
					bool isBigObject = log && name != null && (typeof(CSerializable).IsAssignableFrom(typeof(T)) || typeof(IObjectContainer).IsAssignableFrom(typeof(T)));
					if (log && name != null && isBigObject) {
						MapLoader.Loader.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + name + ":");
					}

					object obj2 = obj;
					Serialize(ref obj2, type ?? typeof(T), name: name);
					obj = (T)obj2;

					reader.BaseStream.Position = endPos.Pop();
					if (log && name != null && !isBigObject) {
						MapLoader.Loader.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + name + " - " + obj);
					}

				} else {
					if (obj == null) {
						bool prevFakeSerializeMode = fakeSerializeMode;
						fakeSerializeMode = true;
						object obj2 = null;
						Serialize(ref obj2, type ?? typeof(T), name: name);
						obj = (T)obj2;
						fakeSerializeMode = prevFakeSerializeMode;
					}
				}
			} else {
				Pointer pos = log ? new Pointer((uint)position, MapLoader.Loader.GetFileByReader(reader)) : null;
				bool isBigObject = log && index.HasValue && (typeof(CSerializable).IsAssignableFrom(typeof(T)) || typeof(IObjectContainer).IsAssignableFrom(typeof(T)));
				if (log && index.HasValue && isBigObject) {
					MapLoader.Loader.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + name + "[" + index.Value + "]:");
				}

				object obj2 = obj;
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
			if (fakeSerializeMode) return;
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
			if (fakeSerializeMode) return false;
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

		public override void SerializeFileSize(ref uint obj) {
			obj = (uint)reader.BaseStream.Length;
		}

		public override void SerializePureBinary<T>(ref T obj, Type type = null, string name = null, int? index = null) {
			Pointer pos = log && name != null ? Position : null;
			bool isBigObject = log && name != null && (typeof(CSerializable).IsAssignableFrom(typeof(T)) || typeof(IObjectContainer).IsAssignableFrom(typeof(T)));
			if (log && name != null && isBigObject) {
				MapLoader.Loader.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + name + ":");
			}

			object obj2 = obj;
			Serialize(ref obj2, type ?? typeof(T), name: name);
			obj = (T)obj2;

			if (log && name != null && !isBigObject) {
				MapLoader.Loader.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + name + " - " + obj);
			}
		}

		public override T Serialize<T>(T obj, string name = null, Options options = Options.None) {
			throw new NotImplementedException();
		}

		public override T SerializeObject<T>(T obj, Action<T> onPreSerialize = null, string name = null, Options options = Options.None) {
			throw new NotImplementedException();
		}
	}
}
