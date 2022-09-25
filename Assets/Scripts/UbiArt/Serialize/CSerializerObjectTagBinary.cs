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


		public CSerializerObjectTagBinary(Context context, Reader reader) : base(context) {
			this.reader = reader;
			flagsOwn = Flags.Flags0 | Flags.Flags7; // 0x81
		}

		public override Pointer Position => Pointer.Current(reader);
		public override Pointer Length => new Pointer((uint)reader.BaseStream.Length, Pointer.Current(reader).file);

		public override void ResetPosition() {
			if (!Disposed) {
				reader.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
			}
		}



		protected object FakeSerializePrimitive<T>(T t, string name = null) {
			if (t != null) return t;
			// Get the type
			var type = typeof(T);

			TypeCode typeCode = Type.GetTypeCode(type);

			if (typeCode == TypeCode.Object) {
				if (type == typeof(CString)) {
					return new CString();
				} else if (type == typeof(byte[])) {
					return new byte[0];
				} else {
					throw new Exception(Position + ": Field with name " + name + " is not a valid primitive type");
				}
			}

			switch (typeCode) {
				case TypeCode.Boolean: return default(bool);
				case TypeCode.SByte: return default(sbyte);
				case TypeCode.Byte: return default(byte);
				case TypeCode.Int16: return default(short);
				case TypeCode.UInt16: return default(ushort);
				case TypeCode.Int32: return default(int);
				case TypeCode.UInt32: return default(uint);
				case TypeCode.Int64: return default(long);
				case TypeCode.UInt64: return default(ulong);
				case TypeCode.Single: return default(float);
				case TypeCode.Double: return default(double);
				case TypeCode.String: return "";
				case TypeCode.Char: return default(char);
				default: throw new NotSupportedException($"The specified generic type ('{name}') can not be read from the reader");
			}
		}
		protected T FakeSerializeObject<T>(T t, string name, Type objType) where T : ICSerializable, new() {
			if (t != null) return t;
			if (objType == typeof(Vec2d)) {
				t = (T)(object)Vec2d.Zero;
			} else if (objType == typeof(Vec3d)) {
				t = (T)(object)Vec3d.Zero;
			} else if (objType == typeof(Vec4d)) {
				t = (T)(object)Vec4d.Zero;
			} else if (objType == typeof(Color)) {
				t = (T)(object)Color.Black;
			} else {
				if (t == null) t = new T();
				IncreaseLevel();
				t.Serialize(this, name);
				DecreaseLevel();
			}
			return t;
		}
		protected T SerializeObjectFull<T>(T obj, string name, Type objType) where T : ICSerializable, new() {
			if (fakeSerializeMode) {
				return FakeSerializeObject<T>(obj, name, objType);
			}
			if (objType == typeof(Vec2d)) {
				obj = (T)(object)new Vec2d(reader.ReadSingle(), reader.ReadSingle());
			} else if (objType == typeof(Vec3d)) {
				obj = (T)(object)new Vec3d(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle());
			} else if (objType == typeof(Vec4d)) {
				obj = (T)(object)new Vec4d(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle());
			} else if (objType == typeof(Color)) {
				float b = reader.ReadSingle();
				float g = reader.ReadSingle();
				float r = reader.ReadSingle();
				float a = reader.ReadSingle();
				obj = (T)(object)new Color(r,g,b,a);
			} else {
				if (obj == null) obj = new T();
				IncreaseLevel();
				bool entered = false;
				if (GetTagCode(objType) == 200 && !objType.IsDefined(typeof(SerializeEmbedAttribute), false)) {
					string typeName;
					if (obj is CSerializable) {
						typeName = ((CSerializable)(ICSerializable)obj).ClassName;
					} else {
						typeName = objType.Name;
						if (typeName.Contains('`')) typeName = typeName.Substring(0, typeName.IndexOf("`"));
					}
					entered = ReadTag(typeName, 200);
				}
				obj.Serialize(this, name);
				if (log && entered && endPos.Peek() != reader.BaseStream.Position) {
					Context.Log(Position + ":" + new string(' ', (Indent + 1) * 2) + "ERROR: NOT FULLY READ");
				}
				if (entered) reader.BaseStream.Position = endPos.Pop();
				DecreaseLevel();
				AddToStringCache(obj);
			}
			return obj;
		}
		// Helper method which returns an object so we can cast it
		protected object ReadPrimitiveAsObject<T>(T t, string name = null, Options options = Options.None) {
			if (fakeSerializeMode) {
				return FakeSerializePrimitive(t, name: name);
			}
			// Get the type
			var type = typeof(T);

			TypeCode typeCode = Type.GetTypeCode(type);

			if (typeCode == TypeCode.Object) {
				if (type == typeof(CString)) {
					CString s = new CString(reader.ReadString16());
					AddToStringCache(s);
					return s;
				} else if (type == typeof(byte[])) {
					int numBytes = reader.ReadInt32();
					return reader.ReadBytes(numBytes);
				} else {
					throw new Exception(Position + ": Field with name " + name + " is not a valid primitive type");
				}
			}

			switch (typeCode) {

				case TypeCode.Boolean:
					bool asByte = false;
					if (options.HasFlag(Options.ForceAsByte)) {
						asByte = true;
					} else if (options.HasFlag(Options.BoolAsByte)) {
						asByte = HasFlags(SerializeFlags.Flags1);
					}
					if (asByte) {
						uint tmp = reader.ReadByte();
						if (tmp == 1) {
							return true;
						} else if (tmp != 0) {
							throw new Exception(Position + ": Bool with name " + name + " was " + tmp + "!");
							//obj = false;
						} else {
							return false;
						}
					} else {
						uint tmp = reader.ReadUInt32();
						if (tmp == 1) {
							return true;
						} else if (tmp != 0) {
							throw new Exception(Position + ": Bool with name " + name + " was " + tmp + "!");
							//obj = false;
						} else {
							return false;
						}
					}

				case TypeCode.SByte:
					return reader.ReadSByte();

				case TypeCode.Byte:
					return reader.ReadByte();

				case TypeCode.Int16:
					return reader.ReadInt16();

				case TypeCode.UInt16:
					return reader.ReadUInt16();

				case TypeCode.Int32:
					return reader.ReadInt32();

				case TypeCode.UInt32:
					return reader.ReadUInt32();

				case TypeCode.Int64:
					return reader.ReadInt64();

				case TypeCode.UInt64:
					return reader.ReadUInt64();

				case TypeCode.Single:
					return reader.ReadSingle();

				case TypeCode.Double:
					return reader.ReadDouble();
				case TypeCode.String:
					string s = reader.ReadString();
					AddToStringCache(s);
					return s;
				case TypeCode.Char:
					return reader.ReadChar();
				default:
					throw new NotSupportedException($"The specified generic type ('{name}') can not be read from the reader");
			}
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
						string typeName;
						if (obj is CSerializable) {
							typeName = ((CSerializable)obj).ClassName;
						} else {
							typeName = type.Name;
							if (typeName.Contains('`')) typeName = typeName.Substring(0, typeName.IndexOf("`"));
						}
						entered = ReadTag(typeName, 200);
					}
					((ICSerializable)obj).Serialize(this, name);
					if (log && entered && endPos.Peek() != reader.BaseStream.Position) {
						Pointer pos = new Pointer(reader.BaseStream.Position, Context.GetFileByReader(reader));
						Context.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + "ERROR: NOT FULLY READ");
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
					Pointer pos = log ? new Pointer((uint)position, Context.GetFileByReader(reader)) : null;
					bool isBigObject = log && (typeof(CSerializable).IsAssignableFrom(f.FieldType) || typeof(IObjectContainer).IsAssignableFrom(f.FieldType));
					if (log && isBigObject) {
						Context.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + "(" + f.DeclaringType + ") " + f.Name + ":");
					}
					object obj = null;
					Serialize(ref obj, objType, name: name);
					if (type != null) ConvertTypeAfter(ref obj, name, type, f.FieldType);
					f.SetValue(containerObj, obj);

					if (log && endPos.Peek() != reader.BaseStream.Position) {
						Pointer posNew = new Pointer((uint)reader.BaseStream.Position, Context.GetFileByReader(reader));
						Context.Log(posNew + ":" + new string(' ', (Indent + 1) * 2) + "ERROR: NOT FULLY READ");
					}
					reader.BaseStream.Position = endPos.Pop();
					if (log && !isBigObject) {
						Context.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + "(" + f.DeclaringType + ") " + f.Name + " - " + obj);
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
				Pointer pos = log ? new Pointer((uint)position, Context.GetFileByReader(reader)) : null;
				bool isBigObject = log && (typeof(CSerializable).IsAssignableFrom(f.FieldType) || typeof(IObjectContainer).IsAssignableFrom(f.FieldType));
				if (log && isBigObject) {
					Context.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + "(" + f.DeclaringType + ") " + f.Name + ":");
				}
				object obj = null;

				Serialize(ref obj, objType, name: name);
				if (type != null) ConvertTypeAfter(ref obj, name, type, f.FieldType);
				f.SetValue(containerObj, obj);
				if (log && !isBigObject) {
					Context.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + "(" + f.DeclaringType + ") " + f.Name + " - " + obj);
				}
			}
		}

		public override T SerializeGeneric<T>(T obj, Type type = null, string name = null, int? index = null) {
			/*Pointer pos = log && index.HasValue ? Position : null;
			bool isBigObject = log && index.HasValue && (typeof(CSerializable).IsAssignableFrom(typeof(T)) || typeof(IObjectContainer).IsAssignableFrom(typeof(T)));
			if (log && index.HasValue && isBigObject) {
				Context.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + name + "[" + index.Value + "]:");
			}*/
			long position = reader.BaseStream.Position;
			Type objType = type ?? typeof(T);
			if (endPos.Count > 0 && position >= endPos.Peek()) {
				if (obj == null) {
					bool prevFakeSerializeMode = fakeSerializeMode;
					fakeSerializeMode = true;
					object obj2 = null;
					Serialize(ref obj2, type ?? typeof(T), name: name);
					if(type != null) ConvertTypeAfter(ref obj2, name, type, typeof(T));
					obj = (T)obj2;
					fakeSerializeMode = prevFakeSerializeMode;
				}
			} else if (name != null && !objType.IsDefined(typeof(SerializeEmbedAttribute), false)) {
				uint uafType = index.HasValue ? 200 + (uint)index.Value : GetTagCode(objType);
				if (ReadTag(name, uafType)) {
					Pointer pos = log ? new Pointer((uint)position, Context.GetFileByReader(reader)) : null;
					bool isBigObject = log && name != null && (typeof(CSerializable).IsAssignableFrom(typeof(T)) || typeof(IObjectContainer).IsAssignableFrom(typeof(T)));
					if (!fakeSerializeMode && log && name != null && isBigObject) {
						Context.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + name + ":");
					}

					object obj2 = obj;
					Serialize(ref obj2, type ?? typeof(T), name: name);
					if (type != null) ConvertTypeAfter(ref obj2, name, type, typeof(T));
					obj = (T)obj2;


					if (log && endPos.Peek() != reader.BaseStream.Position) {
						Context.Log(Position + ":" + new string(' ', (Indent + 1) * 2) + "ERROR: NOT FULLY READ");
					}
					reader.BaseStream.Position = endPos.Pop();
					if (!fakeSerializeMode && log && name != null && !isBigObject) {
						Context.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + name + " - " + obj);
					}

				} else {
					if (obj == null) {
						bool prevFakeSerializeMode = fakeSerializeMode;
						fakeSerializeMode = true;
						object obj2 = null;
						Serialize(ref obj2, type ?? typeof(T), name: name);
						if (type != null) ConvertTypeAfter(ref obj2, name, type, typeof(T));
						obj = (T)obj2;
						fakeSerializeMode = prevFakeSerializeMode;
					}
				}
			} else {
				Pointer pos = log ? new Pointer((uint)position, Context.GetFileByReader(reader)) : null;
				bool isBigObject = log && index.HasValue && (typeof(CSerializable).IsAssignableFrom(typeof(T)) || typeof(IObjectContainer).IsAssignableFrom(typeof(T)));
				if (!fakeSerializeMode && log && index.HasValue && isBigObject) {
					Context.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + name + "[" + index.Value + "]:");
				}

				object obj2 = obj;
				Serialize(ref obj2, type ?? typeof(T), name: name);
				if (type != null) ConvertTypeAfter(ref obj2, name, type, typeof(T));
				obj = (T)obj2;

				if (!fakeSerializeMode && log && index.HasValue && !isBigObject) {
					Context.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + name + "[" + index.Value + "] - " + obj);
				}
			}
			return obj;

			/*if (log && index.HasValue && !isBigObject) {
				Context.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + name + "[" + index.Value + "] - " + obj);
			}*/
		}

		public override byte[] SerializeBytes(byte[] obj, int numBytes) {
			if (fakeSerializeMode) return obj;
			return reader.ReadBytes(numBytes);
		}

		public override bool ArrayEntryStart(string name, int index) {
			long position = reader.BaseStream.Position;
			if (ReadTag(name, (uint)(200 + index))) {
				Pointer pos = log ? new Pointer(position, Context.GetFileByReader(reader)) : null;
				if (log) {
					Context.Log(Position + ":" + new string(' ', (Indent + 1) * 2) + name + "[" + index + "]:");
				}
				return base.ArrayEntryStart(name, index);
			} else return false;
		}

		public override void ArrayEntryStop() {
			base.ArrayEntryStop();

			if (log && endPos.Peek() != reader.BaseStream.Position) {
				Context.Log(Position + ":" + new string(' ', (Indent + 1) * 2) + "ERROR: NOT FULLY READ");
			}
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
				//Context.Log((Position-8) + ":" + new string(' ', (Indent + 1) * 2) + "TAG: " + name + " (" + type + ")");
				endPos.Push(reader.BaseStream.Position + size);
				return true;
			} else {
				//Context.Log((Position - 8) + ":" + new string(' ', (Indent + 1) * 2) + "Read tag failed: " + name + " (" + type + ")");
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

		public override uint SerializeFileSize(uint obj) {
			return (uint)reader.BaseStream.Length;
		}

		public override T SerializeGenericPureBinary<T>(T obj, Type type = null, string name = null, int? index = null) {
			Pointer pos = log && name != null ? Position : null;
			bool isBigObject = log && name != null && (typeof(CSerializable).IsAssignableFrom(typeof(T)) || typeof(IObjectContainer).IsAssignableFrom(typeof(T)));
			if (log && name != null && isBigObject) {
				Context.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + name + ":");
			}

			object obj2 = obj;
			Serialize(ref obj2, type ?? typeof(T), name: name);
			obj = (T)obj2;

			if (log && name != null && !isBigObject) {
				Context.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + name + " - " + obj);
			}
			return obj;
		}

		public override T Serialize<T>(T obj, string name = null, int? index = null, Options options = Options.None) {
			//return SerializeGeneric<T>(obj, name: name, index: index);

			long position = reader.BaseStream.Position;
			if (endPos.Count > 0 && position >= endPos.Peek()) {
				if (obj == null) {
					bool prevFakeSerializeMode = fakeSerializeMode;
					fakeSerializeMode = true;
					obj = (T)ReadPrimitiveAsObject<T>(obj, name: name, options: options);
					fakeSerializeMode = prevFakeSerializeMode;
				}
			} else if (name != null) {
				Type objType = typeof(T);
				uint uafType = index.HasValue ? 200 + (uint)index.Value : GetTagCode(objType);
				if (ReadTag(name, uafType)) {
					Pointer pos = log ? new Pointer((uint)position, Context.GetFileByReader(reader)) : null;
					obj = (T)ReadPrimitiveAsObject<T>(obj, name: name, options: options);

					if (log && endPos.Peek() != reader.BaseStream.Position) {
						Context.Log(Position + ":" + new string(' ', (Indent + 1) * 2) + "ERROR: NOT FULLY READ");
					}
					reader.BaseStream.Position = endPos.Pop();
					if (!fakeSerializeMode && log && name != null) {
						Context.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + name + " - " + obj);
					}
				} else {
					if (obj == null) {
						bool prevFakeSerializeMode = fakeSerializeMode;
						fakeSerializeMode = true;
						obj = (T)ReadPrimitiveAsObject<T>(obj, name: name, options: options);
						fakeSerializeMode = prevFakeSerializeMode;
					}
				}
			} else {
				Pointer pos = log && name != null ? new Pointer((uint)position, Context.GetFileByReader(reader)) : null;
				obj = (T)ReadPrimitiveAsObject<T>(obj, name: name, options: options);
				if (!fakeSerializeMode && log && name != null) {
					Context.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + name + " - " + obj);
				}
			}
			return obj;
		}

		public override T SerializeObject<T>(T obj, Action<T> onPreSerialize = null, string name = null, int? index = null, Options options = Options.None) {
			//return SerializeGeneric<T>(obj, name: name, index: index);
			long position = reader.BaseStream.Position;
			Type objType = typeof(T);
			if (endPos.Count > 0 && position >= endPos.Peek()) {
				if (obj == null) {
					bool prevFakeSerializeMode = fakeSerializeMode;
					fakeSerializeMode = true;
					obj = SerializeObjectFull<T>(obj, name: name, objType);
					fakeSerializeMode = prevFakeSerializeMode;
				}
			} else if (name != null && !objType.IsDefined(typeof(SerializeEmbedAttribute), false)) {
				uint uafType = index.HasValue ? 200 + (uint)index.Value : GetTagCode(objType);
				/*if (name == "collisionData" && log) {
					Pointer pos = log ? new Pointer(position, Context.GetFileByReader(reader)) : null;
					Context.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + "(" + typeof(T) + ") " + name + ":" + " - " + index + " - " + objType + " - " + uafType);
				}*/
				if (ReadTag(name, uafType)) {
					Pointer pos = log ? new Pointer(position, Context.GetFileByReader(reader)) : null;
					bool isBigObject = log && (typeof(CSerializable).IsAssignableFrom(objType) || typeof(IObjectContainer).IsAssignableFrom(objType));

					if (!fakeSerializeMode && log && isBigObject && name != null) {
						Context.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + "(" + typeof(T) + ") " + name + ":");
					}

					obj = SerializeObjectFull<T>(default, name, objType);

					if (log && endPos.Peek() != reader.BaseStream.Position) {
						Pointer posNew = new Pointer(reader.BaseStream.Position, Context.GetFileByReader(reader));
						Context.Log(posNew + ":" + new string(' ', (Indent + 1) * 2) + "ERROR: NOT FULLY READ");
					}
					reader.BaseStream.Position = endPos.Pop();

					if (!fakeSerializeMode && log && !isBigObject && name != null) {
						Context.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + "(" + typeof(T) + ") " + name + " - " + obj);
					}
				} else {
					if (obj == null) {
						bool prevFakeSerializeMode = fakeSerializeMode;
						fakeSerializeMode = true;
						obj = SerializeObjectFull<T>(obj, name: name, objType);
						fakeSerializeMode = prevFakeSerializeMode;
					}
				}
			} else {
				Pointer pos = log ? new Pointer(position, Context.GetFileByReader(reader)) : null;
				bool isBigObject = log && (typeof(CSerializable).IsAssignableFrom(objType) || typeof(IObjectContainer).IsAssignableFrom(objType));

				if (!fakeSerializeMode && log && isBigObject && name != null) {
					Context.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + "(" + typeof(T) + ") " + name + ":");
				}

				obj = SerializeObjectFull<T>(obj, name, objType);

				if (!fakeSerializeMode && log && !isBigObject && name != null) {
					Context.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + "(" + typeof(T) + ") " + name + " - " + obj);
				}
			}
			return obj;
		}
	}
}
