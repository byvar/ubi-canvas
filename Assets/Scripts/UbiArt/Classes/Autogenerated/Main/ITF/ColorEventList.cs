using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class ColorEventList : CSerializable {
		public CListO<ColorEventList.ColorEvent> Keys;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Keys = s.SerializeObject<CListO<ColorEventList.ColorEvent>>(Keys, name: "Keys");
		}
		[Games(GameFlags.RA)]
		public partial class ColorEvent : CSerializable {
			public uint value;
			public int Frame;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				value = s.Serialize<uint>(value, name: "value");
				Frame = s.Serialize<int>(Frame, name: "Frame");
			}
		}
	}
}

