namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class Label_evt : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xEECC3C27;
	}
}

