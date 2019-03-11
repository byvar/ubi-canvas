using UnityEngine;

namespace UbiArt.ITF {
	public partial class PunchStim : HitStim {
		[Serialize("hitType"         )] public RECEIVEDHITTYPE hitType;
		[Serialize("pushBackDistance")] public float pushBackDistance;
		[Serialize("radial"          )] public bool radial;
		[Serialize("bounceMultiplier")] public float bounceMultiplier;
		[Serialize("identifier"      )] public uint identifier;
		[Serialize("hitEnemiesOnce"  )] public bool hitEnemiesOnce;
		[Serialize("hitType"         )] public Enum_hitType hitType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(hitType));
				SerializeField(s, nameof(pushBackDistance));
				SerializeField(s, nameof(radial));
				SerializeField(s, nameof(bounceMultiplier));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(hitType));
				SerializeField(s, nameof(pushBackDistance));
				SerializeField(s, nameof(radial));
				SerializeField(s, nameof(bounceMultiplier));
				SerializeField(s, nameof(identifier));
				SerializeField(s, nameof(hitEnemiesOnce));
			} else {
				SerializeField(s, nameof(hitType));
				SerializeField(s, nameof(pushBackDistance));
				SerializeField(s, nameof(radial));
				SerializeField(s, nameof(bounceMultiplier));
				SerializeField(s, nameof(identifier));
				SerializeField(s, nameof(hitEnemiesOnce));
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
		public override uint? ClassCRC => 0x0BF3E60F;
	}
}

