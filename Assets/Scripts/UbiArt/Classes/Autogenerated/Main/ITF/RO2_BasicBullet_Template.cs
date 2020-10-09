using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BasicBullet_Template : CSerializable {
		public Generic<PhysShape> stimShape;
		public Generic<PhysShape> envContactShape;
		public Enum_faction faction;
		public float lifetime;
		public uint numHits;
		public bool skipSuccessiveHits;
		public RECEIVEDHITTYPE hitType;
		public uint hitLevel;
		public float hitCosAngle;
		public bool destroyOnExitScreen;
		public bool destroyOnEnvironment;
		public bool checkEnvironmentHit;
		public bool checkEnvironment;
		public Vec2d defaultSpeed;
		public float rotationSpeed;
		public bool allowBounce;
		public uint bounceMaxNb;
		public bool cameraRelative;
		public bool autoSeek;
		public float autoSeekStartDelay;
		public float autoSeekRefreshDelay;
		public float autoSeekRange;
		public Angle autoSeekMaxTurnAngle;
		public StringID fxNameImpact;
		public StringID fxNameBounce;
		public StringID fxNamePaf;
		public StringID fxNameDeath;
		public bool fxKillAllBefore;
		public bool allowOwnerKill;
		public float ownerKillSafeTime;
		public bool receiveHit;
		public bool obsoleteOnHit;
		public bool reboundOnHit;
		public bool debug;
		public bool useOutScreenTimer;
		public bool hitNonSolidPhantoms;
		public bool destroyOnDigRegion;
		public bool disablePhantomOnStand;
		public StringID fxNameTrail;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				stimShape = s.SerializeObject<Generic<PhysShape>>(stimShape, name: "stimShape");
				envContactShape = s.SerializeObject<Generic<PhysShape>>(envContactShape, name: "envContactShape");
				faction = s.Serialize<Enum_faction>(faction, name: "faction");
				lifetime = s.Serialize<float>(lifetime, name: "lifetime");
				numHits = s.Serialize<uint>(numHits, name: "numHits");
				skipSuccessiveHits = s.Serialize<bool>(skipSuccessiveHits, name: "skipSuccessiveHits");
				hitType = s.Serialize<RECEIVEDHITTYPE>(hitType, name: "hitType");
				hitLevel = s.Serialize<uint>(hitLevel, name: "hitLevel");
				hitCosAngle = s.Serialize<float>(hitCosAngle, name: "hitCosAngle");
				destroyOnExitScreen = s.Serialize<bool>(destroyOnExitScreen, name: "destroyOnExitScreen");
				destroyOnEnvironment = s.Serialize<bool>(destroyOnEnvironment, name: "destroyOnEnvironment");
				checkEnvironmentHit = s.Serialize<bool>(checkEnvironmentHit, name: "checkEnvironmentHit");
				checkEnvironment = s.Serialize<bool>(checkEnvironment, name: "checkEnvironment");
				defaultSpeed = s.SerializeObject<Vec2d>(defaultSpeed, name: "defaultSpeed");
				rotationSpeed = s.Serialize<float>(rotationSpeed, name: "rotationSpeed");
				allowBounce = s.Serialize<bool>(allowBounce, name: "allowBounce");
				bounceMaxNb = s.Serialize<uint>(bounceMaxNb, name: "bounceMaxNb");
				cameraRelative = s.Serialize<bool>(cameraRelative, name: "cameraRelative");
				autoSeek = s.Serialize<bool>(autoSeek, name: "autoSeek");
				autoSeekStartDelay = s.Serialize<float>(autoSeekStartDelay, name: "autoSeekStartDelay");
				autoSeekRefreshDelay = s.Serialize<float>(autoSeekRefreshDelay, name: "autoSeekRefreshDelay");
				autoSeekRange = s.Serialize<float>(autoSeekRange, name: "autoSeekRange");
				autoSeekMaxTurnAngle = s.SerializeObject<Angle>(autoSeekMaxTurnAngle, name: "autoSeekMaxTurnAngle");
				fxNameImpact = s.SerializeObject<StringID>(fxNameImpact, name: "fxNameImpact");
				fxNameBounce = s.SerializeObject<StringID>(fxNameBounce, name: "fxNameBounce");
				fxNamePaf = s.SerializeObject<StringID>(fxNamePaf, name: "fxNamePaf");
				fxNameDeath = s.SerializeObject<StringID>(fxNameDeath, name: "fxNameDeath");
				fxKillAllBefore = s.Serialize<bool>(fxKillAllBefore, name: "fxKillAllBefore");
				allowOwnerKill = s.Serialize<bool>(allowOwnerKill, name: "allowOwnerKill");
				ownerKillSafeTime = s.Serialize<float>(ownerKillSafeTime, name: "ownerKillSafeTime");
				receiveHit = s.Serialize<bool>(receiveHit, name: "receiveHit");
				obsoleteOnHit = s.Serialize<bool>(obsoleteOnHit, name: "obsoleteOnHit");
				reboundOnHit = s.Serialize<bool>(reboundOnHit, name: "reboundOnHit");
				debug = s.Serialize<bool>(debug, name: "debug");
				useOutScreenTimer = s.Serialize<bool>(useOutScreenTimer, name: "useOutScreenTimer");
				hitNonSolidPhantoms = s.Serialize<bool>(hitNonSolidPhantoms, name: "hitNonSolidPhantoms");
				destroyOnDigRegion = s.Serialize<bool>(destroyOnDigRegion, name: "destroyOnDigRegion");
				disablePhantomOnStand = s.Serialize<bool>(disablePhantomOnStand, name: "disablePhantomOnStand");
				fxNameTrail = s.SerializeObject<StringID>(fxNameTrail, name: "fxNameTrail");
			} else {
				stimShape = s.SerializeObject<Generic<PhysShape>>(stimShape, name: "stimShape");
				envContactShape = s.SerializeObject<Generic<PhysShape>>(envContactShape, name: "envContactShape");
				faction = s.Serialize<Enum_faction>(faction, name: "faction");
				lifetime = s.Serialize<float>(lifetime, name: "lifetime");
				numHits = s.Serialize<uint>(numHits, name: "numHits");
				skipSuccessiveHits = s.Serialize<bool>(skipSuccessiveHits, name: "skipSuccessiveHits");
				hitType = s.Serialize<RECEIVEDHITTYPE>(hitType, name: "hitType");
				hitLevel = s.Serialize<uint>(hitLevel, name: "hitLevel");
				hitCosAngle = s.Serialize<float>(hitCosAngle, name: "hitCosAngle");
				destroyOnExitScreen = s.Serialize<bool>(destroyOnExitScreen, name: "destroyOnExitScreen");
				destroyOnEnvironment = s.Serialize<bool>(destroyOnEnvironment, name: "destroyOnEnvironment");
				checkEnvironmentHit = s.Serialize<bool>(checkEnvironmentHit, name: "checkEnvironmentHit");
				checkEnvironment = s.Serialize<bool>(checkEnvironment, name: "checkEnvironment");
				defaultSpeed = s.SerializeObject<Vec2d>(defaultSpeed, name: "defaultSpeed");
				rotationSpeed = s.Serialize<float>(rotationSpeed, name: "rotationSpeed");
				allowBounce = s.Serialize<bool>(allowBounce, name: "allowBounce");
				bounceMaxNb = s.Serialize<uint>(bounceMaxNb, name: "bounceMaxNb");
				cameraRelative = s.Serialize<bool>(cameraRelative, name: "cameraRelative");
				autoSeek = s.Serialize<bool>(autoSeek, name: "autoSeek");
				autoSeekStartDelay = s.Serialize<float>(autoSeekStartDelay, name: "autoSeekStartDelay");
				autoSeekRefreshDelay = s.Serialize<float>(autoSeekRefreshDelay, name: "autoSeekRefreshDelay");
				autoSeekRange = s.Serialize<float>(autoSeekRange, name: "autoSeekRange");
				autoSeekMaxTurnAngle = s.SerializeObject<Angle>(autoSeekMaxTurnAngle, name: "autoSeekMaxTurnAngle");
				fxNameImpact = s.SerializeObject<StringID>(fxNameImpact, name: "fxNameImpact");
				fxNameBounce = s.SerializeObject<StringID>(fxNameBounce, name: "fxNameBounce");
				fxNamePaf = s.SerializeObject<StringID>(fxNamePaf, name: "fxNamePaf");
				fxNameDeath = s.SerializeObject<StringID>(fxNameDeath, name: "fxNameDeath");
				fxKillAllBefore = s.Serialize<bool>(fxKillAllBefore, name: "fxKillAllBefore");
				allowOwnerKill = s.Serialize<bool>(allowOwnerKill, name: "allowOwnerKill");
				ownerKillSafeTime = s.Serialize<float>(ownerKillSafeTime, name: "ownerKillSafeTime");
				receiveHit = s.Serialize<bool>(receiveHit, name: "receiveHit");
				obsoleteOnHit = s.Serialize<bool>(obsoleteOnHit, name: "obsoleteOnHit");
				reboundOnHit = s.Serialize<bool>(reboundOnHit, name: "reboundOnHit");
				debug = s.Serialize<bool>(debug, name: "debug");
				useOutScreenTimer = s.Serialize<bool>(useOutScreenTimer, name: "useOutScreenTimer");
				hitNonSolidPhantoms = s.Serialize<bool>(hitNonSolidPhantoms, name: "hitNonSolidPhantoms");
				destroyOnDigRegion = s.Serialize<bool>(destroyOnDigRegion, name: "destroyOnDigRegion");
				disablePhantomOnStand = s.Serialize<bool>(disablePhantomOnStand, name: "disablePhantomOnStand");
			}
		}
		public enum Enum_faction {
			[Serialize("FACTION_UNKNOWN"     )] FACTION_UNKNOWN = -1,
			[Serialize("RO2_FACTION_NEUTRAL" )] RO2_FACTION_NEUTRAL = 0,
			[Serialize("RO2_FACTION_FRIENDLY")] RO2_FACTION_FRIENDLY = 1,
			[Serialize("RO2_FACTION_ENEMY"   )] RO2_FACTION_ENEMY = 2,
			[Serialize("RO2_FACTION_PLAYER"  )] RO2_FACTION_PLAYER = 3,
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
		public override uint? ClassCRC => 0x5FF281B3;
	}
}

