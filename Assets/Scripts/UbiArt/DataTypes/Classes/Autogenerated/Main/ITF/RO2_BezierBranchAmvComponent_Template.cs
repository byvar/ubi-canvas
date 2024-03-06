namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_BezierBranchAmvComponent_Template : RO2_BezierBranchComponent_Template {
		public Path amvPath;
		public GFXMaterialSerializable amvMaterial;
		public Path amvGameMaterial;
		public Path amvGameMaterialFlipped;
		public float spawnIntervalMin = 0.8f;
		public float spawnIntervalMax = 1.2f;
		public float zOffset = 0.002f;
		public float scaleMultiplierMin = 0.8f;
		public float scaleMultiplierMax = 1.2f;
		public uint animIndexMin;
		public uint animIndexMax;
		public float beginLength;
		public float endLength;
		public float beginWidthMin;
		public float beginWidthMax;
		public float midWidthMin;
		public float midWidthMax;
		public float endWidthMin;
		public float endWidthMax;
		public float startOffset;
		public float endOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			amvPath = s.SerializeObject<Path>(amvPath, name: "amvPath");
			amvMaterial = s.SerializeObject<GFXMaterialSerializable>(amvMaterial, name: "amvMaterial");
			amvGameMaterial = s.SerializeObject<Path>(amvGameMaterial, name: "amvGameMaterial");
			amvGameMaterialFlipped = s.SerializeObject<Path>(amvGameMaterialFlipped, name: "amvGameMaterialFlipped");
			spawnIntervalMin = s.Serialize<float>(spawnIntervalMin, name: "spawnIntervalMin");
			spawnIntervalMax = s.Serialize<float>(spawnIntervalMax, name: "spawnIntervalMax");
			zOffset = s.Serialize<float>(zOffset, name: "zOffset");
			scaleMultiplierMin = s.Serialize<float>(scaleMultiplierMin, name: "scaleMultiplierMin");
			scaleMultiplierMax = s.Serialize<float>(scaleMultiplierMax, name: "scaleMultiplierMax");
			animIndexMin = s.Serialize<uint>(animIndexMin, name: "animIndexMin");
			animIndexMax = s.Serialize<uint>(animIndexMax, name: "animIndexMax");
			beginLength = s.Serialize<float>(beginLength, name: "beginLength");
			endLength = s.Serialize<float>(endLength, name: "endLength");
			beginWidthMin = s.Serialize<float>(beginWidthMin, name: "beginWidthMin");
			beginWidthMax = s.Serialize<float>(beginWidthMax, name: "beginWidthMax");
			midWidthMin = s.Serialize<float>(midWidthMin, name: "midWidthMin");
			midWidthMax = s.Serialize<float>(midWidthMax, name: "midWidthMax");
			endWidthMin = s.Serialize<float>(endWidthMin, name: "endWidthMin");
			endWidthMax = s.Serialize<float>(endWidthMax, name: "endWidthMax");
			startOffset = s.Serialize<float>(startOffset, name: "startOffset");
			endOffset = s.Serialize<float>(endOffset, name: "endOffset");
		}
		public override uint? ClassCRC => 0x239DC011;
	}
}

