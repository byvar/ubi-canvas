namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class AIBallisticsApexAction : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x0C991228;
	}
}

