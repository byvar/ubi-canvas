namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class StatWriter : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xF1AAFD33;
	}
}

