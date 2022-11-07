namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class NameGeneratorConfig_Template : TemplateObj {
		public float ColorProbability;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ColorProbability = s.Serialize<float>(ColorProbability, name: "ColorProbability");
		}
		public override uint? ClassCRC => 0xB051357D;
	}
}

