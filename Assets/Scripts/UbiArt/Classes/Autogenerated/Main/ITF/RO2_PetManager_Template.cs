using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PetManager_Template : TemplateObj {
		[Serialize("RewardFullUnlock")] public uint RewardFullUnlock;
		[Serialize("petPath"         )] public Path petPath;
		[Serialize("petModels"       )] public CList<RO2_PetModel> petModels;
		[Serialize("familyTags"      )] public Placeholder familyTags;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(RewardFullUnlock));
				SerializeField(s, nameof(petPath));
				SerializeField(s, nameof(petModels));
				SerializeField(s, nameof(familyTags));
			} else {
				SerializeField(s, nameof(RewardFullUnlock));
				SerializeField(s, nameof(petPath));
				SerializeField(s, nameof(petModels));
			}
		}
		public override uint? ClassCRC => 0x9F93CAF6;
	}
}

