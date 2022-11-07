namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventStartStationaryFly : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xC47C6D4C;
	}
}

