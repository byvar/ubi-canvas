namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class EventOnLink : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x5CE1179C;
	}
}

