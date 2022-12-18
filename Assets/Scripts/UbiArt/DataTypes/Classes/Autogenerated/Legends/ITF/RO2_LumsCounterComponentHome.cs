namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_LumsCounterComponentHome : ActorComponent {
		public bool IsHelpMenuIcon;
		public Color defaultBackgroundColor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			IsHelpMenuIcon = s.Serialize<bool>(IsHelpMenuIcon, name: "IsHelpMenuIcon");
			defaultBackgroundColor = s.SerializeObject<Color>(defaultBackgroundColor, name: "defaultBackgroundColor");
		}
		public override uint? ClassCRC => 0xE640DE7C;
	}
}

