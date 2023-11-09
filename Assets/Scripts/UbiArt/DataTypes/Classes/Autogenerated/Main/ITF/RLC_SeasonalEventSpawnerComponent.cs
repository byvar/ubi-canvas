namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_SeasonalEventSpawnerComponent : ActorComponent {
		public uint selectedPathIndex;
		public uint weight = 1;
		public GFXPrimitiveParam GFXParam;
		public bool triggerSpawn;
		public bool spawneeCanDrown;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			selectedPathIndex = s.Serialize<uint>(selectedPathIndex, name: "selectedPathIndex");
			weight = s.Serialize<uint>(weight, name: "weight");
			GFXParam = s.SerializeObject<GFXPrimitiveParam>(GFXParam, name: "GFXParam");
			triggerSpawn = s.Serialize<bool>(triggerSpawn, name: "triggerSpawn");
			spawneeCanDrown = s.Serialize<bool>(spawneeCanDrown, name: "spawneeCanDrown");
		}
		public override uint? ClassCRC => 0xD33156E5;
	}
}

