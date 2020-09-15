using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_DispenserComponent : ActorComponent {
		public uint goodsRemaining;
		public Enum_RFR_0 state;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				goodsRemaining = s.Serialize<uint>(goodsRemaining, name: "goodsRemaining");
				state = s.Serialize<Enum_RFR_0>(state, name: "state");
			}
		}
		public enum Enum_RFR_0 {
		}
		public override uint? ClassCRC => 0xA474CEE4;
	}
}

