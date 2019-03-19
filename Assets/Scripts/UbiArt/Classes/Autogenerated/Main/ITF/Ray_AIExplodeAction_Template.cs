using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIExplodeAction_Template : AIAction_Template {
		[Serialize("minRadius"                        )] public float minRadius;
		[Serialize("maxRadius"                        )] public float maxRadius;
		[Serialize("duration"                         )] public float duration;
		[Serialize("checkEnv"                         )] public int checkEnv;
		[Serialize("hitType"                          )] public RECEIVEDHITTYPE hitType;
		[Serialize("hitLevel"                         )] public uint hitLevel;
		[Serialize("destroyAtEnd"                     )] public int destroyAtEnd;
		[Serialize("fxName"                           )] public StringID fxName;
		[Serialize("spawnFragmentsPath"               )] public Path spawnFragmentsPath;
		[Serialize("spawnFragmentsNb"                 )] public uint spawnFragmentsNb;
		[Serialize("spawnFragmentsDeltaAngle"         )] public Angle spawnFragmentsDeltaAngle;
		[Serialize("spawnFragmentsStartAngle"         )] public Angle spawnFragmentsStartAngle;
		[Serialize("dbgDrawExplodeRadius"             )] public int dbgDrawExplodeRadius;
		[Serialize("reward"                           )] public Placeholder reward;
		[Serialize("numRewards"                       )] public Placeholder numRewards;
		[Serialize("float__0"                         )] public float float__0;
		[Serialize("float__1"                         )] public float float__1;
		[Serialize("float__2"                         )] public float float__2;
		[Serialize("int__3"                           )] public int int__3;
		[Serialize("Enum_RJR_0__4"                    )] public Enum_RJR_0 Enum_RJR_0__4;
		[Serialize("uint__5"                          )] public uint uint__5;
		[Serialize("int__6"                           )] public int int__6;
		[Serialize("StringID__7"                      )] public StringID StringID__7;
		[Serialize("Path__8"                          )] public Path Path__8;
		[Serialize("uint__9"                          )] public uint uint__9;
		[Serialize("Angle__10"                        )] public Angle Angle__10;
		[Serialize("Angle__11"                        )] public Angle Angle__11;
		[Serialize("Generic<Ray_EventSpawnReward>__12")] public Generic<Ray_EventSpawnReward> Generic_Ray_EventSpawnReward__12;
		[Serialize("CArray<uint>__13"                 )] public CArray<uint> CArray_uint__13;
		[Serialize("float__14"                        )] public float float__14;
		[Serialize("float__15"                        )] public float float__15;
		[Serialize("float__16"                        )] public float float__16;
		[Serialize("int__17"                          )] public int int__17;
		[Serialize("Enum_RFR_0__18"                   )] public Enum_RFR_0 Enum_RFR_0__18;
		[Serialize("uint__19"                         )] public uint uint__19;
		[Serialize("int__20"                          )] public int int__20;
		[Serialize("StringID__21"                     )] public StringID StringID__21;
		[Serialize("Path__22"                         )] public Path Path__22;
		[Serialize("uint__23"                         )] public uint uint__23;
		[Serialize("Angle__24"                        )] public Angle Angle__24;
		[Serialize("Angle__25"                        )] public Angle Angle__25;
		[Serialize("Generic<Ray_EventSpawnReward>__26")] public Generic<Ray_EventSpawnReward> Generic_Ray_EventSpawnReward__26;
		[Serialize("CArray<uint>__27"                 )] public CArray<uint> CArray_uint__27;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(float__14));
				SerializeField(s, nameof(float__15));
				SerializeField(s, nameof(float__16));
				SerializeField(s, nameof(int__17));
				SerializeField(s, nameof(Enum_RFR_0__18));
				SerializeField(s, nameof(uint__19));
				SerializeField(s, nameof(int__20));
				SerializeField(s, nameof(StringID__21));
				SerializeField(s, nameof(Path__22));
				SerializeField(s, nameof(uint__23));
				SerializeField(s, nameof(Angle__24));
				SerializeField(s, nameof(Angle__25));
				SerializeField(s, nameof(Generic_Ray_EventSpawnReward__26));
				SerializeField(s, nameof(CArray_uint__27));
			} else if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(minRadius));
				SerializeField(s, nameof(maxRadius));
				SerializeField(s, nameof(duration));
				SerializeField(s, nameof(checkEnv));
				SerializeField(s, nameof(hitType));
				SerializeField(s, nameof(hitLevel));
				SerializeField(s, nameof(destroyAtEnd));
				SerializeField(s, nameof(fxName));
				SerializeField(s, nameof(spawnFragmentsPath));
				SerializeField(s, nameof(spawnFragmentsNb));
				SerializeField(s, nameof(spawnFragmentsDeltaAngle));
				SerializeField(s, nameof(spawnFragmentsStartAngle));
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(dbgDrawExplodeRadius));
				}
				SerializeField(s, nameof(reward));
				SerializeField(s, nameof(numRewards));
			} else {
				SerializeField(s, nameof(float__0));
				SerializeField(s, nameof(float__1));
				SerializeField(s, nameof(float__2));
				SerializeField(s, nameof(int__3));
				SerializeField(s, nameof(Enum_RJR_0__4));
				SerializeField(s, nameof(uint__5));
				SerializeField(s, nameof(int__6));
				SerializeField(s, nameof(StringID__7));
				SerializeField(s, nameof(Path__8));
				SerializeField(s, nameof(uint__9));
				SerializeField(s, nameof(Angle__10));
				SerializeField(s, nameof(Angle__11));
				SerializeField(s, nameof(Generic_Ray_EventSpawnReward__12));
				SerializeField(s, nameof(CArray_uint__13));
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

