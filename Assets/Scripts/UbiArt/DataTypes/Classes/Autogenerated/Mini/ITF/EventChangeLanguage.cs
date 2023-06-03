namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class EventChangeLanguage : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xB6C52B67;
	}
}

