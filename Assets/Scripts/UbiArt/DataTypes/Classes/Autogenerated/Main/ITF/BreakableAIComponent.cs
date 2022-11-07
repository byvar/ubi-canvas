namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class BreakableAIComponent : AIComponent {
		public uint currentDestructionStage;
		public uint targetDestructionStage;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				currentDestructionStage = s.Serialize<uint>(currentDestructionStage, name: "currentDestructionStage");
				targetDestructionStage = s.Serialize<uint>(targetDestructionStage, name: "targetDestructionStage");
			}
		}
		public override uint? ClassCRC => 0x57571144;
	}
}

