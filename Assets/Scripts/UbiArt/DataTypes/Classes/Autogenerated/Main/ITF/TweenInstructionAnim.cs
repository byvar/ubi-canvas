namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class TweenInstructionAnim : TweenInstruction {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x62831525;
	}
}

