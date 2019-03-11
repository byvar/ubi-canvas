using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_AILumsComponent : ActorComponent {
		[Serialize("IsTaken"  )] public bool IsTaken;
		[Serialize("initColor")] public Color initColor;
		[Serialize("initColor")] public Enum_initColor initColor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(IsTaken));
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(initColor));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(IsTaken));
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(initColor));
				}
			}
		}
		public enum Color {
			[Serialize("Color_Yellow")] Yellow = 0,
			[Serialize("Color_Purple")] Purple = 1,
		}
		public enum Enum_initColor {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
		}
		public override uint? ClassCRC => 0x8519D5E8;
	}
}

