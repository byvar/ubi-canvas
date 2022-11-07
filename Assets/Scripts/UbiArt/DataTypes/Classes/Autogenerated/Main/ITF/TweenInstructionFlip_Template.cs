namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class TweenInstructionFlip_Template : TweenInstruction_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x608702CF;
	}
}

