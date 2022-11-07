namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_ElixirPack : RLC_DynamicStoreItem {
		public Enum_Type Type;
		public uint Price;
		public uint Amount;
		public bool AllElixirPack;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Type = s.Serialize<Enum_Type>(Type, name: "Type");
			Price = s.Serialize<uint>(Price, name: "Price");
			Amount = s.Serialize<uint>(Amount, name: "Amount");
			AllElixirPack = s.Serialize<bool>(AllElixirPack, name: "AllElixirPack");
		}
		public enum Enum_Type {
			[Serialize("_unknown"         )] _unknown = 0,
			[Serialize("SpeedHatching"    )] SpeedHatching = 1,
			[Serialize("UpgradeToUncommon")] UpgradeToUncommon = 2,
			[Serialize("UpgradeToRare"    )] UpgradeToRare = 3,
			[Serialize("ForceNewCreature" )] ForceNewCreature = 4,
			[Serialize("HatchNow"         )] HatchNow = 5,
		}
		public override uint? ClassCRC => 0x053C2531;
	}
}

