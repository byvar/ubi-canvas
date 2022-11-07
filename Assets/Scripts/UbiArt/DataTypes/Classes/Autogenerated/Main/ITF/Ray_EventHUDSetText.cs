namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_EventHUDSetText : Event {
		public string friendlyName;
		public string text;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			friendlyName = s.Serialize<string>(friendlyName, name: "friendlyName");
			text = s.Serialize<string>(text, name: "text");
		}
		public override uint? ClassCRC => 0x4FE65042;
	}
}

