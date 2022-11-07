namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class EventBossBubonHit : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x3CB045D4;
	}
}

