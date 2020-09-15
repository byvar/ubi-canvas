using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt {
	public class CSerializable : ICSerializable {
		protected bool isFirstLoad = true;
		public uint sizeOf;

		public void Serialize(CSerializerObject s, string name) {
			OnPreSerialize(s);
			SerializeImpl(s);
			OnPostSerialize(s);
			isFirstLoad = false;
		}

		protected virtual void OnPreSerialize(CSerializerObject s) {}
		protected virtual void OnPostSerialize(CSerializerObject s) {}
		protected virtual void SerializeImpl(CSerializerObject s) {
			if (s.HasSerializerFlags(CSerializerObject.Flags.StoreObjectSizes)
				&& !s.Embedded
				&& Settings.s.engineVersion > Settings.EngineVersion.RO
				&& !(s is CSerializerObjectTagBinary)) {
				sizeOf = s.Serialize<uint>(sizeOf, name: "sizeof");
			}
		}

		public virtual CSerializable Clone(string extension) {
			byte[] serializedData = null;
			CSerializable result = null;
			using (MemoryStream stream = new MemoryStream()) {
				using (Writer writer = new Writer(stream, Settings.s.IsLittleEndian)) {
					CSerializerObjectBinaryWriter w = new CSerializerObjectBinaryWriter(writer);
					MapLoader.ConfigureSerializeFlagsForExtension(ref w.flags, ref w.flagsOwn, extension);
					object toWrite = this;
					w.Serialize(ref toWrite, GetType(), name: "clone");
					serializedData = stream.ToArray();
				}
			}
			using (MemoryStream stream = new MemoryStream(serializedData)) {
				using (Reader reader = new Reader(stream, Settings.s.IsLittleEndian)) {
					CSerializerObject r = new CSerializerObjectBinary(reader);
					MapLoader.ConfigureSerializeFlagsForExtension(ref r.flags, ref r.flagsOwn, extension);
					object toRead = null;
					r.Serialize(ref toRead, GetType(), name: "clone");
					result = toRead as CSerializable;
				}
			}
			return result;
		}

		public virtual string ClassName => GetType().Name;

		public virtual uint? ClassCRC => null;
	}
}