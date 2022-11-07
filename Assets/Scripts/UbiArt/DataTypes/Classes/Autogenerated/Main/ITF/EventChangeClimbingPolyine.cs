namespace UbiArt.ITF {
	[Games(GameFlags.COL | GameFlags.RM)]
	public partial class EventChangeClimbingPolyine : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x34A57AD0;
	}
}

