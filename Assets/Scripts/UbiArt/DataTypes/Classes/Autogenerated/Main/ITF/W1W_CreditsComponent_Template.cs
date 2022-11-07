namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_CreditsComponent_Template : CreditsComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x4327151B;
	}
}

