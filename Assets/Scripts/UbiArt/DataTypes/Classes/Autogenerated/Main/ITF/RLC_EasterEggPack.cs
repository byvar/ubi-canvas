namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_EasterEggPack : RLC_VirtualCurrencyPack {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xE17DD539;
	}
}

