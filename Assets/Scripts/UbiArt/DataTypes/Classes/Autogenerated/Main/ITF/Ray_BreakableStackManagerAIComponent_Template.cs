namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_BreakableStackManagerAIComponent_Template : Ray_AIComponent_Template {
		public float timeShakeBeforeFall;
		public float countDownHit;
		public float gravityBallistics;
		public float timeExpulse;
		public Path atlasPath;
		public Path atlasParticlesPath;
		public float edgeSize;
		public uint faction2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			timeShakeBeforeFall = s.Serialize<float>(timeShakeBeforeFall, name: "timeShakeBeforeFall");
			countDownHit = s.Serialize<float>(countDownHit, name: "countDownHit");
			gravityBallistics = s.Serialize<float>(gravityBallistics, name: "gravityBallistics");
			timeExpulse = s.Serialize<float>(timeExpulse, name: "timeExpulse");
			atlasPath = s.SerializeObject<Path>(atlasPath, name: "atlasPath");
			atlasParticlesPath = s.SerializeObject<Path>(atlasParticlesPath, name: "atlasParticlesPath");
			edgeSize = s.Serialize<float>(edgeSize, name: "edgeSize");
			faction2 = s.Serialize<uint>(faction2, name: "faction");
		}
		public override uint? ClassCRC => 0x964A0D32;
	}
}

