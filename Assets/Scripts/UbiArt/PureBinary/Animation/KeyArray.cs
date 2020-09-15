using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	public class KeyArray<T> : CSerializable {
		public CArray<ulong> keys;
		public CArray<StringID> keysLegends;
		public CArray<T> values;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RA) {
				keys = s.SerializeObject<CArray<ulong>>(keys, name: "keys");
			} else {
				keysLegends = s.SerializeObject<CArray<StringID>>(keysLegends, name: "keysLegends");
			}
			values = s.SerializeObject<CArray<T>>(values, name: "values");
		}

		public int GetKeyIndex(StringID key) {
			if (keysLegends != null) {
				return keysLegends.IndexOf(key);
			} else {
				return keys.IndexOf(key.stringID);
			}
		}
	}
}
