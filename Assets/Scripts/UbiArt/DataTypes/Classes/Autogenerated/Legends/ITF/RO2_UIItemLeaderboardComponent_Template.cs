namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_UIItemLeaderboardComponent_Template : CSerializable {
		public Color colorFactorSelected;
		public Color colorFactorUnselected;
		public float medalColorAlphaFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			colorFactorSelected = s.SerializeObject<Color>(colorFactorSelected, name: "colorFactorSelected");
			colorFactorUnselected = s.SerializeObject<Color>(colorFactorUnselected, name: "colorFactorUnselected");
			medalColorAlphaFactor = s.Serialize<float>(medalColorAlphaFactor, name: "medalColorAlphaFactor");
		}
		public override uint? ClassCRC => 0xD6DA9C05;
	}
}

