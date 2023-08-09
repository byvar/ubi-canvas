namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_MazeRoomComponent_Template : ActorComponent_Template {
		public float fadeInFactor = 0.1f;
		public float fadeOutFactor = 0.1f;
		public float portalTime = 2f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			fadeInFactor = s.Serialize<float>(fadeInFactor, name: "fadeInFactor");
			fadeOutFactor = s.Serialize<float>(fadeOutFactor, name: "fadeOutFactor");
			portalTime = s.Serialize<float>(portalTime, name: "portalTime");
		}
		public override uint? ClassCRC => 0xE953E8F1;
	}
}

