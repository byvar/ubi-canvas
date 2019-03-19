using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL)]
	public partial class RO2_OnlineEventProcessHit : Event {
		[Serialize("hitType"  )] public PUNCHTYPE hitType;
		[Serialize("wantedDir")] public Vector2 wantedDir;
		[Serialize("hitType"  )] public Enum_hitType hitType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(hitType));
				SerializeField(s, nameof(wantedDir));
			} else {
				SerializeField(s, nameof(hitType));
				SerializeField(s, nameof(wantedDir));
			}
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
		public enum Enum_hitType {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_5")] Value_5 = 5,
			[Serialize("Value_6")] Value_6 = 6,
			[Serialize("Value_7")] Value_7 = 7,
			[Serialize("Value_9")] Value_9 = 9,
		}
		public override uint? ClassCRC => 0xF7C3D701;
	}
}

