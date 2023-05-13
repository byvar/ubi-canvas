namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_PetManager_Template : TemplateObj {
		public uint RewardFullUnlock;
		public Path petPath;
		public CListO<RO2_PetModel> petModels;
		public CListO<StringID> familyTags;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				RewardFullUnlock = s.Serialize<uint>(RewardFullUnlock, name: "RewardFullUnlock");
				petPath = s.SerializeObject<Path>(petPath, name: "petPath");
				petModels = s.SerializeObject<CListO<RO2_PetModel>>(petModels, name: "petModels");
				familyTags = s.SerializeObject<CListO<StringID>>(familyTags, name: "familyTags");
			} else {
				RewardFullUnlock = s.Serialize<uint>(RewardFullUnlock, name: "RewardFullUnlock");
				petPath = s.SerializeObject<Path>(petPath, name: "petPath");
				petModels = s.SerializeObject<CListO<RO2_PetModel>>(petModels, name: "petModels");
			}
		}
		public override uint? ClassCRC => 0x9F93CAF6;
	}
}

