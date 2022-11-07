using System;
using System.Reflection;
using UbiArt.FileFormat;

namespace UbiArt {
	public class CSerializerObjectBinaryWriter : CSerializerObject {
		
		public CSerializerObjectBinaryWriter(Context context, Writer writer) : base(context) {
			this.Writer = writer;
			flagsOwn = Flags.Flags0 | Flags.Flags4; // 0x11
		}
		public CSerializerObjectBinaryWriter(Context context, BinaryFile file) : this(context, file.CreateWriter()) {
			File = file;
		}

		public BinaryFile File { get; protected set; }
		public Writer Writer { get; protected set; }
		public override Pointer CurrentPointer => new Pointer(CurrentPosition, File);
		public override long CurrentPosition => Writer.BaseStream.Position;
		public override long Length => Writer.BaseStream.Length;

		public override void Goto(long position) {
			if (!Disposed) Writer.BaseStream.Position = position;
		}

		public override void Serialize(ref object obj, Type type, string name = null) {
			if (Type.GetTypeCode(type) != TypeCode.Object) {
				switch (Type.GetTypeCode(type)) {
					case TypeCode.Boolean: Writer.Write((bool)obj); break;
					case TypeCode.Byte: Writer.Write((byte)obj); break;
					case TypeCode.Char: Writer.Write((char)obj); break;
					case TypeCode.String: Writer.Write((string)obj); break;
					case TypeCode.Single: Writer.Write((float)obj); break;
					case TypeCode.Double: Writer.Write((double)obj); break;
					case TypeCode.UInt16: Writer.Write((ushort)obj); break;
					case TypeCode.UInt32: Writer.Write((uint)obj); break;
					case TypeCode.UInt64: Writer.Write((ulong)obj); break;
					case TypeCode.Int16: Writer.Write((short)obj); break;
					case TypeCode.Int32: Writer.Write((int)obj); break;
					case TypeCode.Int64: Writer.Write((long)obj); break;
					default: throw new Exception("Unsupported TypeCode " + Type.GetTypeCode(type));
				}
			} else if (type == typeof(CString)) {
				Writer.Write16(obj != null ? ((CString)obj).str : null);
			} else if (type == typeof(byte[])) {
				Writer.Write(((byte[])obj).Length);
				Writer.Write((byte[])obj);
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



		// Helper method which returns an object so we can cast it
		protected object WritePrimitive<T>(object obj, string name = null, Options options = Options.None) {
			// Get the type
			var type = typeof(T);

			TypeCode typeCode = Type.GetTypeCode(type);

			if (typeCode == TypeCode.Object) {
				if (type == typeof(CString)) {
					Writer.Write16(obj != null ? ((CString)obj).str : null);
				} else if (type == typeof(byte[])) {
					Writer.Write(((byte[])obj).Length);
					Writer.Write((byte[])obj);
				} else {
					throw new Exception(CurrentPointer + ": Field with name " + name + " is not a valid primitive type");
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
						if ((bool)obj) {
							Writer.Write((byte)1);
						} else {
							Writer.Write((byte)0);
						}
					} else {
						Writer.Write((bool)obj);
					}
					break;

				case TypeCode.SByte: Writer.Write((sbyte)obj); break;
				case TypeCode.Byte: Writer.Write((byte)obj); break;
				case TypeCode.Char: Writer.Write((char)obj); break;
				case TypeCode.String: Writer.Write((string)obj); break;
				case TypeCode.Single: Writer.Write((float)obj); break;
				case TypeCode.Double: Writer.Write((double)obj); break;
				case TypeCode.UInt16: Writer.Write((ushort)obj); break;
				case TypeCode.UInt32: Writer.Write((uint)obj); break;
				case TypeCode.UInt64: Writer.Write((ulong)obj); break;
				case TypeCode.Int16: Writer.Write((short)obj); break;
				case TypeCode.Int32: Writer.Write((int)obj); break;
				case TypeCode.Int64: Writer.Write((long)obj); break;
				default: throw new NotSupportedException($"The specified generic type ('{name}') can not be written from the writer");
			}
			return obj;
		}



		public override void Serialize(object containerObj, FieldInfo f, Type type = null, string name = null, int? index = null) {
			bool isBigObject = IsSerializerLogEnabled && (typeof(CSerializable).IsAssignableFrom(f.FieldType) || typeof(IObjectContainer).IsAssignableFrom(f.FieldType));
			object obj = f.GetValue(containerObj);
			if (type != null) ConvertTypeBefore(ref obj, name, type, f.FieldType);
			if (IsSerializerLogEnabled && isBigObject) {
				Context.SerializerLogger.Log($"{LogPrefix}({f.DeclaringType}) {f.Name}:");
			} else if (IsSerializerLogEnabled && !isBigObject) {
				Context.SerializerLogger.Log($"{LogPrefix}({f.DeclaringType}) {f.Name} - {obj}");
			}
			//Context.print(name);
			Serialize(ref obj, type ?? f.FieldType, name: name);
		}

		public override T SerializeGeneric<T>(T obj, Type type = null, string name = null, int? index = null) {
			bool isBigObject = IsSerializerLogEnabled && index.HasValue && (typeof(CSerializable).IsAssignableFrom(typeof(T)) || typeof(IObjectContainer).IsAssignableFrom(typeof(T)));
			if (IsSerializerLogEnabled && index.HasValue && isBigObject) {
				Context.SerializerLogger.Log($"{LogPrefix}{name}[{index.Value}]:");
			} else if (IsSerializerLogEnabled && index.HasValue && !isBigObject) {
				Context.SerializerLogger.Log($"{LogPrefix}{name}[{index.Value}] - {obj}");
			}
			object obj2 = obj;
			Serialize(ref obj2, type ?? typeof(T), name: name);
			return (T)obj2;
		}

		public override T Serialize<T>(T obj, string name = null, int? index = null, Options options = Options.None) {
			Pointer pos = IsSerializerLogEnabled && name != null ? CurrentPointer : null;
			obj = (T)WritePrimitive<T>(obj, name: name, options: options);
			if (IsSerializerLogEnabled && name != null) {
				Context.SerializerLogger.Log($"{LogPrefix}({typeof(T)}) {name} - {obj}");
			}
			return obj;
		}

		public override byte[] SerializeBytes(byte[] obj, long count) {
			Writer.Write(obj);
			return obj;
		}

		public override uint SerializeFileSize(uint obj) {
			//throw new NotImplementedException();
			return obj;
		}

		public override T SerializeObject<T>(T obj, Action<T> onPreSerialize = null, string name = null, int? index = null, Options options = Options.None) {
			bool isBigObject = IsSerializerLogEnabled && (typeof(CSerializable).IsAssignableFrom(typeof(T)) || typeof(IObjectContainer).IsAssignableFrom(typeof(T)));
			if (IsSerializerLogEnabled && index.HasValue && isBigObject) {
				Context.SerializerLogger.Log($"{LogPrefix}{name}[{index.Value}]:");
			} else if (IsSerializerLogEnabled && index.HasValue && !isBigObject) {
				Context.SerializerLogger.Log($"{LogPrefix}{name}[{index.Value}] - {obj}");
			}

			IncreaseLevel();
			if (obj == null) obj = new T();
			obj.Serialize(this, name);
			DecreaseLevel();

			return obj;
		}

		public override T SerializeGenericPureBinary<T>(T obj, Type type = null, string name = null, int? index = null) {
			return SerializeGeneric<T>(obj, type: type, name: name, index: index);
		}

		#region Logging

		protected string LogPrefix => IsSerializerLogEnabled ? $"(W) {CurrentPointer}:{new string(' ', (Depth + 1) * 2)}" : null;
		public override void Log(string logString, params object[] args) {
			if (IsSerializerLogEnabled)
				Context.SerializerLogger.Log(LogPrefix + String.Format(logString, args));
		}

		#endregion
	}
}
