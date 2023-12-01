namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_AdversarialModeComponent : ActorComponent {
		public int teamEnabled;
		public uint teamMaxMember;
		public int scoreIsIn3D;
		public Color colorRayman;
		public Color colorGlobox;
		public Color colorTeensy;
		public Color colorTeensyMago;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			teamEnabled = s.Serialize<int>(teamEnabled, name: "teamEnabled");
			teamMaxMember = s.Serialize<uint>(teamMaxMember, name: "teamMaxMember");
			scoreIsIn3D = s.Serialize<int>(scoreIsIn3D, name: "scoreIsIn3D");
			colorRayman = s.SerializeObject<Color>(colorRayman, name: "colorRayman");
			colorGlobox = s.SerializeObject<Color>(colorGlobox, name: "colorGlobox");
			colorTeensy = s.SerializeObject<Color>(colorTeensy, name: "colorTeensy");
			colorTeensyMago = s.SerializeObject<Color>(colorTeensyMago, name: "colorTeensyMago");
		}
		public override uint? ClassCRC => 0x9B8A06A2;
	}
}

