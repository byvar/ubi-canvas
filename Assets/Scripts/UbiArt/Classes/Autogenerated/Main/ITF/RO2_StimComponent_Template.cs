using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_StimComponent_Template : ShapeComponent_Template {
		public RO2_FACTION faction;
		public bool useFixedAngle;
		public Angle fixedAngle;
		public Angle localAngleOffset;
		public RECEIVEDHITTYPE hitType;
		public uint hitLevel;
		public bool hitRadial;
		public bool useNormal;
		public bool registerToAIManager;
		public bool useOutOfScreenOptim;
		public bool hitEnemiesOnce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			faction = s.Serialize<RO2_FACTION>(faction, name: "faction");
			useFixedAngle = s.Serialize<bool>(useFixedAngle, name: "useFixedAngle");
			fixedAngle = s.SerializeObject<Angle>(fixedAngle, name: "fixedAngle");
			localAngleOffset = s.SerializeObject<Angle>(localAngleOffset, name: "localAngleOffset");
			hitType = s.Serialize<RECEIVEDHITTYPE>(hitType, name: "hitType");
			hitLevel = s.Serialize<uint>(hitLevel, name: "hitLevel");
			hitRadial = s.Serialize<bool>(hitRadial, name: "hitRadial");
			useNormal = s.Serialize<bool>(useNormal, name: "useNormal");
			registerToAIManager = s.Serialize<bool>(registerToAIManager, name: "registerToAIManager");
			useOutOfScreenOptim = s.Serialize<bool>(useOutOfScreenOptim, name: "useOutOfScreenOptim");
			hitEnemiesOnce = s.Serialize<bool>(hitEnemiesOnce, name: "hitEnemiesOnce");
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

