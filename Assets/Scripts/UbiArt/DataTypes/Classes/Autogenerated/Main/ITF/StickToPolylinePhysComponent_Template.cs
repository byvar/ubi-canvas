namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class StickToPolylinePhysComponent_Template : PhysComponent_Template {
		public float physFriction = 2f;
		public float physAirFriction = 1f;
		public Angle physUnstickMinAngle;
		public Angle physUnstickMaxAngle = 0.78f;
		public float physUnstickMinAngleSpeed = 3f;
		public float physUnstickMaxAngleSpeed = 1f;
		public float physUnstickMinFriction = -1f;
		public float physUnstickMinForceExternal = 50f;
		public float physAngularSpeedMinLinear = 1f;
		public float physAngularSpeedMaxLinear = 10f;
		public Angle physAngularSpeedMinAngular = 2.61f;
		public Angle physAngularSpeedMaxAngular = 4.36f;
		public float physAngularAirMultiplier = 2f;
		public Angle physGroundAngularSpeedMultiplierMinAngle;
		public Angle physGroundAngularSpeedMultiplierMaxAngle = 1f;
		public float physGroundAngularSpeedMultiplierMinMult = 1f;
		public float physGroundAngularSpeedMultiplierMaxMult = 5f;
		public Angle physTransferSpeedLossMinAngle = 0.1f;
		public Angle physTransferSpeedLossMaxAngle = 0.8f;
		public float physTransferSpeedLossMinLoss;
		public float physTransferSpeedLossMaxLoss = 0.1f;
		public Angle physSpeedLossLandEdgeMinAngle = 0.7853982f;
		public Angle physSpeedLossLandEdgeMaxAngle = 1.256637f;
		public float physSpeedLossLandMinimum = 0.5f;
		public float physSpeedLossLandMaximum = 1f;
		public float physTorqueRotationMultiplier = 0.2f;
		public float physMinSpeedStickToWall = 5f;
		public bool physTreatCornerCase;
		public float physCornerCaseDisableDelay = 0.3f;
		public bool physTreatMovingPolylines;
		public bool physTreatSelfCollision;
		public Curve2D physCurveSlideAndAngle;
		public bool displayPhysCurveSlideAndAngle;
		public float physUnstickToOtherMaxDistance;
		public float windForceBlendCoef;
		public float secondaryCollisionCheckRadius;
		public Vec2d secondaryCollisionCheckPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RJR || s.Settings.Game == Game.RO) {
				physFriction = s.Serialize<float>(physFriction, name: "physFriction");
				physAirFriction = s.Serialize<float>(physAirFriction, name: "physAirFriction");
				physUnstickMinAngle = s.SerializeObject<Angle>(physUnstickMinAngle, name: "physUnstickMinAngle");
				physUnstickMaxAngle = s.SerializeObject<Angle>(physUnstickMaxAngle, name: "physUnstickMaxAngle");
				physUnstickMinAngleSpeed = s.Serialize<float>(physUnstickMinAngleSpeed, name: "physUnstickMinAngleSpeed");
				physUnstickMaxAngleSpeed = s.Serialize<float>(physUnstickMaxAngleSpeed, name: "physUnstickMaxAngleSpeed");
				physUnstickMinFriction = s.Serialize<float>(physUnstickMinFriction, name: "physUnstickMinFriction");
				physUnstickMinForceExternal = s.Serialize<float>(physUnstickMinForceExternal, name: "physUnstickMinForceExternal");
				physAngularSpeedMinLinear = s.Serialize<float>(physAngularSpeedMinLinear, name: "physAngularSpeedMinLinear");
				physAngularSpeedMaxLinear = s.Serialize<float>(physAngularSpeedMaxLinear, name: "physAngularSpeedMaxLinear");
				physAngularSpeedMinAngular = s.SerializeObject<Angle>(physAngularSpeedMinAngular, name: "physAngularSpeedMinAngular");
				physAngularSpeedMaxAngular = s.SerializeObject<Angle>(physAngularSpeedMaxAngular, name: "physAngularSpeedMaxAngular");
				physAngularAirMultiplier = s.Serialize<float>(physAngularAirMultiplier, name: "physAngularAirMultiplier");
				physGroundAngularSpeedMultiplierMinAngle = s.SerializeObject<Angle>(physGroundAngularSpeedMultiplierMinAngle, name: "physGroundAngularSpeedMultiplierMinAngle");
				physGroundAngularSpeedMultiplierMaxAngle = s.SerializeObject<Angle>(physGroundAngularSpeedMultiplierMaxAngle, name: "physGroundAngularSpeedMultiplierMaxAngle");
				physGroundAngularSpeedMultiplierMinMult = s.Serialize<float>(physGroundAngularSpeedMultiplierMinMult, name: "physGroundAngularSpeedMultiplierMinMult");
				physGroundAngularSpeedMultiplierMaxMult = s.Serialize<float>(physGroundAngularSpeedMultiplierMaxMult, name: "physGroundAngularSpeedMultiplierMaxMult");
				physTransferSpeedLossMinAngle = s.SerializeObject<Angle>(physTransferSpeedLossMinAngle, name: "physTransferSpeedLossMinAngle");
				physTransferSpeedLossMaxAngle = s.SerializeObject<Angle>(physTransferSpeedLossMaxAngle, name: "physTransferSpeedLossMaxAngle");
				physTransferSpeedLossMinLoss = s.Serialize<float>(physTransferSpeedLossMinLoss, name: "physTransferSpeedLossMinLoss");
				physTransferSpeedLossMaxLoss = s.Serialize<float>(physTransferSpeedLossMaxLoss, name: "physTransferSpeedLossMaxLoss");
				physSpeedLossLandEdgeMinAngle = s.SerializeObject<Angle>(physSpeedLossLandEdgeMinAngle, name: "physSpeedLossLandEdgeMinAngle");
				physSpeedLossLandEdgeMaxAngle = s.SerializeObject<Angle>(physSpeedLossLandEdgeMaxAngle, name: "physSpeedLossLandEdgeMaxAngle");
				physSpeedLossLandMinimum = s.Serialize<float>(physSpeedLossLandMinimum, name: "physSpeedLossLandMinimum");
				physSpeedLossLandMaximum = s.Serialize<float>(physSpeedLossLandMaximum, name: "physSpeedLossLandMaximum");
				physTorqueRotationMultiplier = s.Serialize<float>(physTorqueRotationMultiplier, name: "physTorqueRotationMultiplier");
				physMinSpeedStickToWall = s.Serialize<float>(physMinSpeedStickToWall, name: "physMinSpeedStickToWall");
				physTreatCornerCase = s.Serialize<bool>(physTreatCornerCase, name: "physTreatCornerCase");
				physCornerCaseDisableDelay = s.Serialize<float>(physCornerCaseDisableDelay, name: "physCornerCaseDisableDelay");
				physTreatMovingPolylines = s.Serialize<bool>(physTreatMovingPolylines, name: "physTreatMovingPolylines");
			} else if (s.Settings.Game == Game.RFR || s.Settings.Game == Game.RL) {
				physFriction = s.Serialize<float>(physFriction, name: "physFriction");
				physAirFriction = s.Serialize<float>(physAirFriction, name: "physAirFriction");
				physUnstickMinAngle = s.SerializeObject<Angle>(physUnstickMinAngle, name: "physUnstickMinAngle");
				physUnstickMaxAngle = s.SerializeObject<Angle>(physUnstickMaxAngle, name: "physUnstickMaxAngle");
				physUnstickMinAngleSpeed = s.Serialize<float>(physUnstickMinAngleSpeed, name: "physUnstickMinAngleSpeed");
				physUnstickMaxAngleSpeed = s.Serialize<float>(physUnstickMaxAngleSpeed, name: "physUnstickMaxAngleSpeed");
				physUnstickMinFriction = s.Serialize<float>(physUnstickMinFriction, name: "physUnstickMinFriction");
				physUnstickMinForceExternal = s.Serialize<float>(physUnstickMinForceExternal, name: "physUnstickMinForceExternal");
				physAngularSpeedMinLinear = s.Serialize<float>(physAngularSpeedMinLinear, name: "physAngularSpeedMinLinear");
				physAngularSpeedMaxLinear = s.Serialize<float>(physAngularSpeedMaxLinear, name: "physAngularSpeedMaxLinear");
				physAngularSpeedMinAngular = s.SerializeObject<Angle>(physAngularSpeedMinAngular, name: "physAngularSpeedMinAngular");
				physAngularSpeedMaxAngular = s.SerializeObject<Angle>(physAngularSpeedMaxAngular, name: "physAngularSpeedMaxAngular");
				physAngularAirMultiplier = s.Serialize<float>(physAngularAirMultiplier, name: "physAngularAirMultiplier");
				physGroundAngularSpeedMultiplierMinAngle = s.SerializeObject<Angle>(physGroundAngularSpeedMultiplierMinAngle, name: "physGroundAngularSpeedMultiplierMinAngle");
				physGroundAngularSpeedMultiplierMaxAngle = s.SerializeObject<Angle>(physGroundAngularSpeedMultiplierMaxAngle, name: "physGroundAngularSpeedMultiplierMaxAngle");
				physGroundAngularSpeedMultiplierMinMult = s.Serialize<float>(physGroundAngularSpeedMultiplierMinMult, name: "physGroundAngularSpeedMultiplierMinMult");
				physGroundAngularSpeedMultiplierMaxMult = s.Serialize<float>(physGroundAngularSpeedMultiplierMaxMult, name: "physGroundAngularSpeedMultiplierMaxMult");
				physTransferSpeedLossMinAngle = s.SerializeObject<Angle>(physTransferSpeedLossMinAngle, name: "physTransferSpeedLossMinAngle");
				physTransferSpeedLossMaxAngle = s.SerializeObject<Angle>(physTransferSpeedLossMaxAngle, name: "physTransferSpeedLossMaxAngle");
				physTransferSpeedLossMinLoss = s.Serialize<float>(physTransferSpeedLossMinLoss, name: "physTransferSpeedLossMinLoss");
				physTransferSpeedLossMaxLoss = s.Serialize<float>(physTransferSpeedLossMaxLoss, name: "physTransferSpeedLossMaxLoss");
				physSpeedLossLandEdgeMinAngle = s.SerializeObject<Angle>(physSpeedLossLandEdgeMinAngle, name: "physSpeedLossLandEdgeMinAngle");
				physSpeedLossLandEdgeMaxAngle = s.SerializeObject<Angle>(physSpeedLossLandEdgeMaxAngle, name: "physSpeedLossLandEdgeMaxAngle");
				physSpeedLossLandMinimum = s.Serialize<float>(physSpeedLossLandMinimum, name: "physSpeedLossLandMinimum");
				physSpeedLossLandMaximum = s.Serialize<float>(physSpeedLossLandMaximum, name: "physSpeedLossLandMaximum");
				physTorqueRotationMultiplier = s.Serialize<float>(physTorqueRotationMultiplier, name: "physTorqueRotationMultiplier");
				physMinSpeedStickToWall = s.Serialize<float>(physMinSpeedStickToWall, name: "physMinSpeedStickToWall");
				physTreatCornerCase = s.Serialize<bool>(physTreatCornerCase, name: "physTreatCornerCase");
				physCornerCaseDisableDelay = s.Serialize<float>(physCornerCaseDisableDelay, name: "physCornerCaseDisableDelay");
				physTreatMovingPolylines = s.Serialize<bool>(physTreatMovingPolylines, name: "physTreatMovingPolylines");
				physTreatSelfCollision = s.Serialize<bool>(physTreatSelfCollision, name: "physTreatSelfCollision");
			} else if (s.Settings.Game == Game.COL) {
				physFriction = s.Serialize<float>(physFriction, name: "physFriction");
				physAirFriction = s.Serialize<float>(physAirFriction, name: "physAirFriction");
				physUnstickMinAngle = s.SerializeObject<Angle>(physUnstickMinAngle, name: "physUnstickMinAngle");
				physUnstickMaxAngle = s.SerializeObject<Angle>(physUnstickMaxAngle, name: "physUnstickMaxAngle");
				physUnstickMinAngleSpeed = s.Serialize<float>(physUnstickMinAngleSpeed, name: "physUnstickMinAngleSpeed");
				physUnstickMaxAngleSpeed = s.Serialize<float>(physUnstickMaxAngleSpeed, name: "physUnstickMaxAngleSpeed");
				physUnstickMinFriction = s.Serialize<float>(physUnstickMinFriction, name: "physUnstickMinFriction");
				physUnstickMinForceExternal = s.Serialize<float>(physUnstickMinForceExternal, name: "physUnstickMinForceExternal");
				physUnstickToOtherMaxDistance = s.Serialize<float>(physUnstickToOtherMaxDistance, name: "physUnstickToOtherMaxDistance");
				physAngularSpeedMinLinear = s.Serialize<float>(physAngularSpeedMinLinear, name: "physAngularSpeedMinLinear");
				physAngularSpeedMaxLinear = s.Serialize<float>(physAngularSpeedMaxLinear, name: "physAngularSpeedMaxLinear");
				physAngularSpeedMinAngular = s.SerializeObject<Angle>(physAngularSpeedMinAngular, name: "physAngularSpeedMinAngular");
				physAngularSpeedMaxAngular = s.SerializeObject<Angle>(physAngularSpeedMaxAngular, name: "physAngularSpeedMaxAngular");
				physAngularAirMultiplier = s.Serialize<float>(physAngularAirMultiplier, name: "physAngularAirMultiplier");
				physGroundAngularSpeedMultiplierMinAngle = s.SerializeObject<Angle>(physGroundAngularSpeedMultiplierMinAngle, name: "physGroundAngularSpeedMultiplierMinAngle");
				physGroundAngularSpeedMultiplierMaxAngle = s.SerializeObject<Angle>(physGroundAngularSpeedMultiplierMaxAngle, name: "physGroundAngularSpeedMultiplierMaxAngle");
				physGroundAngularSpeedMultiplierMinMult = s.Serialize<float>(physGroundAngularSpeedMultiplierMinMult, name: "physGroundAngularSpeedMultiplierMinMult");
				physGroundAngularSpeedMultiplierMaxMult = s.Serialize<float>(physGroundAngularSpeedMultiplierMaxMult, name: "physGroundAngularSpeedMultiplierMaxMult");
				physTransferSpeedLossMinAngle = s.SerializeObject<Angle>(physTransferSpeedLossMinAngle, name: "physTransferSpeedLossMinAngle");
				physTransferSpeedLossMaxAngle = s.SerializeObject<Angle>(physTransferSpeedLossMaxAngle, name: "physTransferSpeedLossMaxAngle");
				physTransferSpeedLossMinLoss = s.Serialize<float>(physTransferSpeedLossMinLoss, name: "physTransferSpeedLossMinLoss");
				physTransferSpeedLossMaxLoss = s.Serialize<float>(physTransferSpeedLossMaxLoss, name: "physTransferSpeedLossMaxLoss");
				physSpeedLossLandEdgeMinAngle = s.SerializeObject<Angle>(physSpeedLossLandEdgeMinAngle, name: "physSpeedLossLandEdgeMinAngle");
				physSpeedLossLandEdgeMaxAngle = s.SerializeObject<Angle>(physSpeedLossLandEdgeMaxAngle, name: "physSpeedLossLandEdgeMaxAngle");
				physSpeedLossLandMinimum = s.Serialize<float>(physSpeedLossLandMinimum, name: "physSpeedLossLandMinimum");
				physSpeedLossLandMaximum = s.Serialize<float>(physSpeedLossLandMaximum, name: "physSpeedLossLandMaximum");
				physTorqueRotationMultiplier = s.Serialize<float>(physTorqueRotationMultiplier, name: "physTorqueRotationMultiplier");
				physMinSpeedStickToWall = s.Serialize<float>(physMinSpeedStickToWall, name: "physMinSpeedStickToWall");
				physTreatCornerCase = s.Serialize<bool>(physTreatCornerCase, name: "physTreatCornerCase");
				physCornerCaseDisableDelay = s.Serialize<float>(physCornerCaseDisableDelay, name: "physCornerCaseDisableDelay");
				physTreatMovingPolylines = s.Serialize<bool>(physTreatMovingPolylines, name: "physTreatMovingPolylines");
				physTreatSelfCollision = s.Serialize<bool>(physTreatSelfCollision, name: "physTreatSelfCollision");
				windForceBlendCoef = s.Serialize<float>(windForceBlendCoef, name: "windForceBlendCoef");
				secondaryCollisionCheckRadius = s.Serialize<float>(secondaryCollisionCheckRadius, name: "secondaryCollisionCheckRadius");
				secondaryCollisionCheckPos = s.SerializeObject<Vec2d>(secondaryCollisionCheckPos, name: "secondaryCollisionCheckPos");
			} else {
				physFriction = s.Serialize<float>(physFriction, name: "physFriction");
				physAirFriction = s.Serialize<float>(physAirFriction, name: "physAirFriction");
				physUnstickMinAngle = s.SerializeObject<Angle>(physUnstickMinAngle, name: "physUnstickMinAngle");
				physUnstickMaxAngle = s.SerializeObject<Angle>(physUnstickMaxAngle, name: "physUnstickMaxAngle");
				physUnstickMinAngleSpeed = s.Serialize<float>(physUnstickMinAngleSpeed, name: "physUnstickMinAngleSpeed");
				physUnstickMaxAngleSpeed = s.Serialize<float>(physUnstickMaxAngleSpeed, name: "physUnstickMaxAngleSpeed");
				physUnstickMinFriction = s.Serialize<float>(physUnstickMinFriction, name: "physUnstickMinFriction");
				physUnstickMinForceExternal = s.Serialize<float>(physUnstickMinForceExternal, name: "physUnstickMinForceExternal");
				physAngularSpeedMinLinear = s.Serialize<float>(physAngularSpeedMinLinear, name: "physAngularSpeedMinLinear");
				physAngularSpeedMaxLinear = s.Serialize<float>(physAngularSpeedMaxLinear, name: "physAngularSpeedMaxLinear");
				physAngularSpeedMinAngular = s.SerializeObject<Angle>(physAngularSpeedMinAngular, name: "physAngularSpeedMinAngular");
				physAngularSpeedMaxAngular = s.SerializeObject<Angle>(physAngularSpeedMaxAngular, name: "physAngularSpeedMaxAngular");
				physAngularAirMultiplier = s.Serialize<float>(physAngularAirMultiplier, name: "physAngularAirMultiplier");
				physGroundAngularSpeedMultiplierMinAngle = s.SerializeObject<Angle>(physGroundAngularSpeedMultiplierMinAngle, name: "physGroundAngularSpeedMultiplierMinAngle");
				physGroundAngularSpeedMultiplierMaxAngle = s.SerializeObject<Angle>(physGroundAngularSpeedMultiplierMaxAngle, name: "physGroundAngularSpeedMultiplierMaxAngle");
				physGroundAngularSpeedMultiplierMinMult = s.Serialize<float>(physGroundAngularSpeedMultiplierMinMult, name: "physGroundAngularSpeedMultiplierMinMult");
				physGroundAngularSpeedMultiplierMaxMult = s.Serialize<float>(physGroundAngularSpeedMultiplierMaxMult, name: "physGroundAngularSpeedMultiplierMaxMult");
				physTransferSpeedLossMinAngle = s.SerializeObject<Angle>(physTransferSpeedLossMinAngle, name: "physTransferSpeedLossMinAngle");
				physTransferSpeedLossMaxAngle = s.SerializeObject<Angle>(physTransferSpeedLossMaxAngle, name: "physTransferSpeedLossMaxAngle");
				physTransferSpeedLossMinLoss = s.Serialize<float>(physTransferSpeedLossMinLoss, name: "physTransferSpeedLossMinLoss");
				physTransferSpeedLossMaxLoss = s.Serialize<float>(physTransferSpeedLossMaxLoss, name: "physTransferSpeedLossMaxLoss");
				physSpeedLossLandEdgeMinAngle = s.SerializeObject<Angle>(physSpeedLossLandEdgeMinAngle, name: "physSpeedLossLandEdgeMinAngle");
				physSpeedLossLandEdgeMaxAngle = s.SerializeObject<Angle>(physSpeedLossLandEdgeMaxAngle, name: "physSpeedLossLandEdgeMaxAngle");
				physSpeedLossLandMinimum = s.Serialize<float>(physSpeedLossLandMinimum, name: "physSpeedLossLandMinimum");
				physSpeedLossLandMaximum = s.Serialize<float>(physSpeedLossLandMaximum, name: "physSpeedLossLandMaximum");
				physTorqueRotationMultiplier = s.Serialize<float>(physTorqueRotationMultiplier, name: "physTorqueRotationMultiplier");
				physMinSpeedStickToWall = s.Serialize<float>(physMinSpeedStickToWall, name: "physMinSpeedStickToWall");
				physTreatCornerCase = s.Serialize<bool>(physTreatCornerCase, name: "physTreatCornerCase");
				physCornerCaseDisableDelay = s.Serialize<float>(physCornerCaseDisableDelay, name: "physCornerCaseDisableDelay");
				physTreatMovingPolylines = s.Serialize<bool>(physTreatMovingPolylines, name: "physTreatMovingPolylines");
				physTreatSelfCollision = s.Serialize<bool>(physTreatSelfCollision, name: "physTreatSelfCollision");
				physCurveSlideAndAngle = s.SerializeObject<Curve2D>(physCurveSlideAndAngle, name: "physCurveSlideAndAngle");
				displayPhysCurveSlideAndAngle = s.Serialize<bool>(displayPhysCurveSlideAndAngle, name: "displayPhysCurveSlideAndAngle");
				physRadius = s.Serialize<float>(physRadius, name: "physRadius");
				physWeight = s.Serialize<float>(physWeight, name: "physWeight");
				physWindMultiplier = s.Serialize<float>(physWindMultiplier, name: "physWindMultiplier");
				physWaterMultiplier = s.Serialize<float>(physWaterMultiplier, name: "physWaterMultiplier");
				physForce2Speed = s.Serialize<float>(physForce2Speed, name: "physForce2Speed");
				physWindSpeedLimit = s.Serialize<float>(physWindSpeedLimit, name: "physWindSpeedLimit");
				physWindScaleFactorWhenSpeedIsOpposite = s.Serialize<float>(physWindScaleFactorWhenSpeedIsOpposite, name: "physWindScaleFactorWhenSpeedIsOpposite");
				physFanForceMultiplier = s.Serialize<float>(physFanForceMultiplier, name: "physFanForceMultiplier");
				physWaterMinPerturbation = s.Serialize<float>(physWaterMinPerturbation, name: "physWaterMinPerturbation");
			}
		}
		public override uint? ClassCRC => 0xE85B6A29;
	}
}

