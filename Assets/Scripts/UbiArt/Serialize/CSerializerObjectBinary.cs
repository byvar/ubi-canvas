using Cysharp.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt {
	public class CSerializerObjectBinary : CSerializerObject {
		public Reader reader;


		public CSerializerObjectBinary(Reader reader) {
			this.reader = reader;
			flagsOwn = Flags.Flags0 | Flags.Flags4; // 0x11
		}

		public override Pointer Position => Pointer.Current(reader);
		public override Pointer Length => new Pointer((uint)reader.BaseStream.Length, Pointer.Current(reader).file);

		public override void ResetPosition() {
			reader.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
		}


		// Helper method which returns an object so we can cast it
		protected object ReadPrimitiveAsObject<T>(string name = null, Options options = Options.None) {
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
					if(asByte) {
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
			} else if(type == typeof(CString)) {
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
					((ICSerializable)obj).Serialize(this, name);
					DecreaseLevel();
					AddToStringCache(obj);
				}
			}
		}

		public override void Serialize(object containerObj, FieldInfo f, Type type = null, string name = null, int? index = null) {
			Pointer pos = log ? Position : null;
			bool isBigObject = log && (typeof(CSerializable).IsAssignableFrom(f.FieldType) || typeof(IObjectContainer).IsAssignableFrom(f.FieldType));
			if (log && isBigObject) {
				MapLoader.Loader.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + "(" + f.DeclaringType + ") " + f.Name + ":");
			}
			object obj = null;
			Serialize(ref obj, type ?? f.FieldType, name: name);
			if (type != null) ConvertTypeAfter(ref obj, name, type, f.FieldType);
			f.SetValue(containerObj, obj);
			if (log && !isBigObject) {
				MapLoader.Loader.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + "(" + f.DeclaringType + ") " + f.Name + " - " + obj);
			}
		}

		public override T SerializeGeneric<T>(T obj, Type type = null, string name = null, int? index = null) {
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
			return obj;
		}

		public override void SerializeBytes(ref byte[] obj, int numBytes) {
			obj = reader.ReadBytes(numBytes);
		}

		public override bool ArrayEntryStart(string name, int index) {
			if (log) {
				MapLoader.Loader.Log(Position + ":" + new string(' ', (Indent + 1) * 2) + name + "[" + index + "]:");
			}
			return base.ArrayEntryStart(name, index);
		}

		public override void SerializeFileSize(ref uint obj) {
			obj = (uint)reader.BaseStream.Length;
		}

		public override void SerializePureBinary<T>(ref T obj, Type type = null, string name = null, int? index = null) {
			obj = SerializeGeneric<T>(obj, type: type, name: name, index: index);
		}

		public override T Serialize<T>(T obj, string name = null, int? index = null, Options options = Options.None) {
			Pointer pos = log && name != null ? Position : null;

			T t = (T)ReadPrimitiveAsObject<T>(name: name, options: options);

			if (log && name != null) {
				MapLoader.Loader.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + name + " - " + t);
			}
			return t;
		}

		public override T SerializeObject<T>(T obj, Action<T> onPreSerialize = null, string name = null, int? index = null, Options options = Options.None) {
			Pointer pos = log ? Position : null;
			bool isBigObject = log && (typeof(CSerializable).IsAssignableFrom(typeof(T)) || typeof(IObjectContainer).IsAssignableFrom(typeof(T)));
			if (log && isBigObject && name != null) {
				MapLoader.Loader.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + "(" + typeof(T) + ") " + name + ":");
			}

			IncreaseLevel();
			T newObj;
			if (obj == null) {
				newObj = new T();
			} else {
				newObj = obj;
			}
			newObj.Serialize(this, name);
			DecreaseLevel();
			AddToStringCache(newObj);

			if (log && !isBigObject && name != null) {
				MapLoader.Loader.Log(pos + ":" + new string(' ', (Indent + 1) * 2) + "(" + typeof(T) + ") " + name + " - " + newObj);
			}
			return newObj;
		}

		public override async UniTask FillCacheForRead(long byteCount) {
			await base.FillCacheForRead(byteCount);
			if (reader.BaseStream is PartialHttpStream p) {
				await p.FillCacheForRead(byteCount);
			}
		}
	}
}
