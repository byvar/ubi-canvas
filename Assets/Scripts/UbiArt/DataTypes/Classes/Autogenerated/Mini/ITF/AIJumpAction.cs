namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class AIJumpAction : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xF84875DB;
	}
}

