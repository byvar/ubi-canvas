using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionPrisonerTorture_Template : BTAction_Template {
		[Serialize("animPrisonerJumpOnVictim"        )] public StringID animPrisonerJumpOnVictim;
		[Serialize("animPrisonerJumpOnVictimLaugh"   )] public StringID animPrisonerJumpOnVictimLaugh;
		[Serialize("animFreeJumpOnVictim"            )] public StringID animFreeJumpOnVictim;
		[Serialize("animPrisonerHitHeadOnGround"     )] public StringID animPrisonerHitHeadOnGround;
		[Serialize("animPrisonerHitHeadOnGroundLaugh")] public StringID animPrisonerHitHeadOnGroundLaugh;
		[Serialize("animFreeHitHeadOnGround"         )] public StringID animFreeHitHeadOnGround;
		[Serialize("animThank"                       )] public StringID animThank;
		[Serialize("animFreeFall"                    )] public StringID animFreeFall;
		[Serialize("countLumsReward"                 )] public uint countLumsReward;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animPrisonerJumpOnVictim));
			SerializeField(s, nameof(animPrisonerJumpOnVictimLaugh));
			SerializeField(s, nameof(animFreeJumpOnVictim));
			SerializeField(s, nameof(animPrisonerHitHeadOnGround));
			SerializeField(s, nameof(animPrisonerHitHeadOnGroundLaugh));
			SerializeField(s, nameof(animFreeHitHeadOnGround));
			SerializeField(s, nameof(animThank));
			SerializeField(s, nameof(animFreeFall));
			SerializeField(s, nameof(countLumsReward));
		}
		public override uint? ClassCRC => 0x9087AE40;
	}
}

