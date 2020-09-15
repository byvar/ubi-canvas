using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_DispenserComponent : ActorComponent {
		public uint goodsRemaining;
		public Enum_state state;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				goodsRemaining = s.Serialize<uint>(goodsRemaining, name: "goodsRemaining");
				state = s.Serialize<Enum_state>(state, name: "state");
			}
		}
		public enum Enum_state {
		}
		public override uint? ClassCRC => 0x6C6A3432;
	}
}

