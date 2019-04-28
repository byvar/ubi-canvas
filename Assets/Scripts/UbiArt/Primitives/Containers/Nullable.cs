using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt {
	[SerializeEmbed]
	public class Nullable<T> : ICSerializable, IObjectContainer {
		[Serialize("read")] public bool read;
		public T value;

		public void Serialize(CSerializerObject s, string name) {
			s.Serialize(this, GetType().GetField(nameof(read)), 
				(SerializeAttribute)GetType().GetField(nameof(read)).GetCustomAttributes(typeof(SerializeAttribute), false).First());
			if (read) {
				s.Serialize(this, GetType().GetField(nameof(value)), name: name);
			}
		}

		public bool IsNull => !read;
	}
}
