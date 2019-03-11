using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_PALRitualManagerComponent : ActorComponent {
		[Serialize("ritualType"   )] public RitualType ritualType;
		[Serialize("startSequence")] public bool startSequence;
		[Serialize("ritualType"   )] public Enum_ritualType ritualType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(ritualType));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(startSequence));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(ritualType));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(startSequence));
				}
			}
		}
		public enum RitualType {
			[Serialize("RitualType_Ground")] Ground = 0,
			[Serialize("RitualType_Air"   )] Air = 1,
		}
		public enum Enum_ritualType {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
		}
		public override uint? ClassCRC => 0x73231736;
	}
}

