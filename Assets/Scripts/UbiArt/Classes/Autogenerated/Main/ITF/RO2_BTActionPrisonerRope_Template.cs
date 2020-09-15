using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionPrisonerRope_Template : BTAction_Template {
		[Serialize("animPrisoner"   )] public StringID animPrisoner;
		[Serialize("animFree"       )] public StringID animFree;
		[Serialize("animThank"      )] public StringID animThank;
		[Serialize("animFreeFall"   )] public StringID animFreeFall;
		[Serialize("speedMultiplier")] public float speedMultiplier;
		[Serialize("forceSinus"     )] public Vec2d forceSinus;
		[Serialize("freqSinus"      )] public float freqSinus;
		[Serialize("countLumsReward")] public uint countLumsReward;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animPrisoner));
			SerializeField(s, nameof(animFree));
			SerializeField(s, nameof(animThank));
			SerializeField(s, nameof(animFreeFall));
			SerializeField(s, nameof(speedMultiplier));
			SerializeField(s, nameof(forceSinus));
			SerializeField(s, nameof(freqSinus));
			SerializeField(s, nameof(countLumsReward));
		}
		public override uint? ClassCRC => 0x38EC6B84;
	}
}

