using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_ShopCostume : RLC_DynamicStoreItem {
		[Serialize("Id"         )] public StringID Id;
		[Serialize("State"      )] public Enum_State State;
		[Serialize("Price"      )] public uint Price;
		[Serialize("costumeType")] public Enum_costumeType costumeType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Id));
			SerializeField(s, nameof(State));
			SerializeField(s, nameof(Price));
			SerializeField(s, nameof(costumeType));
		}
		public enum Enum_State {
			[Serialize("_unknown"         )] _unknown = 0,
			[Serialize("Locked"           )] Locked = 1,
			[Serialize("NotOwned"         )] NotOwned = 2,
			[Serialize("Owned"            )] Owned = 3,
			[Serialize("LockedFacebook"   )] LockedFacebook = 4,
			[Serialize("LockedStoreBundle")] LockedStoreBundle = 5,
		}
		public enum Enum_costumeType {
			[Serialize("RAYMAN" )] RAYMAN = 0,
			[Serialize("BARBARA")] BARBARA = 1,
			[Serialize("GLOBOX" )] GLOBOX = 2,
			[Serialize("TEENSY" )] TEENSY = 3,
		}
		public override uint? ClassCRC => 0xF4FCA393;
	}
}

