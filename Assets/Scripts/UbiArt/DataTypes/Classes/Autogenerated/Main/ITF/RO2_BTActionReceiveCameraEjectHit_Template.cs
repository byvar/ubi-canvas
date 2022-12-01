namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionReceiveCameraEjectHit_Template : RO2_BTActionReceiveHit_Template {
		public Vec3d minStartSpeed = new Vec3d(1,1,15);
		public Vec3d maxStartSpeed = new Vec3d(2,2,20);
		public float zMinSpeed = 7f;
		public float zAcceleration = 20f;
		public float gravityMultiplier = 0.1f;
		public float ejectDuration = 5f;
		public int zForced;
		public float rotationSpeed;
		public Vec2d fixedEjectDir;
		public float fadeDuration;
		public float delayBeforeFade = -1f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			minStartSpeed = s.SerializeObject<Vec3d>(minStartSpeed, name: "minStartSpeed");
			maxStartSpeed = s.SerializeObject<Vec3d>(maxStartSpeed, name: "maxStartSpeed");
			zMinSpeed = s.Serialize<float>(zMinSpeed, name: "zMinSpeed");
			zAcceleration = s.Serialize<float>(zAcceleration, name: "zAcceleration");
			gravityMultiplier = s.Serialize<float>(gravityMultiplier, name: "gravityMultiplier");
			ejectDuration = s.Serialize<float>(ejectDuration, name: "ejectDuration");
			zForced = s.Serialize<int>(zForced, name: "zForced");
			rotationSpeed = s.Serialize<float>(rotationSpeed, name: "rotationSpeed");
			fixedEjectDir = s.SerializeObject<Vec2d>(fixedEjectDir, name: "fixedEjectDir");
			fadeDuration = s.Serialize<float>(fadeDuration, name: "fadeDuration");
			delayBeforeFade = s.Serialize<float>(delayBeforeFade, name: "delayBeforeFade");
		}
		public override uint? ClassCRC => 0xFFFEE8A4;
	}
}

