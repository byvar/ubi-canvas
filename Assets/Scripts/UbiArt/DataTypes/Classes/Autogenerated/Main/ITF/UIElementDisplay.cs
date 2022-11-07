namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class UIElementDisplay : Event {
		public StringID elementName;
		public bool display;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			elementName = s.SerializeObject<StringID>(elementName, name: "elementName");
			display = s.Serialize<bool>(display, name: "display");
		}
		public override uint? ClassCRC => 0x3251B708;
	}
}

