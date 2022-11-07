namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventFlipActor : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x2805FB10;
	}
}

