using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	public class KeyArray<T> : ICSerializable {
		public CArray<ulong> keys;
		public CArray<uint> keysLegends;
		public CArray<T> values;

		public void Serialize(CSerializerObject s, string name) {
			if (Settings.s.game == Settings.Game.RA) {
				s.Serialize(ref keys);
			} else {
				s.Serialize(ref keysLegends);
			}
			s.Serialize(ref values);
		}
	}
}
