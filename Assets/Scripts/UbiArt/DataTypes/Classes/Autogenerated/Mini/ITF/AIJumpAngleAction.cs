namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class AIJumpAngleAction : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xEC456170;
	}
}

