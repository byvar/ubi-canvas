namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class DestructibleBodyPart_Template : BodyPart_Template {
		public int ejectOnDeath;
		public Vec3d ejectMinStartSpeed;
		public Vec3d ejectMaxStartSpeed;
		public float ejectzMinSpeed;
		public float ejectzAcceleration;
		public float ejectGravityMultiplier;
		public float ejectDuration;
		public int ejectzForced;
		public float ejectRotationSpeed;
		public Vec2d ejectFixedEjectDir;
		public float ejectFadeDuration;
		public float ejectDelayBeforeFade;
		public Generic<Ray_EventSpawnReward> reward;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ejectOnDeath = s.Serialize<int>(ejectOnDeath, name: "ejectOnDeath");
			ejectMinStartSpeed = s.SerializeObject<Vec3d>(ejectMinStartSpeed, name: "ejectMinStartSpeed");
			ejectMaxStartSpeed = s.SerializeObject<Vec3d>(ejectMaxStartSpeed, name: "ejectMaxStartSpeed");
			ejectzMinSpeed = s.Serialize<float>(ejectzMinSpeed, name: "ejectzMinSpeed");
			ejectzAcceleration = s.Serialize<float>(ejectzAcceleration, name: "ejectzAcceleration");
			ejectGravityMultiplier = s.Serialize<float>(ejectGravityMultiplier, name: "ejectGravityMultiplier");
			ejectDuration = s.Serialize<float>(ejectDuration, name: "ejectDuration");
			ejectzForced = s.Serialize<int>(ejectzForced, name: "ejectzForced");
			ejectRotationSpeed = s.Serialize<float>(ejectRotationSpeed, name: "ejectRotationSpeed");
			ejectFixedEjectDir = s.SerializeObject<Vec2d>(ejectFixedEjectDir, name: "ejectFixedEjectDir");
			ejectFadeDuration = s.Serialize<float>(ejectFadeDuration, name: "ejectFadeDuration");
			ejectDelayBeforeFade = s.Serialize<float>(ejectDelayBeforeFade, name: "ejectDelayBeforeFade");
			reward = s.SerializeObject<Generic<Ray_EventSpawnReward>>(reward, name: "reward");
		}
		public override uint? ClassCRC => 0x62FA0C48;
	}
}

