using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	public class KeyArray<T> : CSerializable {
		[Serialize("keys"  )] public CArray<ulong> keys;
		[Serialize("keys"  )] public CArray<StringID> keysLegends;
		[Serialize("values")] public CArray<T> values;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RA) {
				SerializeField(s, nameof(keys));
			} else {
				SerializeField(s, nameof(keysLegends));
			}
			SerializeField(s, nameof(values));
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
