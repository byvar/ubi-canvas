namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_BulletAIComponent_Template : RO2_AIComponent_Template {
		public Generic<TemplateAIBehavior> launchBehavior;
		public Generic<TemplateAIBehavior> genericBehavior;
		public Generic<TemplateAIBehavior> deathBehavior;
		public Generic<TemplateAIBehavior> deathNoStimBehavior;
		public Generic<TemplateAIBehavior> sleepingBehavior;
		public Generic<TemplateAIBehavior> appearBehavior;
		public Generic<TemplateAIBehavior> delayKillBehavior;
		public float speed;
		public float lifeTime;
		public bool collideWithEnvironment;
		public bool collideWithPhantoms;
		public bool filterEnvironmentCollisionWithSpeed;
		public bool filterEnvironmentCollisionWithDirection;
		public float activateNoCollDuration;
		public float collisionOffset;
		public float collisionRadius;
		public bool sendDeathStim;
		public bool explodeOnDeathStim;
		public bool isCameraRelative;
		public bool collideWithSolidEdges;
		public bool disablePolylineOnDeath;
		public bool destroyOnExitScreen;
		public bool destroyOnBecomeInactive;
		public float dragForceWeight_Left;
		public float dragForceWeight_Right;
		public float dragForceWeight_Up;
		public float dragForceWeight_Down;
		public float dragForceDistance;
		public float dragForceFadeWeight;
		public Angle dragForceMaxAngle;
		public bool dragKeepDirection;
		public bool dragForceSpeedRelated;
		public bool hitReceivedFriendlyFire;
		public bool checkNoseFriendlyFire;
		public bool checkPhantomAllowed;
		public bool explodeOnContact;
		public bool useSleepingBehavior;
		public bool useLifeTime;
		public Vec2d dragOffsetLeft;
		public Vec2d dragOffsetRight;
		public float dragOffsetUp;
		public bool registerToCamera;
		public bool immuneToHit;
		public bool appearAfterCameraOut;
		public bool dieOnTrigger;
		public float outCameraMaxTime;
		public bool driveCameraAlways;
		public bool dieOnWaterContact;
		public bool resetToInitPos;
		public float basicDelayKillDuration;
		public float delayKillGravityFactor;
		public float cameraRegisterDelay;
		public bool spawnSmokeOnDelayKill;
		public StringID prisonerAttachBone;
		public bool avoidRoofColl;
		public bool blockOnNPC;
		public Generic<PhysShape> roofShape;
		public Generic<PhysShape> blockOnNPCShape;
		public float blockOnNPCCoefToMinRadius;
		public float roofCoefToMinRadius;
		public bool deathOnRelease;
		public float deathTimer;
		public bool snapPlayer;
		public float snapPlayerOffset;
		public StringID snapBone;
		public bool explodeOnEnemy;
		public bool KillEnemy;
		public float offScreenOffset;
		public bool useShieldGlobalSystem;
		public bool useHitReaction;
		public bool usePlayerInShape;
		public Generic<PhysShape> playerInShape;
		public bool useFadeWhenDie;
		public float fadeDuration;
		public bool useSpecificNoseShape;
		public Generic<PhysShape> specificNoseShape;
		public bool acceptEventUpdateRegisteredSubjectStatus;
		public bool allowTouchScreenInputDisabled;
		public bool dragEnabled;
		public bool sendTriggerOnDrcEventEnabled;
		public bool autoStart;
		public bool drcEventEnabled;
		public bool reactToFlyingPlatform;

		public StringID Vita_00 { get; set; }

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			launchBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(launchBehavior, name: "launchBehavior");
			genericBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(genericBehavior, name: "genericBehavior");
			deathBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(deathBehavior, name: "deathBehavior");
			deathNoStimBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(deathNoStimBehavior, name: "deathNoStimBehavior");
			sleepingBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(sleepingBehavior, name: "sleepingBehavior");
			appearBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(appearBehavior, name: "appearBehavior");
			delayKillBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(delayKillBehavior, name: "delayKillBehavior");
			speed = s.Serialize<float>(speed, name: "speed");
			lifeTime = s.Serialize<float>(lifeTime, name: "lifeTime");
			collideWithEnvironment = s.Serialize<bool>(collideWithEnvironment, name: "collideWithEnvironment");
			collideWithPhantoms = s.Serialize<bool>(collideWithPhantoms, name: "collideWithPhantoms");
			filterEnvironmentCollisionWithSpeed = s.Serialize<bool>(filterEnvironmentCollisionWithSpeed, name: "filterEnvironmentCollisionWithSpeed");
			filterEnvironmentCollisionWithDirection = s.Serialize<bool>(filterEnvironmentCollisionWithDirection, name: "filterEnvironmentCollisionWithDirection");
			activateNoCollDuration = s.Serialize<float>(activateNoCollDuration, name: "activateNoCollDuration");
			collisionOffset = s.Serialize<float>(collisionOffset, name: "collisionOffset");
			collisionRadius = s.Serialize<float>(collisionRadius, name: "collisionRadius");
			sendDeathStim = s.Serialize<bool>(sendDeathStim, name: "sendDeathStim");
			explodeOnDeathStim = s.Serialize<bool>(explodeOnDeathStim, name: "explodeOnDeathStim");
			isCameraRelative = s.Serialize<bool>(isCameraRelative, name: "isCameraRelative");
			collideWithSolidEdges = s.Serialize<bool>(collideWithSolidEdges, name: "collideWithSolidEdges");
			disablePolylineOnDeath = s.Serialize<bool>(disablePolylineOnDeath, name: "disablePolylineOnDeath");
			destroyOnExitScreen = s.Serialize<bool>(destroyOnExitScreen, name: "destroyOnExitScreen");
			destroyOnBecomeInactive = s.Serialize<bool>(destroyOnBecomeInactive, name: "destroyOnBecomeInactive");
			dragForceWeight_Left = s.Serialize<float>(dragForceWeight_Left, name: "dragForceWeight_Left");
			dragForceWeight_Right = s.Serialize<float>(dragForceWeight_Right, name: "dragForceWeight_Right");
			dragForceWeight_Up = s.Serialize<float>(dragForceWeight_Up, name: "dragForceWeight_Up");
			dragForceWeight_Down = s.Serialize<float>(dragForceWeight_Down, name: "dragForceWeight_Down");
			dragForceDistance = s.Serialize<float>(dragForceDistance, name: "dragForceDistance");
			dragForceFadeWeight = s.Serialize<float>(dragForceFadeWeight, name: "dragForceFadeWeight");
			dragForceMaxAngle = s.SerializeObject<Angle>(dragForceMaxAngle, name: "dragForceMaxAngle");
			dragKeepDirection = s.Serialize<bool>(dragKeepDirection, name: "dragKeepDirection");
			dragForceSpeedRelated = s.Serialize<bool>(dragForceSpeedRelated, name: "dragForceSpeedRelated");
			hitReceivedFriendlyFire = s.Serialize<bool>(hitReceivedFriendlyFire, name: "hitReceivedFriendlyFire");
			checkNoseFriendlyFire = s.Serialize<bool>(checkNoseFriendlyFire, name: "checkNoseFriendlyFire");
			checkPhantomAllowed = s.Serialize<bool>(checkPhantomAllowed, name: "checkPhantomAllowed");
			explodeOnContact = s.Serialize<bool>(explodeOnContact, name: "explodeOnContact");
			useSleepingBehavior = s.Serialize<bool>(useSleepingBehavior, name: "useSleepingBehavior");
			useLifeTime = s.Serialize<bool>(useLifeTime, name: "useLifeTime");
			dragOffsetLeft = s.SerializeObject<Vec2d>(dragOffsetLeft, name: "dragOffsetLeft");
			dragOffsetRight = s.SerializeObject<Vec2d>(dragOffsetRight, name: "dragOffsetRight");
			dragOffsetUp = s.Serialize<float>(dragOffsetUp, name: "dragOffsetUp");
			registerToCamera = s.Serialize<bool>(registerToCamera, name: "registerToCamera");
			immuneToHit = s.Serialize<bool>(immuneToHit, name: "immuneToHit");
			appearAfterCameraOut = s.Serialize<bool>(appearAfterCameraOut, name: "appearAfterCameraOut");
			dieOnTrigger = s.Serialize<bool>(dieOnTrigger, name: "dieOnTrigger");
			outCameraMaxTime = s.Serialize<float>(outCameraMaxTime, name: "outCameraMaxTime");
			driveCameraAlways = s.Serialize<bool>(driveCameraAlways, name: "driveCameraAlways");
			dieOnWaterContact = s.Serialize<bool>(dieOnWaterContact, name: "dieOnWaterContact");
			resetToInitPos = s.Serialize<bool>(resetToInitPos, name: "resetToInitPos");
			basicDelayKillDuration = s.Serialize<float>(basicDelayKillDuration, name: "basicDelayKillDuration");
			delayKillGravityFactor = s.Serialize<float>(delayKillGravityFactor, name: "delayKillGravityFactor");
			cameraRegisterDelay = s.Serialize<float>(cameraRegisterDelay, name: "cameraRegisterDelay");
			spawnSmokeOnDelayKill = s.Serialize<bool>(spawnSmokeOnDelayKill, name: "spawnSmokeOnDelayKill");
			prisonerAttachBone = s.SerializeObject<StringID>(prisonerAttachBone, name: "prisonerAttachBone");
			avoidRoofColl = s.Serialize<bool>(avoidRoofColl, name: "avoidRoofColl");
			blockOnNPC = s.Serialize<bool>(blockOnNPC, name: "blockOnNPC");
			roofShape = s.SerializeObject<Generic<PhysShape>>(roofShape, name: "roofShape");
			blockOnNPCShape = s.SerializeObject<Generic<PhysShape>>(blockOnNPCShape, name: "blockOnNPCShape");
			blockOnNPCCoefToMinRadius = s.Serialize<float>(blockOnNPCCoefToMinRadius, name: "blockOnNPCCoefToMinRadius");
			roofCoefToMinRadius = s.Serialize<float>(roofCoefToMinRadius, name: "roofCoefToMinRadius");
			deathOnRelease = s.Serialize<bool>(deathOnRelease, name: "deathOnRelease");
			deathTimer = s.Serialize<float>(deathTimer, name: "deathTimer");
			snapPlayer = s.Serialize<bool>(snapPlayer, name: "snapPlayer");
			if (s.Settings.Platform == GamePlatform.Vita) {
				Vita_00 = s.SerializeObject<StringID>(Vita_00, name: nameof(Vita_00));
			}
			snapPlayerOffset = s.Serialize<float>(snapPlayerOffset, name: "snapPlayerOffset");
			snapBone = s.SerializeObject<StringID>(snapBone, name: "snapBone");
			explodeOnEnemy = s.Serialize<bool>(explodeOnEnemy, name: "explodeOnEnemy");
			KillEnemy = s.Serialize<bool>(KillEnemy, name: "KillEnemy");
			offScreenOffset = s.Serialize<float>(offScreenOffset, name: "offScreenOffset");
			useShieldGlobalSystem = s.Serialize<bool>(useShieldGlobalSystem, name: "useShieldGlobalSystem");
			useHitReaction = s.Serialize<bool>(useHitReaction, name: "useHitReaction");
			usePlayerInShape = s.Serialize<bool>(usePlayerInShape, name: "usePlayerInShape");
			playerInShape = s.SerializeObject<Generic<PhysShape>>(playerInShape, name: "playerInShape");
			useFadeWhenDie = s.Serialize<bool>(useFadeWhenDie, name: "useFadeWhenDie");
			fadeDuration = s.Serialize<float>(fadeDuration, name: "fadeDuration");
			useSpecificNoseShape = s.Serialize<bool>(useSpecificNoseShape, name: "useSpecificNoseShape");
			specificNoseShape = s.SerializeObject<Generic<PhysShape>>(specificNoseShape, name: "specificNoseShape");
			acceptEventUpdateRegisteredSubjectStatus = s.Serialize<bool>(acceptEventUpdateRegisteredSubjectStatus, name: "acceptEventUpdateRegisteredSubjectStatus");
			allowTouchScreenInputDisabled = s.Serialize<bool>(allowTouchScreenInputDisabled, name: "allowTouchScreenInputDisabled");

			if (s.Settings.Platform != GamePlatform.Vita) {
				dragEnabled = s.Serialize<bool>(dragEnabled, name: "dragEnabled");
				sendTriggerOnDrcEventEnabled = s.Serialize<bool>(sendTriggerOnDrcEventEnabled, name: "sendTriggerOnDrcEventEnabled");
				autoStart = s.Serialize<bool>(autoStart, name: "autoStart");
				drcEventEnabled = s.Serialize<bool>(drcEventEnabled, name: "drcEventEnabled");
				reactToFlyingPlatform = s.Serialize<bool>(reactToFlyingPlatform, name: "reactToFlyingPlatform");
			}
		}
		public override uint? ClassCRC => 0xBAA3F606;
	}
}

