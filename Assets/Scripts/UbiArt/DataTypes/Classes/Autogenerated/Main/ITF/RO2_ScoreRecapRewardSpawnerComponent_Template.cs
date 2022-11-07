namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_ScoreRecapRewardSpawnerComponent_Template : ActorComponent_Template {
		public Path rewardPath;
		public StringID snapBone;
		public bool debug;
		public StringID showAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			rewardPath = s.SerializeObject<Path>(rewardPath, name: "rewardPath");
			snapBone = s.SerializeObject<StringID>(snapBone, name: "snapBone");
			debug = s.Serialize<bool>(debug, name: "debug");
			showAnim = s.SerializeObject<StringID>(showAnim, name: "showAnim");
		}
		public override uint? ClassCRC => 0xEFECE2BE;
	}
}

