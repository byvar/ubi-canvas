namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_AbyssalHandAIComponent_Template : ActorComponent_Template {
		public float handForwardSpeed;
		public float handBackwardSpeed;
		public float handEscapeSpeed;
		public float handAcceleration;
		public BezierCurveRenderer_Template bezierRenderer;
		public float zOffset;
		public PhysShapePolygon detectionShape;
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
		public float drc_retractLengthRatio;
		public float drc_retractSpeedSmooth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			handForwardSpeed = s.Serialize<float>(handForwardSpeed, name: "handForwardSpeed");
			handBackwardSpeed = s.Serialize<float>(handBackwardSpeed, name: "handBackwardSpeed");
			handEscapeSpeed = s.Serialize<float>(handEscapeSpeed, name: "handEscapeSpeed");
			handAcceleration = s.Serialize<float>(handAcceleration, name: "handAcceleration");
			bezierRenderer = s.SerializeObject<BezierCurveRenderer_Template>(bezierRenderer, name: "bezierRenderer");
			zOffset = s.Serialize<float>(zOffset, name: "zOffset");
			detectionShape = s.SerializeObject<PhysShapePolygon>(detectionShape, name: "detectionShape");
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
			drc_retractLengthRatio = s.Serialize<float>(drc_retractLengthRatio, name: "drc_retractLengthRatio");
			drc_retractSpeedSmooth = s.Serialize<float>(drc_retractSpeedSmooth, name: "drc_retractSpeedSmooth");
		}
		public override uint? ClassCRC => 0xB709B48A;
	}
}

