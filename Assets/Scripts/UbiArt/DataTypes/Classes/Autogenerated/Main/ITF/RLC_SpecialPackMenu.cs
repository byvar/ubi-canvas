namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_SpecialPackMenu : RLC_ShopScrollingMenu {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xC317FBC1;
	}
}

