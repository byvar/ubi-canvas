namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_Costume : RLC_InventoryItem {
		public Enum_state state;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			state = s.Serialize<Enum_state>(state, name: "state");
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

