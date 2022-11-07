namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class BezierTreeFollowComponent : CSerializable {
		public bool isLooping;
		public float moveSpeed;
		public Angle maxAngle;
		public float sinFactor;
		public bool useSinAngle;
		public bool followCurveAngle;
		public bool updateFlip;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			isLooping = s.Serialize<bool>(isLooping, name: "isLooping", options: CSerializerObject.Options.BoolAsByte);
			moveSpeed = s.Serialize<float>(moveSpeed, name: "moveSpeed");
			maxAngle = s.SerializeObject<Angle>(maxAngle, name: "maxAngle");
			sinFactor = s.Serialize<float>(sinFactor, name: "sinFactor");
			useSinAngle = s.Serialize<bool>(useSinAngle, name: "useSinAngle", options: CSerializerObject.Options.BoolAsByte);
			followCurveAngle = s.Serialize<bool>(followCurveAngle, name: "followCurveAngle", options: CSerializerObject.Options.BoolAsByte);
			updateFlip = s.Serialize<bool>(updateFlip, name: "updateFlip", options: CSerializerObject.Options.BoolAsByte);
		}
		public override uint? ClassCRC => 0x83B6061E;
	}
}

