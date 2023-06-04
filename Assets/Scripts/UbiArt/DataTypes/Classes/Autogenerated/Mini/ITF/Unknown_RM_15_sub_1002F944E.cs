namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class EventCrossPromotion : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xA68BEC15;
	}
}

