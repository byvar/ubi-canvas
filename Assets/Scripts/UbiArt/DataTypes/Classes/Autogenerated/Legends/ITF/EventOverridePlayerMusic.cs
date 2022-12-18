namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion)]
	public partial class EventOverridePlayerMusic : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x5F92A481;
	}
}

