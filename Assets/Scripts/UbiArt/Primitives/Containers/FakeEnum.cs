using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt {
	[SerializeEmbed]
	public class FakeEnum<T> : ICSerializable, IObjectContainer {
		public string invalidString;
		public T Item;

		public void Serialize(CSerializerObject s, string name) {
			if (typeof(T) == typeof(LocalisationId)) {
				invalidString = "invalid";
			} else if (typeof(T) == typeof(ObjectRef)) {
				invalidString = "Empty";
			} else if (typeof(T) == typeof(StringID)) {
				invalidString = "Empty";
			}
			Item = s.SerializeGeneric<T>(Item, name: name);
		}

		public static implicit operator FakeEnum<T>(T s) {
			return new FakeEnum<T> { Item = s };
		}
		public static implicit operator T(FakeEnum<T> s) {
			return s.Item;
		}
	}
}
