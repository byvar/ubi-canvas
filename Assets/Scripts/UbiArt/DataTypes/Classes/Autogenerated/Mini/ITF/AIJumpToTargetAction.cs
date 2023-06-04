namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class AIJumpToTargetAction : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x4D28A2E5;
	}
}

