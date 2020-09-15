using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PlayerControllerComponent : PlayerControllerComponent {
		[Serialize("trailPath"       )] public Path trailPath;
		[Serialize("reticlePath"     )] public Path reticlePath;
		[Serialize("minePath"        )] public Path minePath;
		[Serialize("projectilePath"  )] public Path projectilePath;
		[Serialize("disableColorRamp")] public bool disableColorRamp;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(trailPath));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(trailPath));
					SerializeField(s, nameof(reticlePath));
					SerializeField(s, nameof(minePath));
					SerializeField(s, nameof(projectilePath));
				}
				SerializeField(s, nameof(disableColorRamp));
			}
		}
		[Games(GameFlags.RA)]
		public partial class StateDeadSoul_Template : CSerializable {
			[Serialize("phantomShape"                 )] public Generic<PhysShape> phantomShape;
			[Serialize("softCollisionRadiusMultiplier")] public float softCollisionRadiusMultiplier;
			[Serialize("ignoreCollisions"             )] public bool ignoreCollisions;
			[Serialize("minLocalSpeed"                )] public float minLocalSpeed;
			[Serialize("maxLocalSpeed"                )] public float maxLocalSpeed;
			[Serialize("maxLocalSpeedWithBoost"       )] public float maxLocalSpeedWithBoost;
			[Serialize("inputInertia"                 )] public float inputInertia;
			[Serialize("camSpeedInfluence"            )] public float camSpeedInfluence;
			[Serialize("ejectFromBorderForce"         )] public float ejectFromBorderForce;
			[Serialize("ejectMargin"                  )] public Vec2d ejectMargin;
			[Serialize("minInputForRotation"          )] public float minInputForRotation;
			[Serialize("maxAngle"                     )] public Angle maxAngle;
			[Serialize("angularSmoothMinSpeed"        )] public float angularSmoothMinSpeed;
			[Serialize("angularSmoothMaxSpeed"        )] public float angularSmoothMaxSpeed;
			[Serialize("angularSmoothMinValue"        )] public float angularSmoothMinValue;
			[Serialize("angularSmoothMaxValue"        )] public float angularSmoothMaxValue;
			[Serialize("useTrail"                     )] public bool useTrail;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(phantomShape));
				SerializeField(s, nameof(softCollisionRadiusMultiplier));
				SerializeField(s, nameof(ignoreCollisions));
				SerializeField(s, nameof(minLocalSpeed));
				SerializeField(s, nameof(maxLocalSpeed));
				SerializeField(s, nameof(maxLocalSpeedWithBoost));
				SerializeField(s, nameof(inputInertia));
				SerializeField(s, nameof(camSpeedInfluence));
				SerializeField(s, nameof(ejectFromBorderForce));
				SerializeField(s, nameof(ejectMargin));
				SerializeField(s, nameof(minInputForRotation));
				SerializeField(s, nameof(maxAngle));
				SerializeField(s, nameof(angularSmoothMinSpeed));
				SerializeField(s, nameof(angularSmoothMaxSpeed));
				SerializeField(s, nameof(angularSmoothMinValue));
				SerializeField(s, nameof(angularSmoothMaxValue));
				SerializeField(s, nameof(useTrail));
			}
		}
		[Games(GameFlags.RA)]
		public partial class StateRevive_Template : CSerializable {
			[Serialize("duration"           )] public float duration;
			[Serialize("bezierHitMultiplier")] public float bezierHitMultiplier;
			[Serialize("bezierMidRadius"    )] public float bezierMidRadius;
			[Serialize("bezierMidInfluence" )] public float bezierMidInfluence;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(duration));
				SerializeField(s, nameof(bezierHitMultiplier));
				SerializeField(s, nameof(bezierMidRadius));
				SerializeField(s, nameof(bezierMidInfluence));
			}
		}
		public override uint? ClassCRC => 0x74D86EDB;
	}
}

