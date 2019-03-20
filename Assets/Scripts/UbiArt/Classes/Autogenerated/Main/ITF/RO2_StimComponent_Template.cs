using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_StimComponent_Template : ShapeComponent_Template {
		[Serialize("faction"            )] public RO2_FACTION faction;
		[Serialize("useFixedAngle"      )] public bool useFixedAngle;
		[Serialize("fixedAngle"         )] public Angle fixedAngle;
		[Serialize("localAngleOffset"   )] public Angle localAngleOffset;
		[Serialize("hitType"            )] public RECEIVEDHITTYPE hitType;
		[Serialize("hitLevel"           )] public uint hitLevel;
		[Serialize("hitRadial"          )] public bool hitRadial;
		[Serialize("useNormal"          )] public bool useNormal;
		[Serialize("registerToAIManager")] public bool registerToAIManager;
		[Serialize("useOutOfScreenOptim")] public bool useOutOfScreenOptim;
		[Serialize("hitEnemiesOnce"     )] public bool hitEnemiesOnce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(faction));
			SerializeField(s, nameof(useFixedAngle));
			SerializeField(s, nameof(fixedAngle));
			SerializeField(s, nameof(localAngleOffset));
			SerializeField(s, nameof(hitType));
			SerializeField(s, nameof(hitLevel));
			SerializeField(s, nameof(hitRadial));
			SerializeField(s, nameof(useNormal));
			SerializeField(s, nameof(registerToAIManager));
			SerializeField(s, nameof(useOutOfScreenOptim));
			SerializeField(s, nameof(hitEnemiesOnce));
		}
		public enum RO2_FACTION {
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
		public override uint? ClassCRC => 0xC66D6581;
	}
}

