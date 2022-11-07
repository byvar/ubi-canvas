namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_ScoreLumAIComponent_Template : Ray_FixedAIComponent_Template {
		public Path lumAtlasPath;
		public float framePerSecond;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			lumAtlasPath = s.SerializeObject<Path>(lumAtlasPath, name: "lumAtlasPath");
			framePerSecond = s.Serialize<float>(framePerSecond, name: "framePerSecond");
		}
		public override uint? ClassCRC => 0xDD5B1A63;
	}
}

