using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SwarmChaseAIComponent_Template : RO2_AIComponent_Template {
		[Serialize("atlasMaterial" )] public GFXMaterialSerializable atlasMaterial;
		[Serialize("hitLevel"      )] public uint hitLevel;
		[Serialize("hitType"       )] public RECEIVEDHITTYPE hitType;
		[Serialize("smoothFactor"  )] public float smoothFactor;
		[Serialize("leaderSpeedMin")] public float leaderSpeedMin;
		[Serialize("leaderSpeedMax")] public float leaderSpeedMax;
		[Serialize("distMaxFromCam")] public float distMaxFromCam;
		[Serialize("countParticles")] public uint countParticles;
		[Serialize("sizeParticles" )] public float sizeParticles;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(atlasMaterial));
			SerializeField(s, nameof(hitLevel));
			SerializeField(s, nameof(hitType));
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
		public override uint? ClassCRC => 0xD70446FA;
	}
}

