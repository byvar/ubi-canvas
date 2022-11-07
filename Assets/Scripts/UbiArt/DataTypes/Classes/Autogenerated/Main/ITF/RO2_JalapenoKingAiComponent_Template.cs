namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_JalapenoKingAiComponent_Template : AIComponent_Template {
		public StringID idleAnim;
		public StringID hitAnim;
		public StringID receiveHitAnim;
		public StringID stunAnim;
		public StringID stunAnimLoop;
		public StringID unstunAnim;
		public float stunDuration;
		public Generic<RO2_EventSpawnReward> deathReward;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			idleAnim = s.SerializeObject<StringID>(idleAnim, name: "idleAnim");
			hitAnim = s.SerializeObject<StringID>(hitAnim, name: "hitAnim");
			receiveHitAnim = s.SerializeObject<StringID>(receiveHitAnim, name: "receiveHitAnim");
			stunAnim = s.SerializeObject<StringID>(stunAnim, name: "stunAnim");
			stunAnimLoop = s.SerializeObject<StringID>(stunAnimLoop, name: "stunAnimLoop");
			unstunAnim = s.SerializeObject<StringID>(unstunAnim, name: "unstunAnim");
			stunDuration = s.Serialize<float>(stunDuration, name: "stunDuration");
			deathReward = s.SerializeObject<Generic<RO2_EventSpawnReward>>(deathReward, name: "deathReward");
		}
		public override uint? ClassCRC => 0x5661ED7A;
	}
}

