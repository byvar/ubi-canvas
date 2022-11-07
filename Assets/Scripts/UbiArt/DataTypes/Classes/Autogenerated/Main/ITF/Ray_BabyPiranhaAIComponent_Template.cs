namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_BabyPiranhaAIComponent_Template : AIComponent_Template {
		public float speed;
		public float detectionRange;
		public float attackRange;
		public float attackTime;
		public float attackCooldown;
		public float idlePercent;
		public float attackJumpPercent;
		public float attackDivePercent;
		public float idlePerturbation;
		public float attackPerturbation;
		public float attackStartTime;
		public float escapeDst;
		public float escapeTime;
		public uint hitLevel;
		public float bounceMultiplier;
		public int onlyAttackTargetInWater;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			speed = s.Serialize<float>(speed, name: "speed");
			detectionRange = s.Serialize<float>(detectionRange, name: "detectionRange");
			attackRange = s.Serialize<float>(attackRange, name: "attackRange");
			attackTime = s.Serialize<float>(attackTime, name: "attackTime");
			attackCooldown = s.Serialize<float>(attackCooldown, name: "attackCooldown");
			idlePercent = s.Serialize<float>(idlePercent, name: "idlePercent");
			attackJumpPercent = s.Serialize<float>(attackJumpPercent, name: "attackJumpPercent");
			attackDivePercent = s.Serialize<float>(attackDivePercent, name: "attackDivePercent");
			idlePerturbation = s.Serialize<float>(idlePerturbation, name: "idlePerturbation");
			attackPerturbation = s.Serialize<float>(attackPerturbation, name: "attackPerturbation");
			attackStartTime = s.Serialize<float>(attackStartTime, name: "attackStartTime");
			escapeDst = s.Serialize<float>(escapeDst, name: "escapeDst");
			escapeTime = s.Serialize<float>(escapeTime, name: "escapeTime");
			hitLevel = s.Serialize<uint>(hitLevel, name: "hitLevel");
			bounceMultiplier = s.Serialize<float>(bounceMultiplier, name: "bounceMultiplier");
			onlyAttackTargetInWater = s.Serialize<int>(onlyAttackTargetInWater, name: "onlyAttackTargetInWater");
		}
		public override uint? ClassCRC => 0x8347B90E;
	}
}

