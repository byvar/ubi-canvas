using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_ElixirPack : RLC_DynamicStoreItem {
		[Serialize("Type"         )] public Enum_Type Type;
		[Serialize("Price"        )] public uint Price;
		[Serialize("Amount"       )] public uint Amount;
		[Serialize("AllElixirPack")] public bool AllElixirPack;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Type));
			SerializeField(s, nameof(Price));
			SerializeField(s, nameof(Amount));
			SerializeField(s, nameof(AllElixirPack));
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

