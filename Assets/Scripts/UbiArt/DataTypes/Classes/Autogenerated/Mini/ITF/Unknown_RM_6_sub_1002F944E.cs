namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class EventAfterCameraUpdate : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xDB708200;
	}
}

