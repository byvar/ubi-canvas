using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt {
	[SerializeEmbed]
	public class Pair<T1, T2> : ICSerializable, IObjectContainer {
		public T1 Item1;
		public T2 Item2;

		public void Serialize(CSerializerObject s, string name) {
			Item1 = s.SerializeGeneric<T1>(Item1, name: name, index: 0);
			Item2 = s.SerializeGeneric<T2>(Item2, name: name, index: 1);
		}
		public Pair() { }
		public Pair(T1 Item1, T2 Item2) {
			this.Item1 = Item1;
			this.Item2 = Item2;
		}
	}
}
