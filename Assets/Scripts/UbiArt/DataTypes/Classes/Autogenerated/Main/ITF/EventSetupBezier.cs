namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.COL)]
	public partial class EventSetupBezier : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x2A8EAB91;
	}
}

