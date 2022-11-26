using System;
using System.IO;

namespace UbiArt {
	public class CSerializable : ICSerializable {
		protected bool IsFirstLoad { get; set; } = true;
		public Context UbiArtContext { get; protected set; }
		public uint sizeOf = 0;

		public void Serialize(CSerializerObject s, string name) {
			UbiArtContext = s.Context;
			OnPreSerialize(s);
			SerializeImpl(s);
			OnPostSerialize(s);
			IsFirstLoad = false;
		}

		protected virtual void OnPreSerialize(CSerializerObject s) {}
		protected virtual void OnPostSerialize(CSerializerObject s) {}
		protected virtual void SerializeImpl(CSerializerObject s) {
			if (s.HasSerializerFlags(CSerializerObject.Flags.StoreObjectSizes)
				&& !s.Embedded
				&& s.Settings.engineVersion > Settings.EngineVersion.RO
				&& !(s is CSerializerObjectTagBinary)) {
				sizeOf = s.Serialize<uint>(sizeOf, name: "sizeof");
			}
		}

		public virtual CSerializable Clone(string extension) {
			byte[] serializedData = null;
			CSerializable result = null;
			using (MemoryStream stream = new MemoryStream()) {
				using (Writer writer = new Writer(stream, UbiArtContext.Settings.IsLittleEndian)) {
					CSerializerObjectBinaryWriter w = new CSerializerObjectBinaryWriter(UbiArtContext, writer);
					Loader.ConfigureSerializeFlagsForExtension(ref w.flags, ref w.flagsOwn, extension);
					object toWrite = this;
					w.Serialize(ref toWrite, GetType(), name: "clone");
					serializedData = stream.ToArray();
				}
			}
			using (MemoryStream stream = new MemoryStream(serializedData)) {
				using (Reader reader = new Reader(stream, UbiArtContext.Settings.IsLittleEndian)) {
					CSerializerObject r = new CSerializerObjectBinary(UbiArtContext, reader);
					Loader.ConfigureSerializeFlagsForExtension(ref r.flags, ref r.flagsOwn, extension);
					object toRead = null;
					r.Serialize(ref toRead, GetType(), name: "clone");
					result = toRead as CSerializable;
				}
			}
			return result;
		}

		public virtual string ClassName {
			get {
				Type t = GetType();
				if (t.IsGenericType) {
					string typeName = t.Name;
					if (typeName.Contains('`')) typeName = typeName.Substring(0, typeName.IndexOf("`"));
					return typeName;
				} else {
					return t.Name;
				}
			}
		}

		public virtual uint? ClassCRC => null;
	}
}