namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_GemsStock : RLC_InventoryItem {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xB4DEABBC;
	}
}

