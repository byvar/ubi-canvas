using System;
using System.IO;
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

		public override void Dispose() {
			base.Dispose();
			Writer?.Dispose();
		}

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
			bool isBigObject = IsBigObject(type ?? f.FieldType); 
			object obj = f.GetValue(containerObj);
			if (type != null) ConvertTypeBefore(ref obj, name, type, f.FieldType);
			if (IsSerializerLoggerEnabled) {
				if (isBigObject) {
					Context.SerializerLogger.Log($"{LogPrefix}({f.DeclaringType}) {f.Name}:");
				} else {
					Context.SerializerLogger.Log($"{LogPrefix}({f.DeclaringType}) {f.Name} - {ShortLog(obj)}");
				}
			}
			Serialize(ref obj, type ?? f.FieldType, name: name);
		}

		public override T SerializeGeneric<T>(T obj, Type type = null, string name = null, int? index = null) {
			var usedType = type ?? typeof(T);
			bool isBigObject = IsBigObject(usedType);
			if (IsSerializerLoggerEnabled) {
				if (index.HasValue) {
					if (isBigObject) {
						Context.SerializerLogger.Log($"{LogPrefix}({usedType}) {name}[{index.Value}]:");
					} else {
						Context.SerializerLogger.Log($"{LogPrefix}({usedType}) {name}[{index.Value}] - {ShortLog(obj)}");
					}
				} else {
					if (isBigObject) {
						Context.SerializerLogger.Log($"{LogPrefix}({usedType}) {name}:");
					} else {
						Context.SerializerLogger.Log($"{LogPrefix}({usedType}) {name} - {ShortLog(obj)}");
					}
				}
			}
			object obj2 = obj;
			Serialize(ref obj2, usedType, name: name);
			return (T)obj2;
		}

		public override T Serialize<T>(T obj, string name = null, int? index = null, Options options = Options.None) {
			Pointer pos = IsSerializerLoggerEnabled && name != null ? CurrentPointer : null;
			obj = (T)WritePrimitive<T>(obj, name: name, options: options);
			if (IsSerializerLoggerEnabled && name != null) {
				Context.SerializerLogger.Log($"{LogPrefix}({typeof(T)}) {name} - {ShortLog(obj)}");
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

			bool isBigObject = IsBigObject(typeof(T));

			if (IsSerializerLoggerEnabled && isBigObject && name != null) {
				Context.SerializerLogger.Log($"{LogPrefix}({typeof(T)}) {name}:");
			}
			if (IsSerializerLoggerEnabled) {
				if (index.HasValue) {
					if (isBigObject) {
						Context.SerializerLogger.Log($"{LogPrefix}{typeof(T)} {name}[{index.Value}]:");
					} else {
						Context.SerializerLogger.Log($"{LogPrefix}{typeof(T)} {name}[{index.Value}] - {ShortLog(obj)}");
					}
				} else {
					if (isBigObject) {
						Context.SerializerLogger.Log($"{LogPrefix}{typeof(T)} {name}:");
					} else {
						Context.SerializerLogger.Log($"{LogPrefix}{typeof(T)} {name} - {ShortLog(obj)}");
					}
				}
			}

			IncreaseLevel();
			try {
				if (obj == null) obj = new T();
				obj.Serialize(this, name);
			} finally {
				DecreaseLevel();
			}

			return obj;
		}

		public override T SerializeGenericPureBinary<T>(T obj, Type type = null, string name = null, int? index = null) {
			return SerializeGeneric<T>(obj, type: type, name: name, index: index);
		}

		#region Logging

		protected string LogPrefix => IsSerializerLoggerEnabled ? $"(W) {CurrentPointer}:{new string(' ', (Depth + 1) * 2)}" : null;
		public override void Log(string logString, params object[] args) {
			if (IsSerializerLoggerEnabled)
				Context.SerializerLogger.Log(LogPrefix + String.Format(logString, args));
		}

		#endregion

		#region Encoding


		protected override void DoEncoded(IStreamEncoder encoder, Action action, Endian? endianness = null, string filename = null) {

			if (action == null)
				throw new ArgumentNullException(nameof(action));

			if (encoder == null) {
				action();
				return;
			}

			using MemoryStream decodedStream = new();

			// Stream key
			string key = filename ?? $"{CurrentPointer}_{encoder.Name}";

			// Create a temporary file for the stream to serialize to
			BinaryStreamFile sf = new(
				context: Context,
				name: key,
				stream: decodedStream,
				endianness: endianness ?? File.Endianness);

			var writer = Writer;
			var file = File;

			var tuple = new Tuple<string, UbiArtFile>(key, sf);

			try {
				// Add the temporary file
				File = sf;
				Writer = sf.CreateWriter();
				Context.Loader.virtualFiles.Add(tuple);
				Context.AddFile(sf);

				// Serialize the data into the stream
				action();

				// Encode the stream to the current file
				decodedStream.Position = 0;
				encoder.EncodeStream(decodedStream, Writer.BaseStream);
			} finally {
				// Remove the temporary file
				Writer = writer;
				File = file;
				Context.Loader.virtualFiles.Remove(tuple);
			}
		}
		public override void DoEncrypted(uint[] encryptionKey, Action action, string name = null) {
			throw new NotImplementedException();
		}
		public override void DoCompressed(Action action, string name = null) {
			throw new NotImplementedException();
		}
		#endregion
	}
}
