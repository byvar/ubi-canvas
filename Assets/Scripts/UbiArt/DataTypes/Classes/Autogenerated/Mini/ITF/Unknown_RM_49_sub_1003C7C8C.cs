namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class AIBezierAction : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x4E6A12E8;
	}
}

