using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_TeleportWithAnimationComponent_Template : ActorComponent_Template {
		public StringID animBoss;
		public StringID animPlayer;
		public StringID aspirePoint;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animBoss = s.SerializeObject<StringID>(animBoss, name: "animBoss");
			animPlayer = s.SerializeObject<StringID>(animPlayer, name: "animPlayer");
			aspirePoint = s.SerializeObject<StringID>(aspirePoint, name: "aspirePoint");
		}
		public override uint? ClassCRC => 0x4F9BF50C;
	}
}

