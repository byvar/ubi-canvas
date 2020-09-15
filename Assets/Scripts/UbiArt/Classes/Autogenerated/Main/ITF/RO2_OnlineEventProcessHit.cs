using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL)]
	public partial class RO2_OnlineEventProcessHit : Event {
		[Serialize("hitType"  )] public PUNCHTYPE hitType;
		[Serialize("wantedDir")] public Vec2d wantedDir;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(hitType));
			SerializeField(s, nameof(wantedDir));
		}
		public enum PUNCHTYPE {
			[Serialize("PUNCHTYPE_CHARGE"    )] CHARGE = 0,
			[Serialize("PUNCHTYPE_CRUSH"     )] CRUSH = 1,
			[Serialize("PUNCHTYPE_CROUCHKICK")] CROUCHKICK = 2,
			[Serialize("PUNCHTYPE_TORNADO"   )] TORNADO = 3,
			[Serialize("PUNCHTYPE_REPEATING" )] REPEATING = 4,
			[Serialize("PUNCHTYPE_SPIN"      )] SPIN = 5,
			[Serialize("PUNCHTYPE_TORNADOZIP")] TORNADOZIP = 6,
			[Serialize("PUNCHTYPE_UTURNKICK" )] UTURNKICK = 7,
			[Serialize("PUNCHTYPE_UPPERKICK" )] UPPERKICK = 9,
		}
		public override uint? ClassCRC => 0xF7C3D701;
	}
}

