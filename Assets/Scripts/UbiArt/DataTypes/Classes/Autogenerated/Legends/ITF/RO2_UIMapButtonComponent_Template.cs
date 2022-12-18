namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_UIMapButtonComponent_Template : CSerializable {
		public float activeAlpha;
		public float inactiveAlpha;
		public Color inactiveColor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			activeAlpha = s.Serialize<float>(activeAlpha, name: "activeAlpha");
			inactiveAlpha = s.Serialize<float>(inactiveAlpha, name: "inactiveAlpha");
			inactiveColor = s.SerializeObject<Color>(inactiveColor, name: "inactiveColor");
		}
		public override uint? ClassCRC => 0x899DFBCB;
	}
}

