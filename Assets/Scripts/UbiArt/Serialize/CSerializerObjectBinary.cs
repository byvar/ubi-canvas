using Cysharp.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UbiArt.FileFormat;
using UnityEngine;

namespace UbiArt {
	public class CSerializerObjectBinary : CSerializerObject {
		public CSerializerObjectBinary(Context context, Reader reader) : base(context) {
			Reader = reader;
			flagsOwn = Flags.Flags0 | Flags.Flags4; // 0x11
		}
		public CSerializerObjectBinary(Context context, BinaryFile file) : this(context, file.CreateReader()) {
			File = file;
		}

		public BinaryFile File { get; protected set; }
		public Reader Reader { get; protected set; }
		public override Pointer CurrentPointer => new Pointer(CurrentPosition, File);
		public override long CurrentPosition => Reader.BaseStream.Position;
		public override long Length => Reader.BaseStream.Length;

		public override void Goto(long position) {
			if (!Disposed) Reader.BaseStream.Position = position;
		}

		// Helper method which returns an object so we can cast it
		protected object ReadPrimitiveAsObject<T>(string name = null, Options options = Options.None) {
			// Get the type
			var type = typeof(T);

			TypeCode typeCode = Type.GetTypeCode(type);

			if (typeCode == TypeCode.Object) {
				if (type == typeof(CString)) {
					CString s = new CString(Reader.ReadString16());
					Context.AddToStringCache(s);
					return s;
				} else if (type == typeof(byte[])) {
					int numBytes = Reader.ReadInt32();
					return Reader.ReadBytes(numBytes);
				} else {
					throw new Exception($"{CurrentPointer}: Field with name {name} is not a valid primitive type");
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
						uint tmp = Reader.ReadByte();
						if (tmp == 1) {
							return true;
						} else if (tmp != 0) {
							throw new Exception($"{CurrentPointer}: Bool with name {name} was {tmp}!");
							//obj = false;
						} else {
							return false;
						}
					} else {
						uint tmp = Reader.ReadUInt32();
						if (tmp == 1) {
							return true;
						} else if (tmp != 0) {
							throw new Exception($"{CurrentPointer}: Bool with name {name} was {tmp}!");
							//obj = false;
						} else {
							return false;
						}
					}

				case TypeCode.SByte: return Reader.ReadSByte();
				case TypeCode.Byte: return Reader.ReadByte();
				case TypeCode.Int16: return Reader.ReadInt16();
				case TypeCode.UInt16: return Reader.ReadUInt16();
				case TypeCode.Int32: return Reader.ReadInt32();
				case TypeCode.UInt32: return Reader.ReadUInt32();
				case TypeCode.Int64: return Reader.ReadInt64();
				case TypeCode.UInt64: return Reader.ReadUInt64();
				case TypeCode.Single: return Reader.ReadSingle();
				case TypeCode.Double: return Reader.ReadDouble();
				case TypeCode.String:
					string s = Reader.ReadString();
					Context.AddToStringCache(s);
					return s;
				case TypeCode.Char: return Reader.ReadChar();
				default: throw new NotSupportedException($"The specified generic type ('{name}') can not be read from the reader");
			}
		}


		public override void Serialize(ref object obj, Type type, string name = null) {
			if (Type.GetTypeCode(type) != TypeCode.Object) {
				switch (Type.GetTypeCode(type)) {
					case TypeCode.Boolean:
						uint tmp = Reader.ReadUInt32();
						if (tmp == 1) {
							obj = true;
						} else if (tmp != 0) {
							throw new Exception($"{CurrentPointer}: Bool with name {name} was {tmp}!");
							//obj = false;
						} else {
							obj = false;
						}
						//obj = (object)reader.ReadBoolean();
						break;
					case TypeCode.Byte: obj = (object)Reader.ReadByte(); break;
					case TypeCode.Char: obj = (object)Reader.ReadChar(); break;
					case TypeCode.String: obj = (object)Reader.ReadString(); Context.AddToStringCache(obj); break;
					case TypeCode.Single: obj = (object)Reader.ReadSingle(); break;
					case TypeCode.Double: obj = (object)Reader.ReadDouble(); break;
					case TypeCode.UInt16: obj = (object)Reader.ReadUInt16(); break;
					case TypeCode.UInt32: obj = (object)Reader.ReadUInt32(); break;
					case TypeCode.UInt64: obj = (object)Reader.ReadUInt64(); break;
					case TypeCode.Int16: obj = (object)Reader.ReadInt16(); break;
					case TypeCode.Int32: obj = (object)Reader.ReadInt32(); break;
					case TypeCode.Int64: obj = (object)Reader.ReadInt64(); break;
					default: throw new Exception("Unsupported TypeCode " + Type.GetTypeCode(type));
				}
			} else if(type == typeof(CString)) {
				obj = new CString(Reader.ReadString16());
				Context.AddToStringCache(obj);
			} else if (type == typeof(byte[])) {
				int numBytes = Reader.ReadInt32();
				obj = Reader.ReadBytes(numBytes);
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
					Context.AddToStringCache(obj);
				}
			}
		}

