namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RO2_AIFollowBezierCurveAction : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xFC38BAD0;
	}
}

