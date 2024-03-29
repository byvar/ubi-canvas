﻿using System;
using System.IO;
using System.Runtime.Serialization;

namespace UbiArt {
	public class CSerializable : ICSerializable {
		[IgnoreDataMember]
		protected bool IsFirstLoad { get; set; } = true;
		[IgnoreDataMember]
		public Context UbiArtContext { get; protected set; }
		[IgnoreDataMember]
		public uint sizeOf = 0;

		public void InitContext(Context c) {
			UbiArtContext = c;
		}

		public void Serialize(CSerializerObject s, string name) {
			InitContext(s.Context);
			OnPreSerialize(s);
			SerializeImpl(s);
			OnPostSerialize(s);
			IsFirstLoad = false;
		}

		protected virtual void OnPreSerialize(CSerializerObject s) {}
		protected virtual void OnPostSerialize(CSerializerObject s) {}
		protected virtual void SerializeImpl(CSerializerObject s) {
			if (s.HasProperty(CSerializerObject.SerializerProperty.StoreObjectSizes)
				&& !s.Embedded
				&& s.Settings.EngineVersion > EngineVersion.RO
				&& !(s is CSerializerObjectTagBinary)) {
				sizeOf = s.Serialize<uint>(sizeOf, name: "sizeof");
			}
		}

		public virtual CSerializable Clone(string extension, Context context = null) {
			byte[] serializedData = null;
			context ??= UbiArtContext;
			CSerializable result = null;
			using (MemoryStream stream = new MemoryStream()) {
				using (Writer writer = new Writer(stream, context.Settings.IsLittleEndian)) {
					CSerializerObjectBinaryWriter w = new CSerializerObjectBinaryWriter(context, writer);
					Loader.ConfigureSerializeFlagsForExtension(ref w.flags, ref w.properties, extension);
					object toWrite = this;
					w.Serialize(ref toWrite, GetType(), name: "clone");
					serializedData = stream.ToArray();
				}
			}
			using (MemoryStream stream = new MemoryStream(serializedData)) {
				using (Reader reader = new Reader(stream, context.Settings.IsLittleEndian)) {
					CSerializerObject r = new CSerializerObjectBinary(context, reader);
					Loader.ConfigureSerializeFlagsForExtension(ref r.flags, ref r.properties, extension);
					object toRead = null;
					r.Serialize(ref toRead, GetType(), name: "clone");
					result = toRead as CSerializable;
				}
			}
			return result;
		}

		[IgnoreDataMember]
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

		[IgnoreDataMember]
		public virtual uint? ClassCRC => null;
	}
}