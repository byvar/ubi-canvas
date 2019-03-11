using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_RewardAIComponent_Template : AIComponent_Template {
		[Serialize("idleBehavior"   )] public Placeholder idleBehavior;
		[Serialize("carriedBehavior")] public Placeholder carriedBehavior;
		[Serialize("pickupBehavior" )] public Placeholder pickupBehavior;
		[Serialize("snapBehavior"   )] public Placeholder snapBehavior;
		[Serialize("fallbackReward" )] public Placeholder fallbackReward;
		[Serialize("addHp"          )] public uint addHp;
		[Serialize("addMaxHp"       )] public uint addMaxHp;
		[Serialize("snapFactor"     )] public float snapFactor;
		[Serialize("snapMinDistance")] public float snapMinDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(idleBehavior));
			SerializeField(s, nameof(carriedBehavior));
			SerializeField(s, nameof(pickupBehavior));
			SerializeField(s, nameof(snapBehavior));
			SerializeField(s, nameof(fallbackReward));
			SerializeField(s, nameof(addHp));
			SerializeField(s, nameof(addMaxHp));
			SerializeField(s, nameof(snapFactor));
			SerializeField(s, nameof(snapMinDistance));
		}
		public override uint? ClassCRC => 0x10C2BCF9;
	}
}

