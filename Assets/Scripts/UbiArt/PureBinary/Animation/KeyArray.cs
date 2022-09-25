using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	public class KeyArray<T> : CSerializable {
		public CArrayP<ulong> keys;
		public CArrayO<StringID> keysLegends;
		public CArray<T> values;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RA || s.Settings.game == Settings.Game.RM) {
				keys = s.SerializeObject<CArrayP<ulong>>(keys, name: "keys");
			} else {
				keysLegends = s.SerializeObject<CArrayO<StringID>>(keysLegends, name: "keysLegends");
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
