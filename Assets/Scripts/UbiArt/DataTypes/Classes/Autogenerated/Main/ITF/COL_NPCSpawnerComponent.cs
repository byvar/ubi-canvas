namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_NPCSpawnerComponent : CSerializable {
		public Path npcPathOverride;
		public bool spawnFlipped;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			npcPathOverride = s.SerializeObject<Path>(npcPathOverride, name: "npcPathOverride");
			spawnFlipped = s.Serialize<bool>(spawnFlipped, name: "spawnFlipped", options: CSerializerObject.Options.BoolAsByte);
		}
		public override uint? ClassCRC => 0x106A71F3;
	}
}

