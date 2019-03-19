using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PALRitualManagerComponent : ActorComponent {
		[Serialize("ritualType"   )] public RitualType ritualType;
		[Serialize("startSequence")] public bool startSequence;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(ritualType));
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(startSequence));
			}
		}
		public enum RitualType {
			[Serialize("RitualType_Ground")] Ground = 0,
			[Serialize("RitualType_Air"   )] Air = 1,
		}
		public override uint? ClassCRC => 0x73231736;
	}
}

