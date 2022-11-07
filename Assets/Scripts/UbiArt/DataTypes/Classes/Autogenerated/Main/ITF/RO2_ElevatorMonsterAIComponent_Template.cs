namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_ElevatorMonsterAIComponent_Template : ActorComponent_Template {
		public float ratioSpeed;
		public float distanceForHit;
		public float countDownAttack;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ratioSpeed = s.Serialize<float>(ratioSpeed, name: "ratioSpeed");
			distanceForHit = s.Serialize<float>(distanceForHit, name: "distanceForHit");
			countDownAttack = s.Serialize<float>(countDownAttack, name: "countDownAttack");
		}
		public override uint? ClassCRC => 0x5E7A6BA7;
	}
}

