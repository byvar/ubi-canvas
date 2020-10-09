using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_SuperPunchRitualComponent : ActorComponent {
		public float detectRadius;
		public bool m_triggered;
		public Enum_powerUpId powerUpId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					detectRadius = s.Serialize<float>(detectRadius, name: "detectRadius");
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					m_triggered = s.Serialize<bool>(m_triggered, name: "m_triggered");
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					detectRadius = s.Serialize<float>(detectRadius, name: "detectRadius");
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					m_triggered = s.Serialize<bool>(m_triggered, name: "m_triggered");
				}
				powerUpId = s.Serialize<Enum_powerUpId>(powerUpId, name: "powerUpId");
			}
		}
		public enum Enum_powerUpId {
		}
		public override uint? ClassCRC => 0x6C9073C7;
	}
}

