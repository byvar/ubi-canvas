namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RLC_MusicalModeManager_Template : CSerializable {
		public Path musicalModeMainPath;
		public Placeholder subsceneActor_UserFriendly_FX;
		public Placeholder MusicalModeDefinitions;
		public Placeholder modesLocID;
		public StringID medalAnmEmpty;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			musicalModeMainPath = s.SerializeObject<Path>(musicalModeMainPath, name: "musicalModeMainPath");
			subsceneActor_UserFriendly_FX = s.SerializeObject<Placeholder>(subsceneActor_UserFriendly_FX, name: "subsceneActor_UserFriendly_FX");
			MusicalModeDefinitions = s.SerializeObject<Placeholder>(MusicalModeDefinitions, name: "MusicalModeDefinitions");
			modesLocID = s.SerializeObject<Placeholder>(modesLocID, name: "modesLocID");
			medalAnmEmpty = s.SerializeObject<StringID>(medalAnmEmpty, name: "medalAnmEmpty");
		}
		public override uint? ClassCRC => 0x0680A223;
	}
}

