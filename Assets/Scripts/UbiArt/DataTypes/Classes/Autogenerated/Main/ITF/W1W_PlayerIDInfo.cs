namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_PlayerIDInfo : PlayerIDInfo {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x9062282C;
	}
}

