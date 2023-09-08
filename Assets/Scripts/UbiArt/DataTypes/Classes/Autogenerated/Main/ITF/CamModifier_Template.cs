namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RL | GameFlags.VH | GameFlags.RA)]
	public partial class CamModifier_Template : CSerializable {
		public float cameraLookAtOffsetYUp;
		public float cameraLookAtOffsetYDown;
		public Vec3d cameraLookAtOffset = Vec3d.Invalid;
		public Vec3d cameraLookAtOffsetMaxInMulti = Vec3d.Invalid;
		public Angle focale;
		public bool ignoreZ;
		public float zoneScaleDepthMin = 8;
		public float zoneScaleDepthMax = 22;
		public Vec2d zoneScaleAtDepthMin = new Vec2d(0.1f, 0.1f);
		public Vec2d zoneScaleAtDepthMax = new Vec2d(2, 2);
		public float zoneScaleSpeed = 0.01f;
		public Vec2d cameraDecenteringOffsetAtSpeedMin = new Vec2d(0.1f, 0.1f);
		public Vec2d cameraDecenteringOffsetAtSpeedMax = new Vec2d(0.1f, 0.1f);
		public Vec2d cameraDecenteringSpeedMin;
		public Vec2d cameraDecenteringSpeedMax;
		public Vec2d cameraDecenteringBlendAtSpeedMin;
		public Vec2d cameraDecenteringBlendAtSpeedMax;
		public Vec2d cameraDecenteringInertieAtSpeedMin;
		public Vec2d cameraDecenteringInertieAtSpeedMax;
		public Vec2d cameraDecenteringSmooth;
		public Vec2d cameraDecenteringSubjectLookDirWeight;
		public float cameraDecenteringDepthMin;
		public float cameraDecenteringDepthMax;
		public Vec2d cameraMovingSpeedMin;
		public Vec2d cameraMovingSpeedMax;
		public Vec2d cameraMovingBlendAtSpeedMin;
		public Vec2d cameraMovingBlendAtSpeedMax;
		public Vec2d cameraMovingSmooth;
		public float cameraMovingBlendAccelerationJustSticked;
		public float rayCastScaleMax;
		public float lockPositionBlendOnEnter = 0.01f;
		public float lockPositionBlendOnExit = 0.1f;
		public float screenLimitUpSpeedMax;
		public float screenLimitUpScale;
		public float subjectWeightUnregisterDelay;
		public float subjectWeightRegisterDelay;
		public Vec2d subjectMainVisibilityHorizontal = Vec2d.One;
		public Vec2d subjectMainVisibilityVertical = Vec2d.One;
		public float cameraMovingSmoothCoeffForLeader = 0.5f;
		public float subjectMainVisibilitySwitchAxeSpeed;
		public float zoomBlendInMultiplayer = float.MaxValue;
		public bool isMainSubject = true;
		public bool isMainDRCPlayer;
		public bool isLockedAxe;
		public bool isFixed;


		public float modifierBlend = float.MaxValue;
		public float modifierInertie = float.MaxValue;
		public Vec3d constraintDelayToActivate = Vec3d.Invalid;
		public Vec3d constraintDelayToDisable = Vec3d.Invalid;
		public Vec3d constraintOverrideActivationDelay = Vec3d.Invalid;

		public Vec2d cameraDecenteringDelay;
		
		public float zoomInertieInMultiplayer = float.MaxValue;
		public float zoomDelayInMultiplayer = float.MaxValue;
		public float dezoomBlendInMultiplayer;
		public float dezoomInertieInMultiplayer;
		public float cameraDriftDelay = float.MaxValue;
		public float controllerDriftDelay;

		

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RJR || s.Settings.Game == Game.RFR || s.Settings.Game == Game.RO) {
				modifierBlend = s.Serialize<float>(modifierBlend, name: "modifierBlend");
				modifierInertie = s.Serialize<float>(modifierInertie, name: "modifierInertie");
				constraintDelayToActivate = s.SerializeObject<Vec3d>(constraintDelayToActivate, name: "constraintDelayToActivate");
				constraintDelayToDisable = s.SerializeObject<Vec3d>(constraintDelayToDisable, name: "constraintDelayToDisable");
				cameraLookAtOffsetYUp = s.Serialize<float>(cameraLookAtOffsetYUp, name: "cameraLookAtOffsetYUp");
				cameraLookAtOffsetYDown = s.Serialize<float>(cameraLookAtOffsetYDown, name: "cameraLookAtOffsetYDown");
				cameraLookAtOffset = s.SerializeObject<Vec3d>(cameraLookAtOffset, name: "cameraLookAtOffset");
				cameraLookAtOffsetMaxInMulti = s.SerializeObject<Vec3d>(cameraLookAtOffsetMaxInMulti, name: "cameraLookAtOffsetMaxInMulti");
				focale = (Angle)s.Serialize<float>((float)focale, name: "focale");
				ignoreZ = s.Serialize<bool>(ignoreZ, name: "ignoreZ");
				zoneScaleDepthMin = s.Serialize<float>(zoneScaleDepthMin, name: "zoneScaleDepthMin");
				zoneScaleDepthMax = s.Serialize<float>(zoneScaleDepthMax, name: "zoneScaleDepthMax");
				zoneScaleAtDepthMin = s.SerializeObject<Vec2d>(zoneScaleAtDepthMin, name: "zoneScaleAtDepthMin");
				zoneScaleAtDepthMax = s.SerializeObject<Vec2d>(zoneScaleAtDepthMax, name: "zoneScaleAtDepthMax");
				zoneScaleSpeed = s.Serialize<float>(zoneScaleSpeed, name: "zoneScaleSpeed");
				cameraDecenteringOffsetAtSpeedMin = s.SerializeObject<Vec2d>(cameraDecenteringOffsetAtSpeedMin, name: "cameraDecenteringOffsetAtSpeedMin");
				cameraDecenteringOffsetAtSpeedMax = s.SerializeObject<Vec2d>(cameraDecenteringOffsetAtSpeedMax, name: "cameraDecenteringOffsetAtSpeedMax");
				cameraDecenteringSpeedMin = s.SerializeObject<Vec2d>(cameraDecenteringSpeedMin, name: "cameraDecenteringSpeedMin");
				cameraDecenteringSpeedMax = s.SerializeObject<Vec2d>(cameraDecenteringSpeedMax, name: "cameraDecenteringSpeedMax");
				cameraDecenteringBlendAtSpeedMin = s.SerializeObject<Vec2d>(cameraDecenteringBlendAtSpeedMin, name: "cameraDecenteringBlendAtSpeedMin");
				cameraDecenteringBlendAtSpeedMax = s.SerializeObject<Vec2d>(cameraDecenteringBlendAtSpeedMax, name: "cameraDecenteringBlendAtSpeedMax");
				cameraDecenteringDelay = s.SerializeObject<Vec2d>(cameraDecenteringDelay, name: "cameraDecenteringDelay");
				cameraDecenteringInertieAtSpeedMin = s.SerializeObject<Vec2d>(cameraDecenteringInertieAtSpeedMin, name: "cameraDecenteringInertieAtSpeedMin");
				cameraDecenteringInertieAtSpeedMax = s.SerializeObject<Vec2d>(cameraDecenteringInertieAtSpeedMax, name: "cameraDecenteringInertieAtSpeedMax");
				cameraDecenteringSmooth = s.SerializeObject<Vec2d>(cameraDecenteringSmooth, name: "cameraDecenteringSmooth");
				cameraDecenteringSubjectLookDirWeight = s.SerializeObject<Vec2d>(cameraDecenteringSubjectLookDirWeight, name: "cameraDecenteringSubjectLookDirWeight");
				cameraDecenteringDepthMin = s.Serialize<float>(cameraDecenteringDepthMin, name: "cameraDecenteringDepthMin");
				cameraDecenteringDepthMax = s.Serialize<float>(cameraDecenteringDepthMax, name: "cameraDecenteringDepthMax");
				cameraMovingSpeedMin = s.SerializeObject<Vec2d>(cameraMovingSpeedMin, name: "cameraMovingSpeedMin");
				cameraMovingSpeedMax = s.SerializeObject<Vec2d>(cameraMovingSpeedMax, name: "cameraMovingSpeedMax");
				cameraMovingBlendAtSpeedMin = s.SerializeObject<Vec2d>(cameraMovingBlendAtSpeedMin, name: "cameraMovingBlendAtSpeedMin");
				cameraMovingBlendAtSpeedMax = s.SerializeObject<Vec2d>(cameraMovingBlendAtSpeedMax, name: "cameraMovingBlendAtSpeedMax");
				cameraMovingSmooth = s.SerializeObject<Vec2d>(cameraMovingSmooth, name: "cameraMovingSmooth");
				cameraMovingBlendAccelerationJustSticked = s.Serialize<float>(cameraMovingBlendAccelerationJustSticked, name: "cameraMovingBlendAccelerationJustSticked");
				rayCastScaleMax = s.Serialize<float>(rayCastScaleMax, name: "rayCastScaleMax");
				lockPositionBlendOnEnter = s.Serialize<float>(lockPositionBlendOnEnter, name: "lockPositionBlendOnEnter");
				lockPositionBlendOnExit = s.Serialize<float>(lockPositionBlendOnExit, name: "lockPositionBlendOnExit");
				screenLimitUpSpeedMax = s.Serialize<float>(screenLimitUpSpeedMax, name: "screenLimitUpSpeedMax");
				screenLimitUpScale = s.Serialize<float>(screenLimitUpScale, name: "screenLimitUpScale");
				subjectWeightUnregisterDelay = s.Serialize<float>(subjectWeightUnregisterDelay, name: "subjectWeightUnregisterDelay");
				subjectWeightRegisterDelay = s.Serialize<float>(subjectWeightRegisterDelay, name: "subjectWeightRegisterDelay");
				subjectMainVisibilityHorizontal = s.SerializeObject<Vec2d>(subjectMainVisibilityHorizontal, name: "subjectMainVisibilityHorizontal");
				subjectMainVisibilityVertical = s.SerializeObject<Vec2d>(subjectMainVisibilityVertical, name: "subjectMainVisibilityVertical");
				cameraMovingSmoothCoeffForLeader = s.Serialize<float>(cameraMovingSmoothCoeffForLeader, name: "cameraMovingSmoothCoeffForLeader");
				subjectMainVisibilitySwitchAxeSpeed = s.Serialize<float>(subjectMainVisibilitySwitchAxeSpeed, name: "subjectMainVisibilitySwitchAxeSpeed");
				zoomBlendInMultiplayer = s.Serialize<float>(zoomBlendInMultiplayer, name: "zoomBlendInMultiplayer");
				zoomInertieInMultiplayer = s.Serialize<float>(zoomInertieInMultiplayer, name: "zoomInertieInMultiplayer");
				zoomDelayInMultiplayer = s.Serialize<float>(zoomDelayInMultiplayer, name: "zoomDelayInMultiplayer");
				dezoomBlendInMultiplayer = s.Serialize<float>(dezoomBlendInMultiplayer, name: "dezoomBlendInMultiplayer");
				dezoomInertieInMultiplayer = s.Serialize<float>(dezoomInertieInMultiplayer, name: "dezoomInertieInMultiplayer");
				cameraDriftDelay = s.Serialize<float>(cameraDriftDelay, name: "cameraDriftDelay");
				controllerDriftDelay = s.Serialize<float>(controllerDriftDelay, name: "controllerDriftDelay");
				isMainSubject = s.Serialize<bool>(isMainSubject, name: "isMainSubject");
			} else if(s.Settings.Game == Game.RL) {
				modifierBlend = s.Serialize<float>(modifierBlend, name: "modifierBlend");
				modifierInertie = s.Serialize<float>(modifierInertie, name: "modifierInertie");
				constraintDelayToActivate = s.SerializeObject<Vec3d>(constraintDelayToActivate, name: "constraintDelayToActivate");
				constraintDelayToDisable = s.SerializeObject<Vec3d>(constraintDelayToDisable, name: "constraintDelayToDisable");
				constraintOverrideActivationDelay = s.SerializeObject<Vec3d>(constraintOverrideActivationDelay, name: "constraintOverrideActivationDelay");
				cameraLookAtOffsetYUp = s.Serialize<float>(cameraLookAtOffsetYUp, name: "cameraLookAtOffsetYUp");
				cameraLookAtOffsetYDown = s.Serialize<float>(cameraLookAtOffsetYDown, name: "cameraLookAtOffsetYDown");
				cameraLookAtOffset = s.SerializeObject<Vec3d>(cameraLookAtOffset, name: "cameraLookAtOffset");
				cameraLookAtOffsetMaxInMulti = s.SerializeObject<Vec3d>(cameraLookAtOffsetMaxInMulti, name: "cameraLookAtOffsetMaxInMulti");
				focale = s.SerializeObject<Angle>(focale, name: "focale");
				ignoreZ = s.Serialize<bool>(ignoreZ, name: "ignoreZ");
				zoneScaleDepthMin = s.Serialize<float>(zoneScaleDepthMin, name: "zoneScaleDepthMin");
				zoneScaleDepthMax = s.Serialize<float>(zoneScaleDepthMax, name: "zoneScaleDepthMax");
				zoneScaleAtDepthMin = s.SerializeObject<Vec2d>(zoneScaleAtDepthMin, name: "zoneScaleAtDepthMin");
				zoneScaleAtDepthMax = s.SerializeObject<Vec2d>(zoneScaleAtDepthMax, name: "zoneScaleAtDepthMax");
				zoneScaleSpeed = s.Serialize<float>(zoneScaleSpeed, name: "zoneScaleSpeed");
				cameraDecenteringOffsetAtSpeedMin = s.SerializeObject<Vec2d>(cameraDecenteringOffsetAtSpeedMin, name: "cameraDecenteringOffsetAtSpeedMin");
				cameraDecenteringOffsetAtSpeedMax = s.SerializeObject<Vec2d>(cameraDecenteringOffsetAtSpeedMax, name: "cameraDecenteringOffsetAtSpeedMax");
				cameraDecenteringSpeedMin = s.SerializeObject<Vec2d>(cameraDecenteringSpeedMin, name: "cameraDecenteringSpeedMin");
				cameraDecenteringSpeedMax = s.SerializeObject<Vec2d>(cameraDecenteringSpeedMax, name: "cameraDecenteringSpeedMax");
				cameraDecenteringBlendAtSpeedMin = s.SerializeObject<Vec2d>(cameraDecenteringBlendAtSpeedMin, name: "cameraDecenteringBlendAtSpeedMin");
				cameraDecenteringBlendAtSpeedMax = s.SerializeObject<Vec2d>(cameraDecenteringBlendAtSpeedMax, name: "cameraDecenteringBlendAtSpeedMax");
				cameraDecenteringDelay = s.SerializeObject<Vec2d>(cameraDecenteringDelay, name: "cameraDecenteringDelay");
				cameraDecenteringInertieAtSpeedMin = s.SerializeObject<Vec2d>(cameraDecenteringInertieAtSpeedMin, name: "cameraDecenteringInertieAtSpeedMin");
				cameraDecenteringInertieAtSpeedMax = s.SerializeObject<Vec2d>(cameraDecenteringInertieAtSpeedMax, name: "cameraDecenteringInertieAtSpeedMax");
				cameraDecenteringSmooth = s.SerializeObject<Vec2d>(cameraDecenteringSmooth, name: "cameraDecenteringSmooth");
				cameraDecenteringSubjectLookDirWeight = s.SerializeObject<Vec2d>(cameraDecenteringSubjectLookDirWeight, name: "cameraDecenteringSubjectLookDirWeight");
				cameraDecenteringDepthMin = s.Serialize<float>(cameraDecenteringDepthMin, name: "cameraDecenteringDepthMin");
				cameraDecenteringDepthMax = s.Serialize<float>(cameraDecenteringDepthMax, name: "cameraDecenteringDepthMax");
				cameraMovingSpeedMin = s.SerializeObject<Vec2d>(cameraMovingSpeedMin, name: "cameraMovingSpeedMin");
				cameraMovingSpeedMax = s.SerializeObject<Vec2d>(cameraMovingSpeedMax, name: "cameraMovingSpeedMax");
				cameraMovingBlendAtSpeedMin = s.SerializeObject<Vec2d>(cameraMovingBlendAtSpeedMin, name: "cameraMovingBlendAtSpeedMin");
				cameraMovingBlendAtSpeedMax = s.SerializeObject<Vec2d>(cameraMovingBlendAtSpeedMax, name: "cameraMovingBlendAtSpeedMax");
				cameraMovingSmooth = s.SerializeObject<Vec2d>(cameraMovingSmooth, name: "cameraMovingSmooth");
				cameraMovingBlendAccelerationJustSticked = s.Serialize<float>(cameraMovingBlendAccelerationJustSticked, name: "cameraMovingBlendAccelerationJustSticked");
				rayCastScaleMax = s.Serialize<float>(rayCastScaleMax, name: "rayCastScaleMax");
				lockPositionBlendOnEnter = s.Serialize<float>(lockPositionBlendOnEnter, name: "lockPositionBlendOnEnter");
				lockPositionBlendOnExit = s.Serialize<float>(lockPositionBlendOnExit, name: "lockPositionBlendOnExit");
				screenLimitUpSpeedMax = s.Serialize<float>(screenLimitUpSpeedMax, name: "screenLimitUpSpeedMax");
				screenLimitUpScale = s.Serialize<float>(screenLimitUpScale, name: "screenLimitUpScale");
				subjectWeightUnregisterDelay = s.Serialize<float>(subjectWeightUnregisterDelay, name: "subjectWeightUnregisterDelay");
				subjectWeightRegisterDelay = s.Serialize<float>(subjectWeightRegisterDelay, name: "subjectWeightRegisterDelay");
				subjectMainVisibilityHorizontal = s.SerializeObject<Vec2d>(subjectMainVisibilityHorizontal, name: "subjectMainVisibilityHorizontal");
				subjectMainVisibilityVertical = s.SerializeObject<Vec2d>(subjectMainVisibilityVertical, name: "subjectMainVisibilityVertical");
				cameraMovingSmoothCoeffForLeader = s.Serialize<float>(cameraMovingSmoothCoeffForLeader, name: "cameraMovingSmoothCoeffForLeader");
				subjectMainVisibilitySwitchAxeSpeed = s.Serialize<float>(subjectMainVisibilitySwitchAxeSpeed, name: "subjectMainVisibilitySwitchAxeSpeed");
				zoomBlendInMultiplayer = s.Serialize<float>(zoomBlendInMultiplayer, name: "zoomBlendInMultiplayer");
				zoomInertieInMultiplayer = s.Serialize<float>(zoomInertieInMultiplayer, name: "zoomInertieInMultiplayer");
				zoomDelayInMultiplayer = s.Serialize<float>(zoomDelayInMultiplayer, name: "zoomDelayInMultiplayer");
				dezoomBlendInMultiplayer = s.Serialize<float>(dezoomBlendInMultiplayer, name: "dezoomBlendInMultiplayer");
				dezoomInertieInMultiplayer = s.Serialize<float>(dezoomInertieInMultiplayer, name: "dezoomInertieInMultiplayer");
				cameraDriftDelay = s.Serialize<float>(cameraDriftDelay, name: "cameraDriftDelay");
				controllerDriftDelay = s.Serialize<float>(controllerDriftDelay, name: "controllerDriftDelay");
				isMainSubject = s.Serialize<bool>(isMainSubject, name: "isMainSubject");
				isMainDRCPlayer = s.Serialize<bool>(isMainDRCPlayer, name: "isMainDRCPlayer");
				isLockedAxe = s.Serialize<bool>(isLockedAxe, name: "isLockedAxe");
				isFixed = s.Serialize<bool>(isFixed, name: "isFixed");
			} else {
				cameraLookAtOffsetYUp = s.Serialize<float>(cameraLookAtOffsetYUp, name: "cameraLookAtOffsetYUp");
				cameraLookAtOffsetYDown = s.Serialize<float>(cameraLookAtOffsetYDown, name: "cameraLookAtOffsetYDown");
				cameraLookAtOffset = s.SerializeObject<Vec3d>(cameraLookAtOffset, name: "cameraLookAtOffset");
				cameraLookAtOffsetMaxInMulti = s.SerializeObject<Vec3d>(cameraLookAtOffsetMaxInMulti, name: "cameraLookAtOffsetMaxInMulti");
				focale = s.SerializeObject<Angle>(focale, name: "focale");
				ignoreZ = s.Serialize<bool>(ignoreZ, name: "ignoreZ");
				zoneScaleDepthMin = s.Serialize<float>(zoneScaleDepthMin, name: "zoneScaleDepthMin");
				zoneScaleDepthMax = s.Serialize<float>(zoneScaleDepthMax, name: "zoneScaleDepthMax");
				zoneScaleAtDepthMin = s.SerializeObject<Vec2d>(zoneScaleAtDepthMin, name: "zoneScaleAtDepthMin");
				zoneScaleAtDepthMax = s.SerializeObject<Vec2d>(zoneScaleAtDepthMax, name: "zoneScaleAtDepthMax");
				zoneScaleSpeed = s.Serialize<float>(zoneScaleSpeed, name: "zoneScaleSpeed");
				cameraDecenteringOffsetAtSpeedMin = s.SerializeObject<Vec2d>(cameraDecenteringOffsetAtSpeedMin, name: "cameraDecenteringOffsetAtSpeedMin");
				cameraDecenteringOffsetAtSpeedMax = s.SerializeObject<Vec2d>(cameraDecenteringOffsetAtSpeedMax, name: "cameraDecenteringOffsetAtSpeedMax");
				cameraDecenteringSpeedMin = s.SerializeObject<Vec2d>(cameraDecenteringSpeedMin, name: "cameraDecenteringSpeedMin");
				cameraDecenteringSpeedMax = s.SerializeObject<Vec2d>(cameraDecenteringSpeedMax, name: "cameraDecenteringSpeedMax");
				cameraDecenteringBlendAtSpeedMin = s.SerializeObject<Vec2d>(cameraDecenteringBlendAtSpeedMin, name: "cameraDecenteringBlendAtSpeedMin");
				cameraDecenteringBlendAtSpeedMax = s.SerializeObject<Vec2d>(cameraDecenteringBlendAtSpeedMax, name: "cameraDecenteringBlendAtSpeedMax");
				cameraDecenteringInertieAtSpeedMin = s.SerializeObject<Vec2d>(cameraDecenteringInertieAtSpeedMin, name: "cameraDecenteringInertieAtSpeedMin");
				cameraDecenteringInertieAtSpeedMax = s.SerializeObject<Vec2d>(cameraDecenteringInertieAtSpeedMax, name: "cameraDecenteringInertieAtSpeedMax");
				cameraDecenteringSmooth = s.SerializeObject<Vec2d>(cameraDecenteringSmooth, name: "cameraDecenteringSmooth");
				cameraDecenteringSubjectLookDirWeight = s.SerializeObject<Vec2d>(cameraDecenteringSubjectLookDirWeight, name: "cameraDecenteringSubjectLookDirWeight");
				cameraDecenteringDepthMin = s.Serialize<float>(cameraDecenteringDepthMin, name: "cameraDecenteringDepthMin");
				cameraDecenteringDepthMax = s.Serialize<float>(cameraDecenteringDepthMax, name: "cameraDecenteringDepthMax");
				cameraMovingSpeedMin = s.SerializeObject<Vec2d>(cameraMovingSpeedMin, name: "cameraMovingSpeedMin");
				cameraMovingSpeedMax = s.SerializeObject<Vec2d>(cameraMovingSpeedMax, name: "cameraMovingSpeedMax");
				cameraMovingBlendAtSpeedMin = s.SerializeObject<Vec2d>(cameraMovingBlendAtSpeedMin, name: "cameraMovingBlendAtSpeedMin");
				cameraMovingBlendAtSpeedMax = s.SerializeObject<Vec2d>(cameraMovingBlendAtSpeedMax, name: "cameraMovingBlendAtSpeedMax");
				cameraMovingSmooth = s.SerializeObject<Vec2d>(cameraMovingSmooth, name: "cameraMovingSmooth");
				cameraMovingBlendAccelerationJustSticked = s.Serialize<float>(cameraMovingBlendAccelerationJustSticked, name: "cameraMovingBlendAccelerationJustSticked");
				rayCastScaleMax = s.Serialize<float>(rayCastScaleMax, name: "rayCastScaleMax");
				lockPositionBlendOnEnter = s.Serialize<float>(lockPositionBlendOnEnter, name: "lockPositionBlendOnEnter");
				lockPositionBlendOnExit = s.Serialize<float>(lockPositionBlendOnExit, name: "lockPositionBlendOnExit");
				screenLimitUpSpeedMax = s.Serialize<float>(screenLimitUpSpeedMax, name: "screenLimitUpSpeedMax");
				screenLimitUpScale = s.Serialize<float>(screenLimitUpScale, name: "screenLimitUpScale");
				subjectWeightUnregisterDelay = s.Serialize<float>(subjectWeightUnregisterDelay, name: "subjectWeightUnregisterDelay");
				subjectWeightRegisterDelay = s.Serialize<float>(subjectWeightRegisterDelay, name: "subjectWeightRegisterDelay");
				subjectMainVisibilityHorizontal = s.SerializeObject<Vec2d>(subjectMainVisibilityHorizontal, name: "subjectMainVisibilityHorizontal");
				subjectMainVisibilityVertical = s.SerializeObject<Vec2d>(subjectMainVisibilityVertical, name: "subjectMainVisibilityVertical");
				cameraMovingSmoothCoeffForLeader = s.Serialize<float>(cameraMovingSmoothCoeffForLeader, name: "cameraMovingSmoothCoeffForLeader");
				subjectMainVisibilitySwitchAxeSpeed = s.Serialize<float>(subjectMainVisibilitySwitchAxeSpeed, name: "subjectMainVisibilitySwitchAxeSpeed");
				zoomBlendInMultiplayer = s.Serialize<float>(zoomBlendInMultiplayer, name: "zoomBlendInMultiplayer");
				isMainSubject = s.Serialize<bool>(isMainSubject, name: "isMainSubject");
				isMainDRCPlayer = s.Serialize<bool>(isMainDRCPlayer, name: "isMainDRCPlayer");
				isLockedAxe = s.Serialize<bool>(isLockedAxe, name: "isLockedAxe");
				isFixed = s.Serialize<bool>(isFixed, name: "isFixed");
			}
		}
	}
}

