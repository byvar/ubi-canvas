using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt {
	public class CSerializable : ICSerializable {
		[Serialize("sizeof")] public uint sizeOf;

		public void Serialize(CSerializerObject s, string name) {
			OnPreSerialize(s);
			SerializeImpl(s);
			OnPostSerialize(s);
		}

		protected virtual void OnPreSerialize(CSerializerObject s) {}
		protected virtual void OnPostSerialize(CSerializerObject s) {}
		protected virtual void SerializeImpl(CSerializerObject s) {
			if (s.HasFlags(SerializeFlags.StoreObjectSizes)) {
				SerializeField(s, nameof(sizeOf));
			}
		}

		protected void SerializeField(CSerializerObject s, string fieldName, Type type = null, bool boolAsByte = false) {
			FieldInfo f = GetType().GetField(fieldName);
			SerializeAttribute[] atts = (SerializeAttribute[])f.GetCustomAttributes(typeof(SerializeAttribute), false);
			if (atts.Length != 0) {
				if (boolAsByte && s.HasFlags(SerializeFlags.Flags1) && f.FieldType == typeof(bool)) {
					type = typeof(byte);
				}
				s.Serialize(this, f, atts[0], type: type);
			}
		}

		protected void SerializeFieldAsChoiceList(CSerializerObject s, string fieldName, string empty = null, List<Tuple<string, StringID>> choices = null) {
			FieldInfo f = GetType().GetField(fieldName);
			SerializeAttribute[] atts = (SerializeAttribute[])f.GetCustomAttributes(typeof(SerializeAttribute), false);
			if (atts.Length != 0) {
				s.Serialize(this, f, atts[0]);
			}
		}

		public virtual uint? ClassCRC => null;
	}
}