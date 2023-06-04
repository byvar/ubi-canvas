namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class AIJumpInDirAction : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x819F0EF5;
	}
}

