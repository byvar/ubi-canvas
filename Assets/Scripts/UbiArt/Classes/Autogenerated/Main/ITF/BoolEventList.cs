using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
	public partial class BoolEventList : CSerializable {
		public CListO<BoolEventList.BoolEvent> Keys;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Keys = s.SerializeObject<CListO<BoolEventList.BoolEvent>>(Keys, name: "Keys");
		}
		[Games(GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
		public partial class BoolEvent : CSerializable {
			public bool value;
			public int Frame;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				value = s.Serialize<bool>(value, name: "value");
				Frame = s.Serialize<int>(Frame, name: "Frame");
			}
		}
	}
}

