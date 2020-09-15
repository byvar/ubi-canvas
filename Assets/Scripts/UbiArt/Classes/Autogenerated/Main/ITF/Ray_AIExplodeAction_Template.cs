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
		public Placeholder reward;
		public Placeholder numRewards;
		public float float__0;
		public float float__1;
		public float float__2;
		public int int__3;
		public Enum_RJR_0 Enum_RJR_0__4;
		public uint uint__5;
		public int int__6;
		public StringID StringID__7;
		public Path Path__8;
		public uint uint__9;
		public Angle Angle__10;
		public Angle Angle__11;
		public Generic<Ray_EventSpawnReward> Generic_Ray_EventSpawnReward__12;
		public CArray<uint> CArray_uint__13;
		public float float__14;
		public float float__15;
		public float float__16;
		public int int__17;
		public Enum_RFR_0 Enum_RFR_0__18;
		public uint uint__19;
		public int int__20;
		public StringID StringID__21;
		public Path Path__22;
		public uint uint__23;
		public Angle Angle__24;
		public Angle Angle__25;
		public Generic<Ray_EventSpawnReward> Generic_Ray_EventSpawnReward__26;
		public CArray<uint> CArray_uint__27;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR) {
				float__14 = s.Serialize<float>(float__14, name: "float__14");
				float__15 = s.Serialize<float>(float__15, name: "float__15");
				float__16 = s.Serialize<float>(float__16, name: "float__16");
				int__17 = s.Serialize<int>(int__17, name: "int__17");
				Enum_RFR_0__18 = s.Serialize<Enum_RFR_0>(Enum_RFR_0__18, name: "Enum_RFR_0__18");
				uint__19 = s.Serialize<uint>(uint__19, name: "uint__19");
				int__20 = s.Serialize<int>(int__20, name: "int__20");
				StringID__21 = s.SerializeObject<StringID>(StringID__21, name: "StringID__21");
				Path__22 = s.SerializeObject<Path>(Path__22, name: "Path__22");
				uint__23 = s.Serialize<uint>(uint__23, name: "uint__23");
				Angle__24 = s.SerializeObject<Angle>(Angle__24, name: "Angle__24");
				Angle__25 = s.SerializeObject<Angle>(Angle__25, name: "Angle__25");
				Generic_Ray_EventSpawnReward__26 = s.SerializeObject<Generic<Ray_EventSpawnReward>>(Generic_Ray_EventSpawnReward__26, name: "Generic_Ray_EventSpawnReward__26");
				CArray_uint__27 = s.SerializeObject<CArray<uint>>(CArray_uint__27, name: "CArray_uint__27");
			} else if (Settings.s.game == Settings.Game.RO) {
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
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					dbgDrawExplodeRadius = s.Serialize<int>(dbgDrawExplodeRadius, name: "dbgDrawExplodeRadius");
				}
				reward = s.SerializeObject<Placeholder>(reward, name: "reward");
				numRewards = s.SerializeObject<Placeholder>(numRewards, name: "numRewards");
			} else {
				float__0 = s.Serialize<float>(float__0, name: "float__0");
				float__1 = s.Serialize<float>(float__1, name: "float__1");
				float__2 = s.Serialize<float>(float__2, name: "float__2");
				int__3 = s.Serialize<int>(int__3, name: "int__3");
				Enum_RJR_0__4 = s.Serialize<Enum_RJR_0>(Enum_RJR_0__4, name: "Enum_RJR_0__4");
				uint__5 = s.Serialize<uint>(uint__5, name: "uint__5");
				int__6 = s.Serialize<int>(int__6, name: "int__6");
				StringID__7 = s.SerializeObject<StringID>(StringID__7, name: "StringID__7");
				Path__8 = s.SerializeObject<Path>(Path__8, name: "Path__8");
				uint__9 = s.Serialize<uint>(uint__9, name: "uint__9");
				Angle__10 = s.SerializeObject<Angle>(Angle__10, name: "Angle__10");
				Angle__11 = s.SerializeObject<Angle>(Angle__11, name: "Angle__11");
				Generic_Ray_EventSpawnReward__12 = s.SerializeObject<Generic<Ray_EventSpawnReward>>(Generic_Ray_EventSpawnReward__12, name: "Generic_Ray_EventSpawnReward__12");
				CArray_uint__13 = s.SerializeObject<CArray<uint>>(CArray_uint__13, name: "CArray_uint__13");
			}
		}
		public enum Enum_RJR_0 {
			[Serialize("Value__1")] Value__1 = -1,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value_7" )] Value_7 = 7,
		}
		public enum Enum_RFR_0 {
			[Serialize("Value__1")] Value__1 = -1,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value_7" )] Value_7 = 7,
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

