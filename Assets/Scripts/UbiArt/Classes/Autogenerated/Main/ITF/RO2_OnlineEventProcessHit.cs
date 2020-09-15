using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL)]
	public partial class RO2_OnlineEventProcessHit : Event {
		public PUNCHTYPE hitType;
		public Vec2d wantedDir;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			hitType = s.Serialize<PUNCHTYPE>(hitType, name: "hitType");
			wantedDir = s.SerializeObject<Vec2d>(wantedDir, name: "wantedDir");
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

