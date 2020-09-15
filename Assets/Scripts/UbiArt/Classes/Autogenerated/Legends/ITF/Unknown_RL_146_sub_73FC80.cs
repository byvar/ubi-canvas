using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_146_sub_73FC80 : CSerializable {
		[Serialize("useSwitchChallenge")] public int useSwitchChallenge;
		[Serialize("blockerOffset"     )] public Vec2d blockerOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(useSwitchChallenge));
			SerializeField(s, nameof(blockerOffset));
		}
		public override uint? ClassCRC => 0x0A5EC37B;
	}
}

