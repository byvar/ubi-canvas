using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL)]
	public partial class PunchStim : HitStim {
		[Serialize("hitType"         )] public RECEIVEDHITTYPE hitType;
		[Serialize("pushBackDistance")] public float pushBackDistance;
		[Serialize("radial"          )] public bool radial;
		[Serialize("bounceMultiplier")] public float bounceMultiplier;
		[Serialize("identifier"      )] public uint identifier;
		[Serialize("hitEnemiesOnce"  )] public bool hitEnemiesOnce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(hitType));
				SerializeField(s, nameof(pushBackDistance));
				SerializeField(s, nameof(radial));
				SerializeField(s, nameof(bounceMultiplier));
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
		public override uint? ClassCRC => 0x0BF3E60F;
	}
}