		public override void Serialize(object containerObj, FieldInfo f, Type type = null, string name = null, int? index = null) {
			var logPrefix = LogPrefix;
			bool isBigObject = IsSerializerLogEnabled && (typeof(CSerializable).IsAssignableFrom(f.FieldType) || typeof(IObjectContainer).IsAssignableFrom(f.FieldType));
			if (IsSerializerLogEnabled && isBigObject) {
				Context.SerializerLogger.Log($"{logPrefix}({f.DeclaringType}) {f.Name}:");
			}
			object obj = null;
			Serialize(ref obj, type ?? f.FieldType, name: name);
			if (type != null) ConvertTypeAfter(ref obj, name, type, f.FieldType);
			f.SetValue(containerObj, obj);
			if (IsSerializerLogEnabled && !isBigObject) {
				Context.SerializerLogger.Log($"{logPrefix}({f.DeclaringType}) {f.Name} - {obj}");
			}
		}

		public override T SerializeGeneric<T>(T obj, Type type = null, string name = null, int? index = null) {
			var logPrefix = LogPrefix;
			bool isBigObject = IsSerializerLogEnabled && name != null && (typeof(CSerializable).IsAssignableFrom(typeof(T)) || typeof(IObjectContainer).IsAssignableFrom(typeof(T)));
			if (IsSerializerLogEnabled && name != null && isBigObject) {
				Context.SerializerLogger.Log($"{logPrefix}({name}:");
			}

			object obj2 = obj;
			Serialize(ref obj2, type ?? typeof(T), name: name);
			obj = (T)obj2;

			if (IsSerializerLogEnabled && name != null && !isBigObject) {
				Context.SerializerLogger.Log($"{logPrefix}({name} - {obj}");
			}
			return obj;
		}

		public override byte[] SerializeBytes(byte[] obj, long count) {
			return Reader.ReadBytes((int)count);
		}

		public override bool ArrayEntryStart(string name, int index) {
			if (IsSerializerLogEnabled) {
				Context.SerializerLogger.Log($"{LogPrefix}({name}[{index}]:");
			}
			return base.ArrayEntryStart(name, index);
		}

		public override uint SerializeFileSize(uint obj) {
			return (uint)Reader.BaseStream.Length;
		}

		public override T SerializeGenericPureBinary<T>(T obj, Type type = null, string name = null, int? index = null) {
			return SerializeGeneric<T>(obj, type: type, name: name, index: index);
		}

		public override T Serialize<T>(T obj, string name = null, int? index = null, Options options = Options.None) {
			var logPrefix = LogPrefix;

			T t = (T)ReadPrimitiveAsObject<T>(name: name, options: options);

			if (IsSerializerLogEnabled && name != null) {
				Context.SerializerLogger.Log($"{logPrefix}({name} - {t}");
			}
			return t;
		}

		public override T SerializeObject<T>(T obj, Action<T> onPreSerialize = null, string name = null, int? index = null, Options options = Options.None) {
			var logPrefix = LogPrefix;
			bool isBigObject = IsSerializerLogEnabled && (typeof(CSerializable).IsAssignableFrom(typeof(T)) || typeof(IObjectContainer).IsAssignableFrom(typeof(T)));
			if (IsSerializerLogEnabled && isBigObject && name != null) {
				Context.SerializerLogger.Log($"{logPrefix}({typeof(T)}) {name}:");
			}

			IncreaseLevel();
			if (obj == null) obj = new T();
			obj.Serialize(this, name);
			DecreaseLevel();
			Context.AddToStringCache(obj);

			if (IsSerializerLogEnabled && !isBigObject && name != null) {
				Context.SerializerLogger.Log($"{logPrefix}({typeof(T)}) {name} - {obj}");
			}
			return obj;
		}

		public override async UniTask FillCacheForRead(long byteCount) => await Context.FileManager.FillCacheForReadAsync(byteCount, Reader);


		#region Logging

		protected string LogPrefix => IsSerializerLogEnabled ? $"(R) {CurrentPointer}:{new string(' ', (Depth + 1) * 2)}" : null;
		public override void Log(string logString, params object[] args) {
			if (IsSerializerLogEnabled)
				Context.SerializerLogger.Log(LogPrefix + String.Format(logString, args));
		}

		#endregion
	}
}
