namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Karl_Template : W1W_Emile_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x484936E9;
	}
}

