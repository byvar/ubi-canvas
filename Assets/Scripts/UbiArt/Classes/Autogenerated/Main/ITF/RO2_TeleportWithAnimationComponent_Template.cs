using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_TeleportWithAnimationComponent_Template : ActorComponent_Template {
		[Serialize("animBoss"   )] public StringID animBoss;
		[Serialize("animPlayer" )] public StringID animPlayer;
		[Serialize("aspirePoint")] public StringID aspirePoint;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animBoss));
			SerializeField(s, nameof(animPlayer));
			SerializeField(s, nameof(aspirePoint));
		}
		public override uint? ClassCRC => 0x4F9BF50C;
	}
}

