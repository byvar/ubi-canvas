namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class CreditsDatum : CSerializable {
		public SmartLocId text;
		public uint style;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			text = s.SerializeObject<SmartLocId>(text, name: "text");
			style = s.Serialize<uint>(style, name: "style");
		}
	}
}

