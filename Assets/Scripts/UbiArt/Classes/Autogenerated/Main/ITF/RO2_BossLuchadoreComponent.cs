using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BossLuchadoreComponent : ActorComponent {
		[Serialize("testedPhaseTag"  )] public StringID testedPhaseTag;
		[Serialize("nextPhaseIndex"  )] public int nextPhaseIndex;
		[Serialize("sequenceHitCount")] public uint sequenceHitCount;
		[Serialize("nextPhaseIndex"  )] public bool nextPhaseIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(testedPhaseTag));
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(nextPhaseIndex));
					SerializeField(s, nameof(sequenceHitCount));
				}
			} else {
				SerializeField(s, nameof(testedPhaseTag));
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(nextPhaseIndex));
					SerializeField(s, nameof(sequenceHitCount));
				}
			}
		}
		public override uint? ClassCRC => 0x4A4CDA29;
	}
}

