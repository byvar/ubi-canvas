using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_JalapenoKingAiComponent_Template : AIComponent_Template {
		[Serialize("idleAnim"      )] public StringID idleAnim;
		[Serialize("hitAnim"       )] public StringID hitAnim;
		[Serialize("receiveHitAnim")] public StringID receiveHitAnim;
		[Serialize("stunAnim"      )] public StringID stunAnim;
		[Serialize("stunAnimLoop"  )] public StringID stunAnimLoop;
		[Serialize("unstunAnim"    )] public StringID unstunAnim;
		[Serialize("stunDuration"  )] public float stunDuration;
		[Serialize("deathReward"   )] public Generic<RO2_EventSpawnReward> deathReward;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(idleAnim));
			SerializeField(s, nameof(hitAnim));
			SerializeField(s, nameof(receiveHitAnim));
			SerializeField(s, nameof(stunAnim));
			SerializeField(s, nameof(stunAnimLoop));
			SerializeField(s, nameof(unstunAnim));
			SerializeField(s, nameof(stunDuration));
			SerializeField(s, nameof(deathReward));
		}
		public override uint? ClassCRC => 0x5661ED7A;
	}
}

