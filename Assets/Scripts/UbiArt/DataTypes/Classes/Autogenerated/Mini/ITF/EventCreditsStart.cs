namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class EventCreditsStart : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xEC9D729D;
	}
}

