namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_Ghost_Template : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xF73FD073;
	}
}

