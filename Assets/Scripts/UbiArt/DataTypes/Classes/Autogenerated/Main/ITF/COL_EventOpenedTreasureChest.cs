namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventOpenedTreasureChest : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xDF844A85;
	}
}

