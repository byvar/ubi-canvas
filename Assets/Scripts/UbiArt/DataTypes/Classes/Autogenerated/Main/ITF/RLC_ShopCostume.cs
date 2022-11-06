using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_ShopCostume : RLC_DynamicStoreItem {
		public StringID Id;
		public Enum_State State;
		public uint Price;
		public Enum_costumeType costumeType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Id = s.SerializeObject<StringID>(Id, name: "Id");
			State = s.Serialize<Enum_State>(State, name: "State");
			Price = s.Serialize<uint>(Price, name: "Price");
			costumeType = s.Serialize<Enum_costumeType>(costumeType, name: "costumeType");
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

