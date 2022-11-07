namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Rose : W1W_Emile {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xA176BD51;
	}
}

