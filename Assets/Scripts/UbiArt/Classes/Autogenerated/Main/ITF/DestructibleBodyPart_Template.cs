using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class DestructibleBodyPart_Template : BodyPart_Template {
		[Serialize("ejectOnDeath"          )] public int ejectOnDeath;
		[Serialize("ejectMinStartSpeed"    )] public Vec3d ejectMinStartSpeed;
		[Serialize("ejectMaxStartSpeed"    )] public Vec3d ejectMaxStartSpeed;
		[Serialize("ejectzMinSpeed"        )] public float ejectzMinSpeed;
		[Serialize("ejectzAcceleration"    )] public float ejectzAcceleration;
		[Serialize("ejectGravityMultiplier")] public float ejectGravityMultiplier;
		[Serialize("ejectDuration"         )] public float ejectDuration;
		[Serialize("ejectzForced"          )] public int ejectzForced;
		[Serialize("ejectRotationSpeed"    )] public float ejectRotationSpeed;
		[Serialize("ejectFixedEjectDir"    )] public Vec2d ejectFixedEjectDir;
		[Serialize("ejectFadeDuration"     )] public float ejectFadeDuration;
		[Serialize("ejectDelayBeforeFade"  )] public float ejectDelayBeforeFade;
		[Serialize("reward"                )] public Generic<Ray_EventSpawnReward> reward;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
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
			SerializeField(s, nameof(reward));
		}
		public override uint? ClassCRC => 0x62FA0C48;
	}
}

