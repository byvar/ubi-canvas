namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ShooterBTAIComponent_Template : RO2_EnemyBTAIComponent_Template {
		public int cameraRelative;
		public int triggerable;
		public int dynamicFlip;
		public int dynamicFlipStartLeft;
		public int useFixedAngle;
		public Angle fixedAngle;
		public int takeMoveOrientation;
		public Angle takeMoveOrientationOffset;
		public int canBeCrushed;
		public int disableOnBecomeInactive;
		public float visualScaleMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			cameraRelative = s.Serialize<int>(cameraRelative, name: "cameraRelative");
			triggerable = s.Serialize<int>(triggerable, name: "triggerable");
			dynamicFlip = s.Serialize<int>(dynamicFlip, name: "dynamicFlip");
			dynamicFlipStartLeft = s.Serialize<int>(dynamicFlipStartLeft, name: "dynamicFlipStartLeft");
			useFixedAngle = s.Serialize<int>(useFixedAngle, name: "useFixedAngle");
			fixedAngle = s.SerializeObject<Angle>(fixedAngle, name: "fixedAngle");
			takeMoveOrientation = s.Serialize<int>(takeMoveOrientation, name: "takeMoveOrientation");
			takeMoveOrientationOffset = s.SerializeObject<Angle>(takeMoveOrientationOffset, name: "takeMoveOrientationOffset");
			canBeCrushed = s.Serialize<int>(canBeCrushed, name: "canBeCrushed");
			disableOnBecomeInactive = s.Serialize<int>(disableOnBecomeInactive, name: "disableOnBecomeInactive");
			visualScaleMultiplier = s.Serialize<float>(visualScaleMultiplier, name: "visualScaleMultiplier");
		}
		public override uint? ClassCRC => 0x795ED68C;
	}
}

