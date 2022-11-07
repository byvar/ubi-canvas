namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_ElevatorAIComponent_Template : ActorComponent_Template {
		public float timeStuckTop;
		public float clampForceMin;
		public float clampForceMax;
		public float reboundPercentForce;
		public float percentLaunchMonsterAttack;
		public float forceGravity;
		public float forceHitMonster;
		public float distanceMax;
		public float forceUpPerHit_Level_0;
		public float forceUpPerHit_Level_1;
		public float forceUpPerHit_Level_2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			timeStuckTop = s.Serialize<float>(timeStuckTop, name: "timeStuckTop");
			clampForceMin = s.Serialize<float>(clampForceMin, name: "clampForceMin");
			clampForceMax = s.Serialize<float>(clampForceMax, name: "clampForceMax");
			reboundPercentForce = s.Serialize<float>(reboundPercentForce, name: "reboundPercentForce");
			percentLaunchMonsterAttack = s.Serialize<float>(percentLaunchMonsterAttack, name: "percentLaunchMonsterAttack");
			forceGravity = s.Serialize<float>(forceGravity, name: "forceGravity");
			forceHitMonster = s.Serialize<float>(forceHitMonster, name: "forceHitMonster");
			distanceMax = s.Serialize<float>(distanceMax, name: "distanceMax");
			forceUpPerHit_Level_0 = s.Serialize<float>(forceUpPerHit_Level_0, name: "forceUpPerHit_Level_0");
			forceUpPerHit_Level_1 = s.Serialize<float>(forceUpPerHit_Level_1, name: "forceUpPerHit_Level_1");
			forceUpPerHit_Level_2 = s.Serialize<float>(forceUpPerHit_Level_2, name: "forceUpPerHit_Level_2");
		}
		public override uint? ClassCRC => 0x46708DB9;
	}
}

