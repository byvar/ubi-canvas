namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_FeedbackTextBox_Template : CSerializable {
		public Vec2d spawnPosOffset;
		public float timeBeforeShown;
		public float displayTime;
		public float fadeTime;
		public float travelDistance;
		public float scaleMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			spawnPosOffset = s.SerializeObject<Vec2d>(spawnPosOffset, name: "spawnPosOffset");
			timeBeforeShown = s.Serialize<float>(timeBeforeShown, name: "timeBeforeShown");
			displayTime = s.Serialize<float>(displayTime, name: "displayTime");
			fadeTime = s.Serialize<float>(fadeTime, name: "fadeTime");
			travelDistance = s.Serialize<float>(travelDistance, name: "travelDistance");
			scaleMultiplier = s.Serialize<float>(scaleMultiplier, name: "scaleMultiplier");
		}
		public override uint? ClassCRC => 0xACD14A7A;
	}
}

