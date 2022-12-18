namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_BTShooterActionIdle_Template : CSerializable {
		public StringID anim;
		public int dynamicFlip;
		public int dynamicFlipStartLeft;
		public int useFixedAngle;
		public Angle fixedAngle;
		public int takeMoveOrientation;
		public Angle takeMoveOrientationOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			anim = s.SerializeObject<StringID>(anim, name: "anim");
			dynamicFlip = s.Serialize<int>(dynamicFlip, name: "dynamicFlip");
			dynamicFlipStartLeft = s.Serialize<int>(dynamicFlipStartLeft, name: "dynamicFlipStartLeft");
			useFixedAngle = s.Serialize<int>(useFixedAngle, name: "useFixedAngle");
			fixedAngle = s.SerializeObject<Angle>(fixedAngle, name: "fixedAngle");
			takeMoveOrientation = s.Serialize<int>(takeMoveOrientation, name: "takeMoveOrientation");
			takeMoveOrientationOffset = s.SerializeObject<Angle>(takeMoveOrientationOffset, name: "takeMoveOrientationOffset");
		}
		public override uint? ClassCRC => 0xE4F3B318;
	}
}

