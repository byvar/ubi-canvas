namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventExplorationHealing : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x71352117;
	}
}

