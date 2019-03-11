using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_DispenserComponent : ActorComponent {
		[Serialize("goodsRemaining")] public uint goodsRemaining;
		[Serialize("state"         )] public Enum_state state;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(goodsRemaining));
				SerializeField(s, nameof(state));
			}
		}
		public enum Enum_state {
		}
		public override uint? ClassCRC => 0x6C6A3432;
	}
}

