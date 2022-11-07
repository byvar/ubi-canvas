namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventQueryIsInInteraction : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x0A6CA674;
	}
}

