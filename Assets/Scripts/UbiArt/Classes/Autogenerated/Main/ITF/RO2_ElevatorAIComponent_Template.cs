using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_ElevatorAIComponent_Template : ActorComponent_Template {
		[Serialize("timeStuckTop"              )] public float timeStuckTop;
		[Serialize("clampForceMin"             )] public float clampForceMin;
		[Serialize("clampForceMax"             )] public float clampForceMax;
		[Serialize("reboundPercentForce"       )] public float reboundPercentForce;
		[Serialize("percentLaunchMonsterAttack")] public float percentLaunchMonsterAttack;
		[Serialize("forceGravity"              )] public float forceGravity;
		[Serialize("forceHitMonster"           )] public float forceHitMonster;
		[Serialize("distanceMax"               )] public float distanceMax;
		[Serialize("forceUpPerHit_Level_0"     )] public float forceUpPerHit_Level_0;
		[Serialize("forceUpPerHit_Level_1"     )] public float forceUpPerHit_Level_1;
		[Serialize("forceUpPerHit_Level_2"     )] public float forceUpPerHit_Level_2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(timeStuckTop));
			SerializeField(s, nameof(clampForceMin));
			SerializeField(s, nameof(clampForceMax));
			SerializeField(s, nameof(reboundPercentForce));
			SerializeField(s, nameof(percentLaunchMonsterAttack));
			SerializeField(s, nameof(forceGravity));
			SerializeField(s, nameof(forceHitMonster));
			SerializeField(s, nameof(distanceMax));
			SerializeField(s, nameof(forceUpPerHit_Level_0));
			SerializeField(s, nameof(forceUpPerHit_Level_1));
			SerializeField(s, nameof(forceUpPerHit_Level_2));
		}
		public override uint? ClassCRC => 0x46708DB9;
	}
}

