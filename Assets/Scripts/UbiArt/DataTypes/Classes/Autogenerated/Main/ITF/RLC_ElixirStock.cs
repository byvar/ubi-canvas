namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_ElixirStock : RLC_InventoryItem {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xB83941D9;
	}
}

