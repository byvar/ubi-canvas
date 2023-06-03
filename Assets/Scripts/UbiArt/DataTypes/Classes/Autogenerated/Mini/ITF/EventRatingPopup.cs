namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class EventRatingPopup : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xCEA4ABF5;
	}
}

