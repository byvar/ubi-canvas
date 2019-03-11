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

		protected void SerializeField(CSerializerObject s, string fieldName, Type type = null) {
			FieldInfo f = GetType().GetField(fieldName);
			SerializeAttribute[] atts = (SerializeAttribute[])f.GetCustomAttributes(typeof(SerializeAttribute), false);
			if (atts.Length != 0) {
				s.Serialize(this, f, atts[0], type: type);
			}
		}

		public virtual uint? ClassCRC => null;
	}
}