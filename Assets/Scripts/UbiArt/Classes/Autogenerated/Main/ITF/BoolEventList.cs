using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RFR | GameFlags.VH)]
	public partial class BoolEventList : CSerializable {
		public CList<BoolEventList.BoolEvent> Keys;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Keys = s.SerializeObject<CList<BoolEventList.BoolEvent>>(Keys, name: "Keys");
		}
		[Games(GameFlags.RA | GameFlags.RFR | GameFlags.VH)]
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

