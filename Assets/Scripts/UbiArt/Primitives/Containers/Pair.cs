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
			s.Serialize(this, GetType().GetField(nameof(Item1)), name: name, index: 0);
			s.Serialize(this, GetType().GetField(nameof(Item2)), name: name, index: 1);
		}
	}
}
