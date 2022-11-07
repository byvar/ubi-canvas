namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class EventTeleportToActor : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x213F08B6;
	}
}

