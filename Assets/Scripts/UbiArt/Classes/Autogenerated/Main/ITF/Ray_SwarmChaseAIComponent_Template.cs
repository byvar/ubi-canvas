using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_SwarmChaseAIComponent_Template : Ray_AIComponent_Template {
		public Path pathAtlas;
		public uint hitLevel;
		public RECEIVEDHITTYPE hitType;
		public Enum_RFR_1 faction_;
		public float smoothFactor;
		public float leaderSpeedMin;
		public float leaderSpeedMax;
		public float distMaxFromCam;
		public uint countParticles;
		public float sizeParticles;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			pathAtlas = s.SerializeObject<Path>(pathAtlas, name: "pathAtlas");
			hitLevel = s.Serialize<uint>(hitLevel, name: "hitLevel");
			hitType = s.Serialize<RECEIVEDHITTYPE>(hitType, name: "hitType");
			faction_ = s.Serialize<Enum_RFR_1>(faction_, name: "faction_");
			smoothFactor = s.Serialize<float>(smoothFactor, name: "smoothFactor");
			leaderSpeedMin = s.Serialize<float>(leaderSpeedMin, name: "leaderSpeedMin");
			leaderSpeedMax = s.Serialize<float>(leaderSpeedMax, name: "leaderSpeedMax");
			distMaxFromCam = s.Serialize<float>(distMaxFromCam, name: "distMaxFromCam");
			countParticles = s.Serialize<uint>(countParticles, name: "countParticles");
			sizeParticles = s.Serialize<float>(sizeParticles, name: "sizeParticles");
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
		public enum Enum_RFR_1 {
			[Serialize("Value__1")] Value__1 = -1,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value_7" )] Value_7 = 7,
			[Serialize("Value_8" )] Value_8 = 8,
			[Serialize("Value_9" )] Value_9 = 9,
			[Serialize("Value_10")] Value_10 = 10,
			[Serialize("Value_11")] Value_11 = 11,
			[Serialize("Value_12")] Value_12 = 12,
			[Serialize("Value_13")] Value_13 = 13,
			[Serialize("Value_14")] Value_14 = 14,
			[Serialize("Value_15")] Value_15 = 15,
			[Serialize("Value_16")] Value_16 = 16,
			[Serialize("Value_19")] Value_19 = 19,
			[Serialize("Value_20")] Value_20 = 20,
			[Serialize("Value_21")] Value_21 = 21,
			[Serialize("Value_22")] Value_22 = 22,
			[Serialize("Value_23")] Value_23 = 23,
		}
		public override uint? ClassCRC => 0xF00CF28D;
	}
}

