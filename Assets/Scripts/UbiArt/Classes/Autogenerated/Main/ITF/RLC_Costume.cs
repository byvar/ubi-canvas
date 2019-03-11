using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_Costume : RLC_InventoryItem {
		[Serialize("state")] public Enum_state state;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(state));
		}
		public enum Enum_state {
			[Serialize("_unknown"         )] _unknown = 0,
			[Serialize("Locked"           )] Locked = 1,
			[Serialize("NotOwned"         )] NotOwned = 2,
			[Serialize("Owned"            )] Owned = 3,
			[Serialize("LockedFacebook"   )] LockedFacebook = 4,
			[Serialize("LockedStoreBundle")] LockedStoreBundle = 5,
		}
		public override uint? ClassCRC => 0xCE3ED480;
	}
}

