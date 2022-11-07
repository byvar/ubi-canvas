namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_Ghost : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x8D5751EC;
	}
}

