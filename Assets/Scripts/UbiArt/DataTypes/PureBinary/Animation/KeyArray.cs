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

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (keys == null && keysLegends != null) {
				keys = new CArrayP<ulong>();
				foreach (var k in keysLegends) {
					keys.Add(k?.stringID ?? 0xFFFFFFFF);
				}
			} else if (keysLegends == null && keys != null) {
				keysLegends = new CArrayO<StringID>();
				foreach (var k in keys) {
					keysLegends.Add(new StringID((uint)k));
				}
			}
		}
	}
}
