namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventPlayTeleportEndFX : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x22DEC1D5;
	}
}

