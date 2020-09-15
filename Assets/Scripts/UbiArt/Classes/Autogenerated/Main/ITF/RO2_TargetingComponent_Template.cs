using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_TargetingComponent_Template : ActorComponent_Template {
		public float predictionFactor;
		public bool useMove;
		public bool useOrientation;
		public float maxAngularSpeed;
		public Angle minAngle;
		public Angle maxAngle;
		public Angle initAngle;
		public float targetSpeedSmoothFactor;
		public float stiffness;
		public float damping;
		public float angularStiffness;
		public float angularDamping;
		public Generic<PhysShape> activationShape;
		public Generic<PhysShape> shape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			predictionFactor = s.Serialize<float>(predictionFactor, name: "predictionFactor");
			useMove = s.Serialize<bool>(useMove, name: "useMove");
			useOrientation = s.Serialize<bool>(useOrientation, name: "useOrientation");
			maxAngularSpeed = s.Serialize<float>(maxAngularSpeed, name: "maxAngularSpeed");
			minAngle = s.SerializeObject<Angle>(minAngle, name: "minAngle");
			maxAngle = s.SerializeObject<Angle>(maxAngle, name: "maxAngle");
			initAngle = s.SerializeObject<Angle>(initAngle, name: "initAngle");
			targetSpeedSmoothFactor = s.Serialize<float>(targetSpeedSmoothFactor, name: "targetSpeedSmoothFactor");
			stiffness = s.Serialize<float>(stiffness, name: "stiffness");
			damping = s.Serialize<float>(damping, name: "damping");
			angularStiffness = s.Serialize<float>(angularStiffness, name: "angularStiffness");
			angularDamping = s.Serialize<float>(angularDamping, name: "angularDamping");
			activationShape = s.SerializeObject<Generic<PhysShape>>(activationShape, name: "activationShape");
			shape = s.SerializeObject<Generic<PhysShape>>(shape, name: "shape");
		}
		public override uint? ClassCRC => 0xFF96CF09;
	}
}

