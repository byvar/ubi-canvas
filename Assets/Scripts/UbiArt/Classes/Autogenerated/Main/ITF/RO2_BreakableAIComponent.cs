using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BreakableAIComponent : RO2_AIComponent {
		[Serialize("currentDestructionStage")] public uint currentDestructionStage;
		[Serialize("targetDestructionStage" )] public uint targetDestructionStage;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(currentDestructionStage));
				SerializeField(s, nameof(targetDestructionStage));
			}
		}
		public override uint? ClassCRC => 0x38CD061E;
	}
}

