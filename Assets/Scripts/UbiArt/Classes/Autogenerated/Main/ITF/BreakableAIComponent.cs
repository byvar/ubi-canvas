using UnityEngine;

namespace UbiArt.ITF {
	public partial class BreakableAIComponent : AIComponent {
		[Serialize("currentDestructionStage")] public uint currentDestructionStage;
		[Serialize("targetDestructionStage" )] public uint targetDestructionStage;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(currentDestructionStage));
				SerializeField(s, nameof(targetDestructionStage));
			}
		}
		public override uint? ClassCRC => 0x57571144;
	}
}

