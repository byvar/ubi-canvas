namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_UIProgressBar : CSerializable {
		public float barHeight;
		public float barWidth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				barHeight = s.Serialize<float>(barHeight, name: "barHeight");
				barWidth = s.Serialize<float>(barWidth, name: "barWidth");
			}
		}
		public override uint? ClassCRC => 0x11D4CEB0;
	}
}

