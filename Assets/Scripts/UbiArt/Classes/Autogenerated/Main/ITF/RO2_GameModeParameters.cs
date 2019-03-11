using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_GameModeParameters : GameModeParameters {
		[Serialize("gameMode")] public Enum_gameMode gameMode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(gameMode));
		}
		public enum Enum_gameMode {
			[Serialize("GAMEMODE_UNKNOWN"       )] GAMEMODE_UNKNOWN = -1,
			[Serialize("RO2_GAMEMODE_PLATFORMER")] RO2_GAMEMODE_PLATFORMER = 0,
			[Serialize("RO2_GAMEMODE_DUCK"      )] RO2_GAMEMODE_DUCK = 1,
		}
		public override uint? ClassCRC => 0xC1686E68;
	}
}

