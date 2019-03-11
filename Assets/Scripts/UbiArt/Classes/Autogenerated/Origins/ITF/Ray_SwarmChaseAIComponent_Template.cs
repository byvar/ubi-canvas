using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_SwarmChaseAIComponent_Template : Ray_AIComponent_Template {
		[Serialize("pathAtlas"     )] public Path pathAtlas;
		[Serialize("hitLevel"      )] public uint hitLevel;
		[Serialize("hitType"       )] public RECEIVEDHITTYPE hitType;
		[Serialize("faction"       )] public Enum_faction faction;
		[Serialize("smoothFactor"  )] public float smoothFactor;
		[Serialize("leaderSpeedMin")] public float leaderSpeedMin;
		[Serialize("leaderSpeedMax")] public float leaderSpeedMax;
		[Serialize("distMaxFromCam")] public float distMaxFromCam;
		[Serialize("countParticles")] public uint countParticles;
		[Serialize("sizeParticles" )] public float sizeParticles;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(pathAtlas));
			SerializeField(s, nameof(hitLevel));
			SerializeField(s, nameof(hitType));
			SerializeField(s, nameof(faction));
			SerializeField(s, nameof(smoothFactor));
			SerializeField(s, nameof(leaderSpeedMin));
			SerializeField(s, nameof(leaderSpeedMax));
			SerializeField(s, nameof(distMaxFromCam));
			SerializeField(s, nameof(countParticles));
			SerializeField(s, nameof(sizeParticles));
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
			[Serialize("FACTION_UNKNOWN"                     )] FACTION_UNKNOWN = -1,
			[Serialize("RAY_FACTION_NEUTRAL"                 )] RAY_FACTION_NEUTRAL = 0,
			[Serialize("RAY_FACTION_FRIENDLY"                )] RAY_FACTION_FRIENDLY = 1,
			[Serialize("RAY_FACTION_ENEMY"                   )] RAY_FACTION_ENEMY = 2,
			[Serialize("RAY_FACTION_MEGAENEMY"               )] RAY_FACTION_MEGAENEMY = 3,
			[Serialize("RAY_FACTION_DARKTOON"                )] RAY_FACTION_DARKTOON = 4,
			[Serialize("RAY_FACTION_FISH"                    )] RAY_FACTION_FISH = 5,
			[Serialize("RAY_FACTION_DARKTOONWALL"            )] RAY_FACTION_DARKTOONWALL = 6,
			[Serialize("RAY_FACTION_PLUM"                    )] RAY_FACTION_PLUM = 7,
			[Serialize("RAY_FACTION_BREAKABLE"               )] RAY_FACTION_BREAKABLE = 8,
			[Serialize("RAY_FACTION_PLAYER"                  )] RAY_FACTION_PLAYER = 9,
			[Serialize("RAY_FACTION_BOMBDEFUSED"             )] RAY_FACTION_BOMBDEFUSED = 10,
			[Serialize("RAY_FACTION_RELICCHEST"              )] RAY_FACTION_RELICCHEST = 11,
			[Serialize("RAY_FACTION_GHOST"                   )] RAY_FACTION_GHOST = 12,
			[Serialize("RAY_FACTION_ELECTOON"                )] RAY_FACTION_ELECTOON = 13,
			[Serialize("RAY_FACTION_BOSSMORAY"               )] RAY_FACTION_BOSSMORAY = 14,
			[Serialize("RAY_FACTION_BUMPER"                  )] RAY_FACTION_BUMPER = 15,
			[Serialize("RAY_FACTION_PROJECTILE"              )] RAY_FACTION_PROJECTILE = 16,
			[Serialize("RAY_FACTION_EXPLOSION"               )] RAY_FACTION_EXPLOSION = 19,
			[Serialize("RAY_FACTION_BLOWFISH"                )] RAY_FACTION_BLOWFISH = 20,
			[Serialize("RAY_FACTION_BUBBLE"                  )] RAY_FACTION_BUBBLE = 21,
			[Serialize("RAY_FACTION_ENEMYBULLET"             )] RAY_FACTION_ENEMYBULLET = 22,
			[Serialize("RAY_FACTION_MEGAENEMYEXCEPTBREAKABLE")] RAY_FACTION_MEGAENEMYEXCEPTBREAKABLE = 23,
		}
		public override uint? ClassCRC => 0xF00CF28D;
	}
}

