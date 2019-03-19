using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SnakeShooterBodyPart_Template : RO2_SnakeBodyPartSimple_Template {
		[Serialize("health"                )] public int health;
		[Serialize("damageLevels"          )] public CList<uint> damageLevels;
		[Serialize("reward"                )] public Generic<RO2_EventSpawnReward> reward;
		[Serialize("ejectOnDeath"          )] public bool ejectOnDeath;
		[Serialize("ejectMinStartSpeed"    )] public Vector3 ejectMinStartSpeed;
		[Serialize("ejectMaxStartSpeed"    )] public Vector3 ejectMaxStartSpeed;
		[Serialize("ejectzMinSpeed"        )] public float ejectzMinSpeed;
		[Serialize("ejectzAcceleration"    )] public float ejectzAcceleration;
		[Serialize("ejectGravityMultiplier")] public float ejectGravityMultiplier;
		[Serialize("ejectDuration"         )] public float ejectDuration;
		[Serialize("ejectzForced"          )] public int ejectzForced;
		[Serialize("ejectRotationSpeed"    )] public float ejectRotationSpeed;
		[Serialize("ejectFixedEjectDir"    )] public Vector2 ejectFixedEjectDir;
		[Serialize("ejectFadeDuration"     )] public float ejectFadeDuration;
		[Serialize("ejectDelayBeforeFade"  )] public float ejectDelayBeforeFade;
		[Serialize("animTickle"            )] public StringID animTickle;
		[Serialize("animStand"             )] public StringID animStand;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(health));
			SerializeField(s, nameof(damageLevels));
			SerializeField(s, nameof(reward));
			SerializeField(s, nameof(ejectOnDeath));
			SerializeField(s, nameof(ejectMinStartSpeed));
			SerializeField(s, nameof(ejectMaxStartSpeed));
			SerializeField(s, nameof(ejectzMinSpeed));
			SerializeField(s, nameof(ejectzAcceleration));
			SerializeField(s, nameof(ejectGravityMultiplier));
			SerializeField(s, nameof(ejectDuration));
			SerializeField(s, nameof(ejectzForced));
			SerializeField(s, nameof(ejectRotationSpeed));
			SerializeField(s, nameof(ejectFixedEjectDir));
			SerializeField(s, nameof(ejectFadeDuration));
			SerializeField(s, nameof(ejectDelayBeforeFade));
			SerializeField(s, nameof(animTickle));
			SerializeField(s, nameof(animStand));
		}
		public override uint? ClassCRC => 0xBA577FF1;
	}
}

