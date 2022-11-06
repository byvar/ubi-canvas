using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionPrisonerTorture_Template : BTAction_Template {
		public StringID animPrisonerJumpOnVictim;
		public StringID animPrisonerJumpOnVictimLaugh;
		public StringID animFreeJumpOnVictim;
		public StringID animPrisonerHitHeadOnGround;
		public StringID animPrisonerHitHeadOnGroundLaugh;
		public StringID animFreeHitHeadOnGround;
		public StringID animThank;
		public StringID animFreeFall;
		public uint countLumsReward;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animPrisonerJumpOnVictim = s.SerializeObject<StringID>(animPrisonerJumpOnVictim, name: "animPrisonerJumpOnVictim");
			animPrisonerJumpOnVictimLaugh = s.SerializeObject<StringID>(animPrisonerJumpOnVictimLaugh, name: "animPrisonerJumpOnVictimLaugh");
			animFreeJumpOnVictim = s.SerializeObject<StringID>(animFreeJumpOnVictim, name: "animFreeJumpOnVictim");
			animPrisonerHitHeadOnGround = s.SerializeObject<StringID>(animPrisonerHitHeadOnGround, name: "animPrisonerHitHeadOnGround");
			animPrisonerHitHeadOnGroundLaugh = s.SerializeObject<StringID>(animPrisonerHitHeadOnGroundLaugh, name: "animPrisonerHitHeadOnGroundLaugh");
			animFreeHitHeadOnGround = s.SerializeObject<StringID>(animFreeHitHeadOnGround, name: "animFreeHitHeadOnGround");
			animThank = s.SerializeObject<StringID>(animThank, name: "animThank");
			animFreeFall = s.SerializeObject<StringID>(animFreeFall, name: "animFreeFall");
			countLumsReward = s.Serialize<uint>(countLumsReward, name: "countLumsReward");
		}
		public override uint? ClassCRC => 0x9087AE40;
	}
}

