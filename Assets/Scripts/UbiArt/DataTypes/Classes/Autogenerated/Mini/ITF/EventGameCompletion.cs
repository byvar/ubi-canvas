namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class EventGameCompletion : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x2BC6AE2D;
	}
}

