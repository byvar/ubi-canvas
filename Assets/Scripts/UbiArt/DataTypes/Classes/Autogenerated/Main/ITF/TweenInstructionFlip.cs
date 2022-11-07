namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class TweenInstructionFlip : TweenInstruction {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xB295DE78;
	}
}

