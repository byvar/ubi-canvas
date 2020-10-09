using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_BossLuchadoreComponent : ActorComponent {
		public StringID testedPhaseTag;
		public int nextPhaseIndex;
		public uint sequenceHitCount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			testedPhaseTag = s.SerializeObject<StringID>(testedPhaseTag, name: "testedPhaseTag");
			if (s.HasFlags(SerializeFlags.Persistent)) {
				nextPhaseIndex = s.Serialize<int>(nextPhaseIndex, name: "nextPhaseIndex");
				sequenceHitCount = s.Serialize<uint>(sequenceHitCount, name: "sequenceHitCount");
			}
		}
		public override uint? ClassCRC => 0x4A4CDA29;
	}
}

