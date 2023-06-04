namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class EventControllerPlugin : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x0F555CD6;
	}
}

