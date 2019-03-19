using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BossLuchadoreComponent : ActorComponent {
		[Serialize("testedPhaseTag"  )] public StringID testedPhaseTag;
		[Serialize("nextPhaseIndex"  )] public int nextPhaseIndex;
		[Serialize("sequenceHitCount")] public uint sequenceHitCount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(testedPhaseTag));
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(nextPhaseIndex));
				SerializeField(s, nameof(sequenceHitCount));
			}
		}
		public override uint? ClassCRC => 0x4A4CDA29;
	}
}

