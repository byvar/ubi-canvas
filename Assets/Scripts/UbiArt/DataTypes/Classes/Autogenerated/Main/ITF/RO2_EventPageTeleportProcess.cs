namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventPageTeleportProcess : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x6D3C4B60;
	}
}

