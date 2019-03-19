using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_DispenserComponent : ActorComponent {
		[Serialize("goodsRemaining")] public uint goodsRemaining;
		[Serialize("state"         )] public Enum_RFR_0 state;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(goodsRemaining));
				SerializeField(s, nameof(state));
			}
		}
		public enum Enum_RFR_0 {
		}
		public override uint? ClassCRC => 0xA474CEE4;
	}
}

