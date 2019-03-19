using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_TargetingComponent_Template : ActorComponent_Template {
		[Serialize("predictionFactor"       )] public float predictionFactor;
		[Serialize("useMove"                )] public bool useMove;
		[Serialize("useOrientation"         )] public bool useOrientation;
		[Serialize("maxAngularSpeed"        )] public float maxAngularSpeed;
		[Serialize("minAngle"               )] public Angle minAngle;
		[Serialize("maxAngle"               )] public Angle maxAngle;
		[Serialize("initAngle"              )] public Angle initAngle;
		[Serialize("targetSpeedSmoothFactor")] public float targetSpeedSmoothFactor;
		[Serialize("stiffness"              )] public float stiffness;
		[Serialize("damping"                )] public float damping;
		[Serialize("angularStiffness"       )] public float angularStiffness;
		[Serialize("angularDamping"         )] public float angularDamping;
		[Serialize("activationShape"        )] public Generic<PhysShape> activationShape;
		[Serialize("shape"                  )] public Generic<PhysShape> shape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(predictionFactor));
			SerializeField(s, nameof(useMove));
			SerializeField(s, nameof(useOrientation));
			SerializeField(s, nameof(maxAngularSpeed));
			SerializeField(s, nameof(minAngle));
			SerializeField(s, nameof(maxAngle));
			SerializeField(s, nameof(initAngle));
			SerializeField(s, nameof(targetSpeedSmoothFactor));
			SerializeField(s, nameof(stiffness));
			SerializeField(s, nameof(damping));
			SerializeField(s, nameof(angularStiffness));
			SerializeField(s, nameof(angularDamping));
			SerializeField(s, nameof(activationShape));
			SerializeField(s, nameof(shape));
		}
		public override uint? ClassCRC => 0xFF96CF09;
	}
}

