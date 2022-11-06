using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_PALRitualManagerComponent : ActorComponent {
		public RitualType ritualType;
		public bool startSequence;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				ritualType = s.Serialize<RitualType>(ritualType, name: "ritualType");
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				startSequence = s.Serialize<bool>(startSequence, name: "startSequence");
			}
		}
		public enum RitualType {
			[Serialize("RitualType_Ground")] Ground = 0,
			[Serialize("RitualType_Air"   )] Air = 1,
		}
		public override uint? ClassCRC => 0x73231736;
	}
}

