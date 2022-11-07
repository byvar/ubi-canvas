namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Karl : W1W_Emile {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xE31B18D4;
	}
}

