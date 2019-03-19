using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_MusicalBossComponent : ActorComponent {
		[Serialize("bpm"                )] public float bpm;
		[Serialize("triggerDistance"    )] public float triggerDistance;
		[Serialize("volume"             )] public float volume;
		[Serialize("fadeAfterCheckpoint")] public float fadeAfterCheckpoint;
		[Serialize("currentNodeIndex"   )] public uint currentNodeIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(bpm));
				SerializeField(s, nameof(triggerDistance));
				SerializeField(s, nameof(volume));
				SerializeField(s, nameof(fadeAfterCheckpoint));
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(currentNodeIndex));
			}
		}
		public override uint? ClassCRC => 0x0C488105;
	}
}

