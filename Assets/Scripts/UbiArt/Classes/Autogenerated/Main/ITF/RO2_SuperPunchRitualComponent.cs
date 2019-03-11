using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_SuperPunchRitualComponent : ActorComponent {
		[Serialize("detectRadius")] public float detectRadius;
		[Serialize("m_triggered" )] public bool m_triggered;
		[Serialize("powerUpId"   )] public Enum_powerUpId powerUpId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(detectRadius));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(m_triggered));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(detectRadius));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(m_triggered));
				}
				SerializeField(s, nameof(powerUpId));
			}
		}
		public enum Enum_powerUpId {
		}
		public override uint? ClassCRC => 0x6C9073C7;
	}
}

