namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventAddForceBone : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x860BFDD3;
	}
}

