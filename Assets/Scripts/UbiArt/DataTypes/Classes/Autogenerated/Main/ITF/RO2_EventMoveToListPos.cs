namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventMoveToListPos : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x8568258A;
	}
}

