using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIExplodeAction_Template : AIAction_Template {
		public float minRadius;
		public float maxRadius;
		public float duration;
		public int checkEnv;
		public RECEIVEDHITTYPE hitType;
		public uint hitLevel;
		public int destroyAtEnd;
		public StringID fxName;
		public Path spawnFragmentsPath;
		public uint spawnFragmentsNb;
		public Angle spawnFragmentsDeltaAngle;
		public Angle spawnFragmentsStartAngle;
		public int dbgDrawExplodeRadius;
		public Generic<Ray_EventSpawnReward> reward;
		public CArrayP<uint> numRewards;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			minRadius = s.Serialize<float>(minRadius, name: "minRadius");
			maxRadius = s.Serialize<float>(maxRadius, name: "maxRadius");
			duration = s.Serialize<float>(duration, name: "duration");
			checkEnv = s.Serialize<int>(checkEnv, name: "checkEnv");
			hitType = s.Serialize<RECEIVEDHITTYPE>(hitType, name: "hitType");
			hitLevel = s.Serialize<uint>(hitLevel, name: "hitLevel");
			destroyAtEnd = s.Serialize<int>(destroyAtEnd, name: "destroyAtEnd");
			fxName = s.SerializeObject<StringID>(fxName, name: "fxName");
			spawnFragmentsPath = s.SerializeObject<Path>(spawnFragmentsPath, name: "spawnFragmentsPath");
			spawnFragmentsNb = s.Serialize<uint>(spawnFragmentsNb, name: "spawnFragmentsNb");
			spawnFragmentsDeltaAngle = s.SerializeObject<Angle>(spawnFragmentsDeltaAngle, name: "spawnFragmentsDeltaAngle");
			spawnFragmentsStartAngle = s.SerializeObject<Angle>(spawnFragmentsStartAngle, name: "spawnFragmentsStartAngle");
			if (Settings.s.game == Settings.Game.RO && s.HasFlags(SerializeFlags.Flags_xC0)) {
				dbgDrawExplodeRadius = s.Serialize<int>(dbgDrawExplodeRadius, name: "dbgDrawExplodeRadius");
			}
			reward = s.SerializeObject<Generic<Ray_EventSpawnReward>>(reward, name: "reward");
			numRewards = s.SerializeObject<CArrayP<uint>>(numRewards, name: "numRewards");
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
		public override uint? ClassCRC => 0xD3BB23DC;
	}
}

