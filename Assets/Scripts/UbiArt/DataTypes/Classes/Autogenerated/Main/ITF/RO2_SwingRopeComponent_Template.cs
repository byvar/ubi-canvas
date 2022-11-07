namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_SwingRopeComponent_Template : SoftPlatformComponent_Template {
		public Angle maxSwingAngle;
		public float stiffGravityMultiplier;
		public float stiffImpulseMultiplier;
		public float stiffSwingSpeedFriction;
		public float nonStiffSwingSpeedFriction;
		public float landDragMultiplier;
		public float landDragDuration;
		public bool canUseSmall;
		public bool canUseNormal;
		public bool repositionWithBones;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			maxSwingAngle = s.SerializeObject<Angle>(maxSwingAngle, name: "maxSwingAngle");
			stiffGravityMultiplier = s.Serialize<float>(stiffGravityMultiplier, name: "stiffGravityMultiplier");
			stiffImpulseMultiplier = s.Serialize<float>(stiffImpulseMultiplier, name: "stiffImpulseMultiplier");
			stiffSwingSpeedFriction = s.Serialize<float>(stiffSwingSpeedFriction, name: "stiffSwingSpeedFriction");
			nonStiffSwingSpeedFriction = s.Serialize<float>(nonStiffSwingSpeedFriction, name: "nonStiffSwingSpeedFriction");
			landDragMultiplier = s.Serialize<float>(landDragMultiplier, name: "landDragMultiplier");
			landDragDuration = s.Serialize<float>(landDragDuration, name: "landDragDuration");
			canUseSmall = s.Serialize<bool>(canUseSmall, name: "canUseSmall");
			canUseNormal = s.Serialize<bool>(canUseNormal, name: "canUseNormal");
			repositionWithBones = s.Serialize<bool>(repositionWithBones, name: "repositionWithBones");
		}
		public override uint? ClassCRC => 0x3751415B;
	}
}

