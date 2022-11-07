namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_MGlassStock : RLC_InventoryItem {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xBFA41642;
	}
}

