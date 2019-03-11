using UnityEngine;

namespace UbiArt.ITF {
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
		[Serialize("hitType"       )] public Enum_hitType hitType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(atlasMaterial));
				SerializeField(s, nameof(hitLevel));
				SerializeField(s, nameof(hitType));
				SerializeField(s, nameof(smoothFactor));
				SerializeField(s, nameof(leaderSpeedMin));
				SerializeField(s, nameof(leaderSpeedMax));
				SerializeField(s, nameof(distMaxFromCam));
				SerializeField(s, nameof(countParticles));
				SerializeField(s, nameof(sizeParticles));
			} else {
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
		public enum Enum_hitType {
			[Serialize("Value__1")] Value__1 = -1,
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value_7" )] Value_7 = 7,
		}
		public override uint? ClassCRC => 0xD70446FA;
	}
}

