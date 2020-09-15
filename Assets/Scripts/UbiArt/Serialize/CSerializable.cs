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
		[Serialize("sizeof")] public uint sizeOf;

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
				SerializeField(s, nameof(sizeOf));
			}
		}

		protected void SerializeField(CSerializerObject s, string fieldName, Type type = null, bool boolAsByte = false) {
			//Pointer pos = s.Position;
			FieldInfo f = GetType().GetField(fieldName);
			SerializeAttribute[] atts = (SerializeAttribute[])f.GetCustomAttributes(typeof(SerializeAttribute), false);
			if (atts.Length != 0) {
				if (boolAsByte && s.HasFlags(SerializeFlags.Flags1) && f.FieldType == typeof(bool)) {
					type = typeof(byte);
				}
				//bool isBigObject = isFirstLoad && (typeof(CSerializable).IsAssignableFrom(f.FieldType) || typeof(IObjectContainer).IsAssignableFrom(f.FieldType));
				/*if (isFirstLoad && isBigObject) {
					MapLoader.Loader.Log(s.Position + ":" + new string(' ', (s.Indent + 1) * 2) + "(" + GetType() + ") " + fieldName + ":");
				}*/
				s.Serialize(this, f, atts[0], type: type);
				/*if (isFirstLoad && !isBigObject) {
					MapLoader.Loader.Log(s.Position + ":" + new string(' ', (s.Indent + 1) * 2) + "(" + GetType() + ") " + fieldName + " - " + f.GetValue(this));
				}*/
			}
		}

		protected void SerializeFieldAsChoiceList(CSerializerObject s, string fieldName, string empty = null, List<Tuple<string, StringID>> choices = null) {
			FieldInfo f = GetType().GetField(fieldName);
			SerializeAttribute[] atts = (SerializeAttribute[])f.GetCustomAttributes(typeof(SerializeAttribute), false);
			if (atts.Length != 0) {
				s.Serialize(this, f, atts[0]);
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