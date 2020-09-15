using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt {
	[SerializeEmbed]
	public class Nullable<T> : ICSerializable, IObjectContainer where T : ICSerializable, new() {
		public bool read;
		public T value;

		public void Serialize(CSerializerObject s, string name) {
			read = s.Serialize<bool>(read, name: "read");
			if (read) {
				value = s.SerializeObject<T>(value, name: name);
			}
		}

		public bool IsNull => !read;
	}
}
