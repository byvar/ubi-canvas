namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Freddie : W1W_Emile {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x7CEDC949;
	}
}

