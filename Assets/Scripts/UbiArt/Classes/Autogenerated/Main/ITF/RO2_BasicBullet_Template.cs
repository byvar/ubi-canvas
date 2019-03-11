using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BasicBullet_Template : CSerializable {
		[Serialize("stimShape"            )] public Generic<PhysShape> stimShape;
		[Serialize("envContactShape"      )] public Generic<PhysShape> envContactShape;
		[Serialize("faction"              )] public Enum_faction faction;
		[Serialize("lifetime"             )] public float lifetime;
		[Serialize("numHits"              )] public uint numHits;
		[Serialize("skipSuccessiveHits"   )] public bool skipSuccessiveHits;
		[Serialize("hitType"              )] public RECEIVEDHITTYPE hitType;
		[Serialize("hitLevel"             )] public uint hitLevel;
		[Serialize("hitCosAngle"          )] public float hitCosAngle;
		[Serialize("destroyOnExitScreen"  )] public bool destroyOnExitScreen;
		[Serialize("destroyOnEnvironment" )] public bool destroyOnEnvironment;
		[Serialize("checkEnvironmentHit"  )] public bool checkEnvironmentHit;
		[Serialize("checkEnvironment"     )] public bool checkEnvironment;
		[Serialize("defaultSpeed"         )] public Vector2 defaultSpeed;
		[Serialize("rotationSpeed"        )] public float rotationSpeed;
		[Serialize("allowBounce"          )] public bool allowBounce;
		[Serialize("bounceMaxNb"          )] public uint bounceMaxNb;
		[Serialize("cameraRelative"       )] public bool cameraRelative;
		[Serialize("autoSeek"             )] public bool autoSeek;
		[Serialize("autoSeekStartDelay"   )] public float autoSeekStartDelay;
		[Serialize("autoSeekRefreshDelay" )] public float autoSeekRefreshDelay;
		[Serialize("autoSeekRange"        )] public float autoSeekRange;
		[Serialize("autoSeekMaxTurnAngle" )] public Angle autoSeekMaxTurnAngle;
		[Serialize("fxNameImpact"         )] public StringID fxNameImpact;
		[Serialize("fxNameBounce"         )] public StringID fxNameBounce;
		[Serialize("fxNamePaf"            )] public StringID fxNamePaf;
		[Serialize("fxNameDeath"          )] public StringID fxNameDeath;
		[Serialize("fxKillAllBefore"      )] public bool fxKillAllBefore;
		[Serialize("allowOwnerKill"       )] public bool allowOwnerKill;
		[Serialize("ownerKillSafeTime"    )] public float ownerKillSafeTime;
		[Serialize("receiveHit"           )] public bool receiveHit;
		[Serialize("obsoleteOnHit"        )] public bool obsoleteOnHit;
		[Serialize("reboundOnHit"         )] public bool reboundOnHit;
		[Serialize("debug"                )] public bool debug;
		[Serialize("useOutScreenTimer"    )] public bool useOutScreenTimer;
		[Serialize("hitNonSolidPhantoms"  )] public bool hitNonSolidPhantoms;
		[Serialize("destroyOnDigRegion"   )] public bool destroyOnDigRegion;
		[Serialize("disablePhantomOnStand")] public bool disablePhantomOnStand;
		[Serialize("hitType"              )] public Enum_hitType hitType;
		[Serialize("fxNameTrail"          )] public StringID fxNameTrail;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(stimShape));
				SerializeField(s, nameof(envContactShape));
				SerializeField(s, nameof(faction));
				SerializeField(s, nameof(lifetime));
				SerializeField(s, nameof(numHits));
				SerializeField(s, nameof(skipSuccessiveHits));
				SerializeField(s, nameof(hitType));
				SerializeField(s, nameof(hitLevel));
				SerializeField(s, nameof(hitCosAngle));
				SerializeField(s, nameof(destroyOnExitScreen));
				SerializeField(s, nameof(destroyOnEnvironment));
				SerializeField(s, nameof(checkEnvironmentHit));
				SerializeField(s, nameof(checkEnvironment));
				SerializeField(s, nameof(defaultSpeed));
				SerializeField(s, nameof(rotationSpeed));
				SerializeField(s, nameof(allowBounce));
				SerializeField(s, nameof(bounceMaxNb));
				SerializeField(s, nameof(cameraRelative));
				SerializeField(s, nameof(autoSeek));
				SerializeField(s, nameof(autoSeekStartDelay));
				SerializeField(s, nameof(autoSeekRefreshDelay));
				SerializeField(s, nameof(autoSeekRange));
				SerializeField(s, nameof(autoSeekMaxTurnAngle));
				SerializeField(s, nameof(fxNameImpact));
				SerializeField(s, nameof(fxNameBounce));
				SerializeField(s, nameof(fxNamePaf));
				SerializeField(s, nameof(fxNameDeath));
				SerializeField(s, nameof(fxKillAllBefore));
				SerializeField(s, nameof(allowOwnerKill));
				SerializeField(s, nameof(ownerKillSafeTime));
				SerializeField(s, nameof(receiveHit));
				SerializeField(s, nameof(obsoleteOnHit));
				SerializeField(s, nameof(reboundOnHit));
				SerializeField(s, nameof(debug));
				SerializeField(s, nameof(useOutScreenTimer));
				SerializeField(s, nameof(hitNonSolidPhantoms));
				SerializeField(s, nameof(destroyOnDigRegion));
				SerializeField(s, nameof(disablePhantomOnStand));
				SerializeField(s, nameof(fxNameTrail));
			} else {
				SerializeField(s, nameof(stimShape));
				SerializeField(s, nameof(envContactShape));
				SerializeField(s, nameof(faction));
				SerializeField(s, nameof(lifetime));
				SerializeField(s, nameof(numHits));
				SerializeField(s, nameof(skipSuccessiveHits));
				SerializeField(s, nameof(hitType));
				SerializeField(s, nameof(hitLevel));
				SerializeField(s, nameof(hitCosAngle));
				SerializeField(s, nameof(destroyOnExitScreen));
				SerializeField(s, nameof(destroyOnEnvironment));
				SerializeField(s, nameof(checkEnvironmentHit));
				SerializeField(s, nameof(checkEnvironment));
				SerializeField(s, nameof(defaultSpeed));
				SerializeField(s, nameof(rotationSpeed));
				SerializeField(s, nameof(allowBounce));
				SerializeField(s, nameof(bounceMaxNb));
				SerializeField(s, nameof(cameraRelative));
				SerializeField(s, nameof(autoSeek));
				SerializeField(s, nameof(autoSeekStartDelay));
				SerializeField(s, nameof(autoSeekRefreshDelay));
				SerializeField(s, nameof(autoSeekRange));
				SerializeField(s, nameof(autoSeekMaxTurnAngle));
				SerializeField(s, nameof(fxNameImpact));
				SerializeField(s, nameof(fxNameBounce));
				SerializeField(s, nameof(fxNamePaf));
				SerializeField(s, nameof(fxNameDeath));
				SerializeField(s, nameof(fxKillAllBefore));
				SerializeField(s, nameof(allowOwnerKill));
				SerializeField(s, nameof(ownerKillSafeTime));
				SerializeField(s, nameof(receiveHit));
				SerializeField(s, nameof(obsoleteOnHit));
				SerializeField(s, nameof(reboundOnHit));
				SerializeField(s, nameof(debug));
				SerializeField(s, nameof(useOutScreenTimer));
				SerializeField(s, nameof(hitNonSolidPhantoms));
				SerializeField(s, nameof(destroyOnDigRegion));
				SerializeField(s, nameof(disablePhantomOnStand));
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
		public enum Enum_faction {
			[Serialize("Value__1")] Value__1 = -1,
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_3" )] Value_3 = 3,
		}
		public enum Enum_hitType {
			[Serialize("Value__1")] Value__1 = -1,
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value_7" )] Value_7 = 7,
		}
		public override uint? ClassCRC => 0x5FF281B3;
	}
}

