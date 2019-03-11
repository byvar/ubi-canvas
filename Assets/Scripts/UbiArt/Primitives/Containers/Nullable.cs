using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt {
	[SerializeEmbed]
	public struct Nullable<T> : ICSerializable {
		[Serialize("read")] public bool read;
		public T value;

		public void Serialize(CSerializerObject s, string name) {
			s.Serialize(this, GetType().GetField(nameof(read)), 
				(SerializeAttribute)GetType().GetField(nameof(read)).GetCustomAttributes(typeof(SerializeAttribute), false).First());
			if (read) {
				s.Serialize(this, GetType().GetField(nameof(value)), name: name, index: 0);
			}
		}

		public bool IsNull => !read;
	}
}
