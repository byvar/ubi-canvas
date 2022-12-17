namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_BallComponent_Template : ActorComponent_Template {
		public float impulseForce_Ground;
		public float impulseForce_Wall;
		public float impulseForce_Hit;
		public float impulseForce_ShotBasic;
		public float impulseForce_ShotCrush;
		public float impulseForce_ShotUp;
		public float impulseForce_ShotCharge;
		public float impulseForce_EjectY;
		public float impulseForce_Pass;
		public float bounceCoefMin_x;
		public float bounceCoefMin_y;
		public float bounceCoefFactor_x;
		public float bounceCoefFactor_y;
		public float bounceDotUpLimit;
		public float bounceDotDownLimit;
		public float bounceCoefMax_x;
		public float bounceCoefMax_y;
		public BALLMODE_SHOTBASIC ballMode_ShotBasic;
		public BALLMODE_SHOTCRUSH ballMode_ShotCrush;
		public BALLMODE_SHOTUP ballMode_ShotUp;
		public BALLMODE_SHOTCHARGE ballMode_ShotCharge;
		public BALLMODE_EJECTY ballMode_EjectY;
		public BALLMODE_PASS ballMode_Pass;
		public Angle angleDir_ShotBasic;
		public Angle angleDir_ShotCrush;
		public Angle angleDir_ShotUp;
		public Angle angleDir_ShotCharge;
		public Angle angleDir_EjectY;
		public Angle angleDir_Pass;
		public Angle angleDirAlt_ShotBasic;
		public Angle angleDirAlt_ShotCrush;
		public Angle angleDirAlt_ShotUp;
		public Angle angleDirAlt_EjectY;
		public Angle angleDirAlt_Pass;
		public float bounceCoefPass_x;
		public float bounceCoefPass_y;
		public float bounceCoefRoof;
		public bool playerCol_Enabled;
		public float playerCol_ShapeRadius;
		public bool playerCol_DisabledWhileHitting;
		public float playerCol_AfterHitDisabledTimer;
		public bool isLethal_ShotBasic;
		public bool isLethal_ShotCrush;
		public bool isLethal_ShotUp;
		public bool isLethal_ShotCharge;
		public bool isLethal_EjectY;
		public bool isLethal_Pass;
		public float forceMin_x;
		public float forceMax_x;
		public float forceMin_y;
		public float forceMax_y;
		public RECEIVEDHITTYPE receivedHitType_ShotBasic;
		public RECEIVEDHITTYPE receivedHitType_ShotCrush;
		public RECEIVEDHITTYPE receivedHitType_ShotUp;
		public RECEIVEDHITTYPE receivedHitType_ShotCharge;
		public RECEIVEDHITTYPE receivedHitType_EjectY;
		public RECEIVEDHITTYPE receivedHitType_Pass;
		public uint hitLevel_ShotBasic = uint.MaxValue;
		public uint hitLevel_ShotCrush = uint.MaxValue;
		public uint hitLevel_ShotUp = uint.MaxValue;
		public uint hitLevel_ShotCharge = uint.MaxValue;
		public uint hitLevel_EjectY = uint.MaxValue;
		public uint hitLevel_Pass = uint.MaxValue;
		public float hitDelay;
		public float blockingEdgeTimer;
		public float minTime_Pass;
		public Angle angleAltChoice_ShotBasic;
		public Angle angleAltChoice_ShotCrush;
		public Angle angleAltChoice_ShotUp;
		public Angle angleAltChoice_ShotCharge;
		public Angle angleAltChoice_EjectY;
		public Angle angleAltChoice_Pass;
		public uint joyTrameMax = uint.MaxValue;
		public float impulseForceMegaHit_ShotBasic;
		public float impulseForceMegaHit_ShotCrush;
		public float impulseForceMegaHit_ShotUp;
		public float impulseForceMegaHit_ShotCharge;
		public float impulseForceMegaHit_EjectY;
		public float impulseForceMegaHit_Pass;
		public float cameraRegisterDelay;
		public bool megaHitCounterEnabled;
		public bool buildMegaHitEnabled_ShotBasic;
		public bool buildMegaHitEnabled_ShotCrush;
		public bool buildMegaHitEnabled_ShotUp;
		public bool buildMegaHitEnabled_ShotCharge;
		public bool buildMegaHitEnabled_EjectY;
		public bool buildMegaHitEnabled_Pass;
		public uint hitCountForMegaHit = uint.MaxValue;
		public float stretchAnimSpeedMin;
		public float animHaloTimer;
		public float crushGroundImmuneDuration;
		public float megaHitForce;
		public float drcTapForce = 500f;
		public uint faction;
		public float playerHitLifeTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				impulseForce_Ground = s.Serialize<float>(impulseForce_Ground, name: "impulseForce_Ground");
				impulseForce_Wall = s.Serialize<float>(impulseForce_Wall, name: "impulseForce_Wall");
				impulseForce_Hit = s.Serialize<float>(impulseForce_Hit, name: "impulseForce_Hit");
				impulseForce_ShotBasic = s.Serialize<float>(impulseForce_ShotBasic, name: "impulseForce_ShotBasic");
				impulseForce_ShotCrush = s.Serialize<float>(impulseForce_ShotCrush, name: "impulseForce_ShotCrush");
				impulseForce_ShotUp = s.Serialize<float>(impulseForce_ShotUp, name: "impulseForce_ShotUp");
				impulseForce_ShotCharge = s.Serialize<float>(impulseForce_ShotCharge, name: "impulseForce_ShotCharge");
				impulseForce_EjectY = s.Serialize<float>(impulseForce_EjectY, name: "impulseForce_EjectY");
				impulseForce_Pass = s.Serialize<float>(impulseForce_Pass, name: "impulseForce_Pass");
				bounceCoefMin_x = s.Serialize<float>(bounceCoefMin_x, name: "bounceCoefMin_x");
				bounceCoefMin_y = s.Serialize<float>(bounceCoefMin_y, name: "bounceCoefMin_y");
				bounceCoefFactor_x = s.Serialize<float>(bounceCoefFactor_x, name: "bounceCoefFactor_x");
				bounceCoefFactor_y = s.Serialize<float>(bounceCoefFactor_y, name: "bounceCoefFactor_y");
				bounceDotUpLimit = s.Serialize<float>(bounceDotUpLimit, name: "bounceDotUpLimit");
				bounceDotDownLimit = s.Serialize<float>(bounceDotDownLimit, name: "bounceDotDownLimit");
				bounceCoefMax_x = s.Serialize<float>(bounceCoefMax_x, name: "bounceCoefMax_x");
				bounceCoefMax_y = s.Serialize<float>(bounceCoefMax_y, name: "bounceCoefMax_y");
				ballMode_ShotBasic = s.Serialize<BALLMODE_SHOTBASIC>(ballMode_ShotBasic, name: "ballMode_ShotBasic");
				ballMode_ShotCrush = s.Serialize<BALLMODE_SHOTCRUSH>(ballMode_ShotCrush, name: "ballMode_ShotCrush");
				ballMode_ShotUp = s.Serialize<BALLMODE_SHOTUP>(ballMode_ShotUp, name: "ballMode_ShotUp");
				ballMode_ShotCharge = s.Serialize<BALLMODE_SHOTCHARGE>(ballMode_ShotCharge, name: "ballMode_ShotCharge");
				ballMode_EjectY = s.Serialize<BALLMODE_EJECTY>(ballMode_EjectY, name: "ballMode_EjectY");
				ballMode_Pass = s.Serialize<BALLMODE_PASS>(ballMode_Pass, name: "ballMode_Pass");
				angleDir_ShotBasic = s.SerializeObject<Angle>(angleDir_ShotBasic, name: "angleDir_ShotBasic");
				angleDir_ShotCrush = s.SerializeObject<Angle>(angleDir_ShotCrush, name: "angleDir_ShotCrush");
				angleDir_ShotUp = s.SerializeObject<Angle>(angleDir_ShotUp, name: "angleDir_ShotUp");
				angleDir_ShotCharge = s.SerializeObject<Angle>(angleDir_ShotCharge, name: "angleDir_ShotCharge");
				angleDir_EjectY = s.SerializeObject<Angle>(angleDir_EjectY, name: "angleDir_EjectY");
				angleDir_Pass = s.SerializeObject<Angle>(angleDir_Pass, name: "angleDir_Pass");
				angleDirAlt_ShotBasic = s.SerializeObject<Angle>(angleDirAlt_ShotBasic, name: "angleDirAlt_ShotBasic");
				angleDirAlt_ShotCrush = s.SerializeObject<Angle>(angleDirAlt_ShotCrush, name: "angleDirAlt_ShotCrush");
				angleDirAlt_ShotUp = s.SerializeObject<Angle>(angleDirAlt_ShotUp, name: "angleDirAlt_ShotUp");
				angleDirAlt_EjectY = s.SerializeObject<Angle>(angleDirAlt_EjectY, name: "angleDirAlt_EjectY");
				angleDirAlt_Pass = s.SerializeObject<Angle>(angleDirAlt_Pass, name: "angleDirAlt_Pass");
				bounceCoefPass_x = s.Serialize<float>(bounceCoefPass_x, name: "bounceCoefPass_x");
				bounceCoefPass_y = s.Serialize<float>(bounceCoefPass_y, name: "bounceCoefPass_y");
				bounceCoefRoof = s.Serialize<float>(bounceCoefRoof, name: "bounceCoefRoof");
				playerCol_Enabled = s.Serialize<bool>(playerCol_Enabled, name: "playerCol_Enabled");
				playerCol_ShapeRadius = s.Serialize<float>(playerCol_ShapeRadius, name: "playerCol_ShapeRadius");
				playerCol_DisabledWhileHitting = s.Serialize<bool>(playerCol_DisabledWhileHitting, name: "playerCol_DisabledWhileHitting");
				playerCol_AfterHitDisabledTimer = s.Serialize<float>(playerCol_AfterHitDisabledTimer, name: "playerCol_AfterHitDisabledTimer");
				isLethal_ShotBasic = s.Serialize<bool>(isLethal_ShotBasic, name: "isLethal_ShotBasic");
				isLethal_ShotCrush = s.Serialize<bool>(isLethal_ShotCrush, name: "isLethal_ShotCrush");
				isLethal_ShotUp = s.Serialize<bool>(isLethal_ShotUp, name: "isLethal_ShotUp");
				isLethal_ShotCharge = s.Serialize<bool>(isLethal_ShotCharge, name: "isLethal_ShotCharge");
				isLethal_EjectY = s.Serialize<bool>(isLethal_EjectY, name: "isLethal_EjectY");
				isLethal_Pass = s.Serialize<bool>(isLethal_Pass, name: "isLethal_Pass");
				forceMin_x = s.Serialize<float>(forceMin_x, name: "forceMin_x");
				forceMax_x = s.Serialize<float>(forceMax_x, name: "forceMax_x");
				forceMin_y = s.Serialize<float>(forceMin_y, name: "forceMin_y");
				forceMax_y = s.Serialize<float>(forceMax_y, name: "forceMax_y");
				receivedHitType_ShotBasic = s.Serialize<RECEIVEDHITTYPE>(receivedHitType_ShotBasic, name: "receivedHitType_ShotBasic");
				receivedHitType_ShotCrush = s.Serialize<RECEIVEDHITTYPE>(receivedHitType_ShotCrush, name: "receivedHitType_ShotCrush");
				receivedHitType_ShotUp = s.Serialize<RECEIVEDHITTYPE>(receivedHitType_ShotUp, name: "receivedHitType_ShotUp");
				receivedHitType_ShotCharge = s.Serialize<RECEIVEDHITTYPE>(receivedHitType_ShotCharge, name: "receivedHitType_ShotCharge");
				receivedHitType_EjectY = s.Serialize<RECEIVEDHITTYPE>(receivedHitType_EjectY, name: "receivedHitType_EjectY");
				receivedHitType_Pass = s.Serialize<RECEIVEDHITTYPE>(receivedHitType_Pass, name: "receivedHitType_Pass");
				hitLevel_ShotBasic = s.Serialize<uint>(hitLevel_ShotBasic, name: "hitLevel_ShotBasic");
				hitLevel_ShotCrush = s.Serialize<uint>(hitLevel_ShotCrush, name: "hitLevel_ShotCrush");
				hitLevel_ShotUp = s.Serialize<uint>(hitLevel_ShotUp, name: "hitLevel_ShotUp");
				hitLevel_ShotCharge = s.Serialize<uint>(hitLevel_ShotCharge, name: "hitLevel_ShotCharge");
				hitLevel_EjectY = s.Serialize<uint>(hitLevel_EjectY, name: "hitLevel_EjectY");
				hitLevel_Pass = s.Serialize<uint>(hitLevel_Pass, name: "hitLevel_Pass");
				hitDelay = s.Serialize<float>(hitDelay, name: "hitDelay");
				blockingEdgeTimer = s.Serialize<float>(blockingEdgeTimer, name: "blockingEdgeTimer");
				minTime_Pass = s.Serialize<float>(minTime_Pass, name: "minTime_Pass");
				angleAltChoice_ShotBasic = s.SerializeObject<Angle>(angleAltChoice_ShotBasic, name: "angleAltChoice_ShotBasic");
				angleAltChoice_ShotCrush = s.SerializeObject<Angle>(angleAltChoice_ShotCrush, name: "angleAltChoice_ShotCrush");
				angleAltChoice_ShotUp = s.SerializeObject<Angle>(angleAltChoice_ShotUp, name: "angleAltChoice_ShotUp");
				angleAltChoice_ShotCharge = s.SerializeObject<Angle>(angleAltChoice_ShotCharge, name: "angleAltChoice_ShotCharge");
				angleAltChoice_EjectY = s.SerializeObject<Angle>(angleAltChoice_EjectY, name: "angleAltChoice_EjectY");
				angleAltChoice_Pass = s.SerializeObject<Angle>(angleAltChoice_Pass, name: "angleAltChoice_Pass");
				joyTrameMax = s.Serialize<uint>(joyTrameMax, name: "joyTrameMax");
				impulseForceMegaHit_ShotBasic = s.Serialize<float>(impulseForceMegaHit_ShotBasic, name: "impulseForceMegaHit_ShotBasic");
				impulseForceMegaHit_ShotCrush = s.Serialize<float>(impulseForceMegaHit_ShotCrush, name: "impulseForceMegaHit_ShotCrush");
				impulseForceMegaHit_ShotUp = s.Serialize<float>(impulseForceMegaHit_ShotUp, name: "impulseForceMegaHit_ShotUp");
				impulseForceMegaHit_ShotCharge = s.Serialize<float>(impulseForceMegaHit_ShotCharge, name: "impulseForceMegaHit_ShotCharge");
				impulseForceMegaHit_EjectY = s.Serialize<float>(impulseForceMegaHit_EjectY, name: "impulseForceMegaHit_EjectY");
				impulseForceMegaHit_Pass = s.Serialize<float>(impulseForceMegaHit_Pass, name: "impulseForceMegaHit_Pass");
				cameraRegisterDelay = s.Serialize<float>(cameraRegisterDelay, name: "cameraRegisterDelay");
				megaHitCounterEnabled = s.Serialize<bool>(megaHitCounterEnabled, name: "megaHitCounterEnabled");
				buildMegaHitEnabled_ShotBasic = s.Serialize<bool>(buildMegaHitEnabled_ShotBasic, name: "buildMegaHitEnabled_ShotBasic");
				buildMegaHitEnabled_ShotCrush = s.Serialize<bool>(buildMegaHitEnabled_ShotCrush, name: "buildMegaHitEnabled_ShotCrush");
				buildMegaHitEnabled_ShotUp = s.Serialize<bool>(buildMegaHitEnabled_ShotUp, name: "buildMegaHitEnabled_ShotUp");
				buildMegaHitEnabled_ShotCharge = s.Serialize<bool>(buildMegaHitEnabled_ShotCharge, name: "buildMegaHitEnabled_ShotCharge");
				buildMegaHitEnabled_EjectY = s.Serialize<bool>(buildMegaHitEnabled_EjectY, name: "buildMegaHitEnabled_EjectY");
				buildMegaHitEnabled_Pass = s.Serialize<bool>(buildMegaHitEnabled_Pass, name: "buildMegaHitEnabled_Pass");
				hitCountForMegaHit = s.Serialize<uint>(hitCountForMegaHit, name: "hitCountForMegaHit");
				stretchAnimSpeedMin = s.Serialize<float>(stretchAnimSpeedMin, name: "stretchAnimSpeedMin");
				animHaloTimer = s.Serialize<float>(animHaloTimer, name: "animHaloTimer");
				crushGroundImmuneDuration = s.Serialize<float>(crushGroundImmuneDuration, name: "crushGroundImmuneDuration");
				megaHitForce = s.Serialize<float>(megaHitForce, name: "megaHitForce");
				drcTapForce = s.Serialize<float>(drcTapForce, name: "drcTapForce");
				faction = s.Serialize<uint>(faction, name: "faction");
				playerHitLifeTime = s.Serialize<float>(playerHitLifeTime, name: "playerHitLifeTime");
			} else {
				impulseForce_Ground = s.Serialize<float>(impulseForce_Ground, name: "impulseForce_Ground");
				impulseForce_Wall = s.Serialize<float>(impulseForce_Wall, name: "impulseForce_Wall");
				impulseForce_Hit = s.Serialize<float>(impulseForce_Hit, name: "impulseForce_Hit");
				impulseForce_ShotBasic = s.Serialize<float>(impulseForce_ShotBasic, name: "impulseForce_ShotBasic");
				impulseForce_ShotCrush = s.Serialize<float>(impulseForce_ShotCrush, name: "impulseForce_ShotCrush");
				impulseForce_ShotUp = s.Serialize<float>(impulseForce_ShotUp, name: "impulseForce_ShotUp");
				impulseForce_ShotCharge = s.Serialize<float>(impulseForce_ShotCharge, name: "impulseForce_ShotCharge");
				impulseForce_EjectY = s.Serialize<float>(impulseForce_EjectY, name: "impulseForce_EjectY");
				impulseForce_Pass = s.Serialize<float>(impulseForce_Pass, name: "impulseForce_Pass");
				bounceCoefMin_x = s.Serialize<float>(bounceCoefMin_x, name: "bounceCoefMin_x");
				bounceCoefMin_y = s.Serialize<float>(bounceCoefMin_y, name: "bounceCoefMin_y");
				bounceCoefFactor_x = s.Serialize<float>(bounceCoefFactor_x, name: "bounceCoefFactor_x");
				bounceCoefFactor_y = s.Serialize<float>(bounceCoefFactor_y, name: "bounceCoefFactor_y");
				bounceDotUpLimit = s.Serialize<float>(bounceDotUpLimit, name: "bounceDotUpLimit");
				bounceDotDownLimit = s.Serialize<float>(bounceDotDownLimit, name: "bounceDotDownLimit");
				bounceCoefMax_x = s.Serialize<float>(bounceCoefMax_x, name: "bounceCoefMax_x");
				bounceCoefMax_y = s.Serialize<float>(bounceCoefMax_y, name: "bounceCoefMax_y");
				ballMode_ShotBasic = s.Serialize<BALLMODE_SHOTBASIC>(ballMode_ShotBasic, name: "ballMode_ShotBasic");
				ballMode_ShotCrush = s.Serialize<BALLMODE_SHOTCRUSH>(ballMode_ShotCrush, name: "ballMode_ShotCrush");
				ballMode_ShotUp = s.Serialize<BALLMODE_SHOTUP>(ballMode_ShotUp, name: "ballMode_ShotUp");
				ballMode_ShotCharge = s.Serialize<BALLMODE_SHOTCHARGE>(ballMode_ShotCharge, name: "ballMode_ShotCharge");
				ballMode_EjectY = s.Serialize<BALLMODE_EJECTY>(ballMode_EjectY, name: "ballMode_EjectY");
				ballMode_Pass = s.Serialize<BALLMODE_PASS>(ballMode_Pass, name: "ballMode_Pass");
				angleDir_ShotBasic = s.SerializeObject<Angle>(angleDir_ShotBasic, name: "angleDir_ShotBasic");
				angleDir_ShotCrush = s.SerializeObject<Angle>(angleDir_ShotCrush, name: "angleDir_ShotCrush");
				angleDir_ShotUp = s.SerializeObject<Angle>(angleDir_ShotUp, name: "angleDir_ShotUp");
				angleDir_ShotCharge = s.SerializeObject<Angle>(angleDir_ShotCharge, name: "angleDir_ShotCharge");
				angleDir_EjectY = s.SerializeObject<Angle>(angleDir_EjectY, name: "angleDir_EjectY");
				angleDir_Pass = s.SerializeObject<Angle>(angleDir_Pass, name: "angleDir_Pass");
				angleDirAlt_ShotBasic = s.SerializeObject<Angle>(angleDirAlt_ShotBasic, name: "angleDirAlt_ShotBasic");
				angleDirAlt_ShotCrush = s.SerializeObject<Angle>(angleDirAlt_ShotCrush, name: "angleDirAlt_ShotCrush");
				angleDirAlt_ShotUp = s.SerializeObject<Angle>(angleDirAlt_ShotUp, name: "angleDirAlt_ShotUp");
				angleDirAlt_EjectY = s.SerializeObject<Angle>(angleDirAlt_EjectY, name: "angleDirAlt_EjectY");
				angleDirAlt_Pass = s.SerializeObject<Angle>(angleDirAlt_Pass, name: "angleDirAlt_Pass");
				bounceCoefPass_x = s.Serialize<float>(bounceCoefPass_x, name: "bounceCoefPass_x");
				bounceCoefPass_y = s.Serialize<float>(bounceCoefPass_y, name: "bounceCoefPass_y");
				bounceCoefRoof = s.Serialize<float>(bounceCoefRoof, name: "bounceCoefRoof");
				playerCol_Enabled = s.Serialize<bool>(playerCol_Enabled, name: "playerCol_Enabled");
				playerCol_ShapeRadius = s.Serialize<float>(playerCol_ShapeRadius, name: "playerCol_ShapeRadius");
				playerCol_DisabledWhileHitting = s.Serialize<bool>(playerCol_DisabledWhileHitting, name: "playerCol_DisabledWhileHitting");
				playerCol_AfterHitDisabledTimer = s.Serialize<float>(playerCol_AfterHitDisabledTimer, name: "playerCol_AfterHitDisabledTimer");
				isLethal_ShotBasic = s.Serialize<bool>(isLethal_ShotBasic, name: "isLethal_ShotBasic");
				isLethal_ShotCrush = s.Serialize<bool>(isLethal_ShotCrush, name: "isLethal_ShotCrush");
				isLethal_ShotUp = s.Serialize<bool>(isLethal_ShotUp, name: "isLethal_ShotUp");
				isLethal_ShotCharge = s.Serialize<bool>(isLethal_ShotCharge, name: "isLethal_ShotCharge");
				isLethal_EjectY = s.Serialize<bool>(isLethal_EjectY, name: "isLethal_EjectY");
				isLethal_Pass = s.Serialize<bool>(isLethal_Pass, name: "isLethal_Pass");
				forceMin_x = s.Serialize<float>(forceMin_x, name: "forceMin_x");
				forceMax_x = s.Serialize<float>(forceMax_x, name: "forceMax_x");
				forceMin_y = s.Serialize<float>(forceMin_y, name: "forceMin_y");
				forceMax_y = s.Serialize<float>(forceMax_y, name: "forceMax_y");
				receivedHitType_ShotBasic = s.Serialize<RECEIVEDHITTYPE>(receivedHitType_ShotBasic, name: "receivedHitType_ShotBasic");
				receivedHitType_ShotCrush = s.Serialize<RECEIVEDHITTYPE>(receivedHitType_ShotCrush, name: "receivedHitType_ShotCrush");
				receivedHitType_ShotUp = s.Serialize<RECEIVEDHITTYPE>(receivedHitType_ShotUp, name: "receivedHitType_ShotUp");
				receivedHitType_ShotCharge = s.Serialize<RECEIVEDHITTYPE>(receivedHitType_ShotCharge, name: "receivedHitType_ShotCharge");
				receivedHitType_EjectY = s.Serialize<RECEIVEDHITTYPE>(receivedHitType_EjectY, name: "receivedHitType_EjectY");
				receivedHitType_Pass = s.Serialize<RECEIVEDHITTYPE>(receivedHitType_Pass, name: "receivedHitType_Pass");
				hitLevel_ShotBasic = s.Serialize<uint>(hitLevel_ShotBasic, name: "hitLevel_ShotBasic");
				hitLevel_ShotCrush = s.Serialize<uint>(hitLevel_ShotCrush, name: "hitLevel_ShotCrush");
				hitLevel_ShotUp = s.Serialize<uint>(hitLevel_ShotUp, name: "hitLevel_ShotUp");
				hitLevel_ShotCharge = s.Serialize<uint>(hitLevel_ShotCharge, name: "hitLevel_ShotCharge");
				hitLevel_EjectY = s.Serialize<uint>(hitLevel_EjectY, name: "hitLevel_EjectY");
				hitLevel_Pass = s.Serialize<uint>(hitLevel_Pass, name: "hitLevel_Pass");
				hitDelay = s.Serialize<float>(hitDelay, name: "hitDelay");
				blockingEdgeTimer = s.Serialize<float>(blockingEdgeTimer, name: "blockingEdgeTimer");
				minTime_Pass = s.Serialize<float>(minTime_Pass, name: "minTime_Pass");
				angleAltChoice_ShotBasic = s.SerializeObject<Angle>(angleAltChoice_ShotBasic, name: "angleAltChoice_ShotBasic");
				angleAltChoice_ShotCrush = s.SerializeObject<Angle>(angleAltChoice_ShotCrush, name: "angleAltChoice_ShotCrush");
				angleAltChoice_ShotUp = s.SerializeObject<Angle>(angleAltChoice_ShotUp, name: "angleAltChoice_ShotUp");
				angleAltChoice_ShotCharge = s.SerializeObject<Angle>(angleAltChoice_ShotCharge, name: "angleAltChoice_ShotCharge");
				angleAltChoice_EjectY = s.SerializeObject<Angle>(angleAltChoice_EjectY, name: "angleAltChoice_EjectY");
				angleAltChoice_Pass = s.SerializeObject<Angle>(angleAltChoice_Pass, name: "angleAltChoice_Pass");
				joyTrameMax = s.Serialize<uint>(joyTrameMax, name: "joyTrameMax");
				impulseForceMegaHit_ShotBasic = s.Serialize<float>(impulseForceMegaHit_ShotBasic, name: "impulseForceMegaHit_ShotBasic");
				impulseForceMegaHit_ShotCrush = s.Serialize<float>(impulseForceMegaHit_ShotCrush, name: "impulseForceMegaHit_ShotCrush");
				impulseForceMegaHit_ShotUp = s.Serialize<float>(impulseForceMegaHit_ShotUp, name: "impulseForceMegaHit_ShotUp");
				impulseForceMegaHit_ShotCharge = s.Serialize<float>(impulseForceMegaHit_ShotCharge, name: "impulseForceMegaHit_ShotCharge");
				impulseForceMegaHit_EjectY = s.Serialize<float>(impulseForceMegaHit_EjectY, name: "impulseForceMegaHit_EjectY");
				impulseForceMegaHit_Pass = s.Serialize<float>(impulseForceMegaHit_Pass, name: "impulseForceMegaHit_Pass");
				cameraRegisterDelay = s.Serialize<float>(cameraRegisterDelay, name: "cameraRegisterDelay");
				megaHitCounterEnabled = s.Serialize<bool>(megaHitCounterEnabled, name: "megaHitCounterEnabled");
				buildMegaHitEnabled_ShotBasic = s.Serialize<bool>(buildMegaHitEnabled_ShotBasic, name: "buildMegaHitEnabled_ShotBasic");
				buildMegaHitEnabled_ShotCrush = s.Serialize<bool>(buildMegaHitEnabled_ShotCrush, name: "buildMegaHitEnabled_ShotCrush");
				buildMegaHitEnabled_ShotUp = s.Serialize<bool>(buildMegaHitEnabled_ShotUp, name: "buildMegaHitEnabled_ShotUp");
				buildMegaHitEnabled_ShotCharge = s.Serialize<bool>(buildMegaHitEnabled_ShotCharge, name: "buildMegaHitEnabled_ShotCharge");
				buildMegaHitEnabled_EjectY = s.Serialize<bool>(buildMegaHitEnabled_EjectY, name: "buildMegaHitEnabled_EjectY");
				buildMegaHitEnabled_Pass = s.Serialize<bool>(buildMegaHitEnabled_Pass, name: "buildMegaHitEnabled_Pass");
				hitCountForMegaHit = s.Serialize<uint>(hitCountForMegaHit, name: "hitCountForMegaHit");
				stretchAnimSpeedMin = s.Serialize<float>(stretchAnimSpeedMin, name: "stretchAnimSpeedMin");
				animHaloTimer = s.Serialize<float>(animHaloTimer, name: "animHaloTimer");
				crushGroundImmuneDuration = s.Serialize<float>(crushGroundImmuneDuration, name: "crushGroundImmuneDuration");
				megaHitForce = s.Serialize<float>(megaHitForce, name: "megaHitForce");
				drcTapForce = s.Serialize<float>(drcTapForce, name: "drcTapForce");
				faction = s.Serialize<uint>(faction, name: "faction");
			}
		}
		public enum BALLMODE_SHOTBASIC {
			[Serialize("BALLMODE_SHOTBASIC_POS"    )] POS = 0,
			[Serialize("BALLMODE_SHOTBASIC_HIT"    )] HIT = 1,
			[Serialize("BALLMODE_SHOTBASIC_JOY"    )] JOY = 2,
			[Serialize("BALLMODE_SHOTBASIC_PUREJOY")] PUREJOY = 3,
			[Serialize("BALLMODE_SHOTBASIC_GOAL"   )] GOAL = 4,
		}
		public enum BALLMODE_SHOTCRUSH {
			[Serialize("BALLMODE_SHOTCRUSH_POS"    )] POS = 0,
			[Serialize("BALLMODE_SHOTCRUSH_HIT"    )] HIT = 1,
			[Serialize("BALLMODE_SHOTCRUSH_JOY"    )] JOY = 2,
			[Serialize("BALLMODE_SHOTCRUSH_PUREJOY")] PUREJOY = 3,
			[Serialize("BALLMODE_SHOTCRUSH_GOAL"   )] GOAL = 4,
		}
		public enum BALLMODE_SHOTUP {
			[Serialize("BALLMODE_SHOTUP_POS"    )] POS = 0,
			[Serialize("BALLMODE_SHOTUP_HIT"    )] HIT = 1,
			[Serialize("BALLMODE_SHOTUP_JOY"    )] JOY = 2,
			[Serialize("BALLMODE_SHOTUP_PUREJOY")] PUREJOY = 3,
			[Serialize("BALLMODE_SHOTUP_GOAL"   )] GOAL = 4,
		}
		public enum BALLMODE_SHOTCHARGE {
			[Serialize("BALLMODE_SHOTCHARGE_POS"    )] POS = 0,
			[Serialize("BALLMODE_SHOTCHARGE_HIT"    )] HIT = 1,
			[Serialize("BALLMODE_SHOTCHARGE_JOY"    )] JOY = 2,
			[Serialize("BALLMODE_SHOTCHARGE_PUREJOY")] PUREJOY = 3,
			[Serialize("BALLMODE_SHOTCHARGE_GOAL"   )] GOAL = 4,
		}
		public enum BALLMODE_EJECTY {
			[Serialize("BALLMODE_EJECTY_POS"    )] POS = 0,
			[Serialize("BALLMODE_EJECTY_HIT"    )] HIT = 1,
			[Serialize("BALLMODE_EJECTY_JOY"    )] JOY = 2,
			[Serialize("BALLMODE_EJECTY_PUREJOY")] PUREJOY = 3,
			[Serialize("BALLMODE_EJECTY_GOAL"   )] GOAL = 4,
		}
		public enum BALLMODE_PASS {
			[Serialize("BALLMODE_PASS_SPEED")] SPEED = 0,
			[Serialize("BALLMODE_PASS_SIGHT")] SIGHT = 1,
			[Serialize("BALLMODE_PASS_JOY"  )] JOY = 2,
			[Serialize("BALLMODE_PASS_GOAL" )] GOAL = 3,
		}
		public enum RECEIVEDHITTYPE {
			[Serialize("RECEIVEDHITTYPE_UNKNOWN"    )] UNKNOWN = -1,
			[Serialize("RECEIVEDHITTYPE_FRONTPUNCH" )] FRONTPUNCH = 0,
			[Serialize("RECEIVEDHITTYPE_UPPUNCH"    )] UPPUNCH = 1,
			[Serialize("RECEIVEDHITTYPE_EJECTXY"    )] EJECTXY = 3,
			[Serialize("RECEIVEDHITTYPE_HURTBOUNCE" )] HURTBOUNCE = 4,
			[Serialize("RECEIVEDHITTYPE_DARKTOONIFY")] DARKTOONIFY = 5,
			[Serialize("RECEIVEDHITTYPE_EARTHQUAKE" )] EARTHQUAKE = 6,
			[Serialize("RECEIVEDHITTYPE_SHOOTER"    )] SHOOTER = 7,
		}
		public enum Enum_ballMode_ShotBasic {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public enum Enum_ballMode_Pass {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public override uint? ClassCRC => 0xEB75D38E;
	}
}

