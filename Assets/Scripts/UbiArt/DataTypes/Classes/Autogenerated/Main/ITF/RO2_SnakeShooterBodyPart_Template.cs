using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_SnakeShooterBodyPart_Template : RO2_SnakeBodyPartSimple_Template {
		public int health;
		public CListP<uint> damageLevels;
		public Generic<RO2_EventSpawnReward> reward;
		public bool ejectOnDeath;
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
		public StringID animTickle;
		public StringID animStand;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			health = s.Serialize<int>(health, name: "health");
			damageLevels = s.SerializeObject<CListP<uint>>(damageLevels, name: "damageLevels");
			reward = s.SerializeObject<Generic<RO2_EventSpawnReward>>(reward, name: "reward");
			ejectOnDeath = s.Serialize<bool>(ejectOnDeath, name: "ejectOnDeath");
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
			animTickle = s.SerializeObject<StringID>(animTickle, name: "animTickle");
			animStand = s.SerializeObject<StringID>(animStand, name: "animStand");
		}
		public override uint? ClassCRC => 0xBA577FF1;
	}
}

