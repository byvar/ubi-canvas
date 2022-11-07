namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_WM_BonusLevelSpotComponent : Ray_WM_LevelSpotComponent {
		public Vec2d bubbleOffset;
		public float bubbleZOffset;
		public Placeholder blockedLines;
		public Placeholder openLines;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bubbleOffset = s.SerializeObject<Vec2d>(bubbleOffset, name: "bubbleOffset");
			bubbleZOffset = s.Serialize<float>(bubbleZOffset, name: "bubbleZOffset");
			blockedLines = s.SerializeObject<Placeholder>(blockedLines, name: "blockedLines");
			openLines = s.SerializeObject<Placeholder>(openLines, name: "openLines");
		}
		public override uint? ClassCRC => 0xEE1270D6;
	}
}

