using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_AIExplodeAction_Template : AIAction_Template {
		public float minRadius;
		public float maxRadius;
		public float duration;
		public bool checkEnv;
		public RECEIVEDHITTYPE hitType;
		public uint hitLevel;
		public bool destroyAtEnd;
		public StringID fxName;
		public Path spawnFragmentsPath;
		public uint spawnFragmentsNb;
		public Angle spawnFragmentsDeltaAngle;
		public Angle spawnFragmentsStartAngle;
		public Generic<RO2_EventSpawnReward> reward;
		public CList<uint> numRewards;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			minRadius = s.Serialize<float>(minRadius, name: "minRadius");
			maxRadius = s.Serialize<float>(maxRadius, name: "maxRadius");
			duration = s.Serialize<float>(duration, name: "duration");
			checkEnv = s.Serialize<bool>(checkEnv, name: "checkEnv");
			hitType = s.Serialize<RECEIVEDHITTYPE>(hitType, name: "hitType");
			hitLevel = s.Serialize<uint>(hitLevel, name: "hitLevel");
			destroyAtEnd = s.Serialize<bool>(destroyAtEnd, name: "destroyAtEnd");
			fxName = s.SerializeObject<StringID>(fxName, name: "fxName");
			spawnFragmentsPath = s.SerializeObject<Path>(spawnFragmentsPath, name: "spawnFragmentsPath");
			spawnFragmentsNb = s.Serialize<uint>(spawnFragmentsNb, name: "spawnFragmentsNb");
			spawnFragmentsDeltaAngle = s.SerializeObject<Angle>(spawnFragmentsDeltaAngle, name: "spawnFragmentsDeltaAngle");
			spawnFragmentsStartAngle = s.SerializeObject<Angle>(spawnFragmentsStartAngle, name: "spawnFragmentsStartAngle");
			reward = s.SerializeObject<Generic<RO2_EventSpawnReward>>(reward, name: "reward");
			numRewards = s.SerializeObject<CList<uint>>(numRewards, name: "numRewards");
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
		public override uint? ClassCRC => 0x81310BC3;
	}
}

