namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventPlayerControllerChangeState : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x4FC019EE;
	}
}

