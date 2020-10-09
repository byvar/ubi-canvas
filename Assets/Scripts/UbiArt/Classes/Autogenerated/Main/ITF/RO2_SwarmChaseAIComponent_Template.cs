using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_SwarmChaseAIComponent_Template : RO2_AIComponent_Template {
		public GFXMaterialSerializable atlasMaterial;
		public uint hitLevel;
		public RECEIVEDHITTYPE hitType;
		public float smoothFactor;
		public float leaderSpeedMin;
		public float leaderSpeedMax;
		public float distMaxFromCam;
		public uint countParticles;
		public float sizeParticles;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			atlasMaterial = s.SerializeObject<GFXMaterialSerializable>(atlasMaterial, name: "atlasMaterial");
			hitLevel = s.Serialize<uint>(hitLevel, name: "hitLevel");
			hitType = s.Serialize<RECEIVEDHITTYPE>(hitType, name: "hitType");
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
		public override uint? ClassCRC => 0xD70446FA;
	}
}

