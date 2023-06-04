namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class EventPromotionPopUp : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x5C773328;
	}
}

