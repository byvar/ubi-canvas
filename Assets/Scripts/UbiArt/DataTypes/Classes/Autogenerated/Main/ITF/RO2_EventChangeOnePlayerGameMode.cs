using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventChangeOnePlayerGameMode : Event {
		public Enum_mode mode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			mode = s.Serialize<Enum_mode>(mode, name: "mode");
		}
		public enum Enum_mode {
			[Serialize("GAMEMODE_UNKNOWN"       )] GAMEMODE_UNKNOWN = -1,
			[Serialize("RO2_GAMEMODE_PLATFORMER")] RO2_GAMEMODE_PLATFORMER = 0,
			[Serialize("RO2_GAMEMODE_DUCK"      )] RO2_GAMEMODE_DUCK = 1,
		}
		public override uint? ClassCRC => 0x7D2C2EB4;
	}
}

