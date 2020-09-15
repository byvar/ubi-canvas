using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_421_sub_B3F8D0 : CSerializable {
		public Placeholder leaderboardTutoText;
		public Vec2d animOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			leaderboardTutoText = s.SerializeObject<Placeholder>(leaderboardTutoText, name: "leaderboardTutoText");
			animOffset = s.SerializeObject<Vec2d>(animOffset, name: "animOffset");
		}
		public override uint? ClassCRC => 0xEE4A97EA;
	}
}

