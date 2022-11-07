namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MovableObject_Template : CSerializable {
		public Vec2d anchorOffset;
		public float noFxDelay;
		public float impactFxSpeedThreshold;
		public float moveFxSpeedThreshold;
		public StringID impactFxID;
		public StringID startMovingFxID;
		public StringID stopMovingFxID;
		public float avoidanceCheckDistance;
		public float avoidanceCheckRadius;
		public float avoidanceSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			anchorOffset = s.SerializeObject<Vec2d>(anchorOffset, name: "anchorOffset");
			noFxDelay = s.Serialize<float>(noFxDelay, name: "noFxDelay");
			impactFxSpeedThreshold = s.Serialize<float>(impactFxSpeedThreshold, name: "impactFxSpeedThreshold");
			moveFxSpeedThreshold = s.Serialize<float>(moveFxSpeedThreshold, name: "moveFxSpeedThreshold");
			impactFxID = s.SerializeObject<StringID>(impactFxID, name: "impactFxID");
			startMovingFxID = s.SerializeObject<StringID>(startMovingFxID, name: "startMovingFxID");
			stopMovingFxID = s.SerializeObject<StringID>(stopMovingFxID, name: "stopMovingFxID");
			avoidanceCheckDistance = s.Serialize<float>(avoidanceCheckDistance, name: "avoidanceCheckDistance");
			avoidanceCheckRadius = s.Serialize<float>(avoidanceCheckRadius, name: "avoidanceCheckRadius");
			avoidanceSpeed = s.Serialize<float>(avoidanceSpeed, name: "avoidanceSpeed");
		}
		public override uint? ClassCRC => 0xC9791002;
	}
}

