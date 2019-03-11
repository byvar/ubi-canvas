using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_BreakableAIComponent : Ray_BossPlantArenaAIComponent {
		[Serialize("currentDestructionStage")] public uint currentDestructionStage;
		[Serialize("targetDestructionStage" )] public uint targetDestructionStage;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(currentDestructionStage));
				SerializeField(s, nameof(targetDestructionStage));
			}
		}
		public override uint? ClassCRC => 0x6E1967DA;
	}
}

