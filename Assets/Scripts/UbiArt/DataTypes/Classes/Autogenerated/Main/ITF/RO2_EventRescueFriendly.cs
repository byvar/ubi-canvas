namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventRescueFriendly : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xD0C8CC96;
	}
}

