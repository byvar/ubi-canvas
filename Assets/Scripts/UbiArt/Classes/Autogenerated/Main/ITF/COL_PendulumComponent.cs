using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_PendulumComponent : CSerializable {
		[Serialize("phantomHitMultiplier"         )] public float phantomHitMultiplier;
		[Serialize("collisionFilter"              )] public Enum_collisionFilter collisionFilter;
		[Serialize("useFixedLength"               )] public int useFixedLength;
		[Serialize("length"                       )] public float length;
		[Serialize("maxLength"                    )] public float maxLength;
		[Serialize("minLength"                    )] public float minLength;
		[Serialize("shouldLimitAngle"             )] public int shouldLimitAngle;
		[Serialize("minAngle"                     )] public float minAngle;
		[Serialize("maxAngle"                     )] public float maxAngle;
		[Serialize("stiffness"                    )] public float stiffness;
		[Serialize("damping"                      )] public float damping;
		[Serialize("constraintPrecision"          )] public Enum_constraintPrecision constraintPrecision;
		[Serialize("delayBetweenOnHitFx"          )] public float delayBetweenOnHitFx;
		[Serialize("playOnHitForceThreshold"      )] public float playOnHitForceThreshold;
		[Serialize("playOnStartMoveSpeedThreshold")] public float playOnStartMoveSpeedThreshold;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(phantomHitMultiplier));
			SerializeField(s, nameof(collisionFilter));
			SerializeField(s, nameof(useFixedLength));
			SerializeField(s, nameof(length));
			SerializeField(s, nameof(maxLength));
			SerializeField(s, nameof(minLength));
			SerializeField(s, nameof(shouldLimitAngle));
			SerializeField(s, nameof(minAngle));
			SerializeField(s, nameof(maxAngle));
			SerializeField(s, nameof(stiffness));
			SerializeField(s, nameof(damping));
			SerializeField(s, nameof(constraintPrecision));
			SerializeField(s, nameof(delayBetweenOnHitFx));
			SerializeField(s, nameof(playOnHitForceThreshold));
			SerializeField(s, nameof(playOnStartMoveSpeedThreshold));
		}
		public enum Enum_collisionFilter {
			[Serialize("Value_0"        )] Value_0 = 0,
			[Serialize("Value_0xFFFFFFF")] Value_0xFFFFFFF = 0xFFFFFFF,
			[Serialize("Value_4"        )] Value_4 = 4,
			[Serialize("Value_2"        )] Value_2 = 2,
			[Serialize("Value_8"        )] Value_8 = 8,
			[Serialize("Value_16"       )] Value_16 = 16,
		}
		public enum Enum_constraintPrecision {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0xCD580692;
	}
}

