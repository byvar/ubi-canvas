namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_MusicScoreAIComponent : GraphicComponent {
		public int startOpen;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				startOpen = s.Serialize<int>(startOpen, name: "startOpen");
			}
		}
		public override uint? ClassCRC => 0x42FB0CC5;
	}
}

