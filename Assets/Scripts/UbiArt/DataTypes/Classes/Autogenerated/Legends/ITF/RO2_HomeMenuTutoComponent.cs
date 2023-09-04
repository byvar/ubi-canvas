namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_HomeMenuTutoComponent : ActorComponent {
		public SmartLocId leaderboardTutoText;
		public Vec2d animOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			leaderboardTutoText = s.SerializeObject<SmartLocId>(leaderboardTutoText, name: "leaderboardTutoText");
			animOffset = s.SerializeObject<Vec2d>(animOffset, name: "animOffset");
		}
		public override uint? ClassCRC => 0xEE4A97EA;
	}
}

