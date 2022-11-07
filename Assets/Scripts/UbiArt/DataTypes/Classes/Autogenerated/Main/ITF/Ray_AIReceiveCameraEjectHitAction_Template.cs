namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_AIReceiveCameraEjectHitAction_Template : Ray_AIReceiveHitAction_Template {
		public Vec3d minStartSpeed;
		public Vec3d maxStartSpeed;
		public float zMinSpeed;
		public float zAcceleration;
		public float gravityMultiplier;
		public float ejectDuration;
		public int zForced;
		public float rotationSpeed;
		public Vec2d fixedEjectDir;
		public float fadeDuration;
		public float delayBeforeFade;
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
		public override uint? ClassCRC => 0x16D859E3;
	}
}

