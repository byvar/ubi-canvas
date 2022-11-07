namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AbyssalHandAIComponent_Template : CSerializable {
		public float handForwardSpeed;
		public float handBackwardSpeed;
		public float handEscapeSpeed;
		public float handAcceleration;
		public Placeholder bezierRenderer;
		public Placeholder detectionShape;
		public float handLightDistance;
		public Angle handRotationSpeed;
		public StringID endCurveBoneName;
		public float stimDelay;
		public float stimDistance;
		public float idleMinTime;
		public float rootTangentFactor;
		public float handTangentFactor;
		public float tangentMaxFactorLength;
		public float tangentNullFactorLength;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			handForwardSpeed = s.Serialize<float>(handForwardSpeed, name: "handForwardSpeed");
			handBackwardSpeed = s.Serialize<float>(handBackwardSpeed, name: "handBackwardSpeed");
			handEscapeSpeed = s.Serialize<float>(handEscapeSpeed, name: "handEscapeSpeed");
			handAcceleration = s.Serialize<float>(handAcceleration, name: "handAcceleration");
			bezierRenderer = s.SerializeObject<Placeholder>(bezierRenderer, name: "bezierRenderer");
			detectionShape = s.SerializeObject<Placeholder>(detectionShape, name: "detectionShape");
			handLightDistance = s.Serialize<float>(handLightDistance, name: "handLightDistance");
			handRotationSpeed = s.SerializeObject<Angle>(handRotationSpeed, name: "handRotationSpeed");
			endCurveBoneName = s.SerializeObject<StringID>(endCurveBoneName, name: "endCurveBoneName");
			stimDelay = s.Serialize<float>(stimDelay, name: "stimDelay");
			stimDistance = s.Serialize<float>(stimDistance, name: "stimDistance");
			idleMinTime = s.Serialize<float>(idleMinTime, name: "idleMinTime");
			rootTangentFactor = s.Serialize<float>(rootTangentFactor, name: "rootTangentFactor");
			handTangentFactor = s.Serialize<float>(handTangentFactor, name: "handTangentFactor");
			tangentMaxFactorLength = s.Serialize<float>(tangentMaxFactorLength, name: "tangentMaxFactorLength");
			tangentNullFactorLength = s.Serialize<float>(tangentNullFactorLength, name: "tangentNullFactorLength");
		}
		public override uint? ClassCRC => 0x392DF746;
	}
}

