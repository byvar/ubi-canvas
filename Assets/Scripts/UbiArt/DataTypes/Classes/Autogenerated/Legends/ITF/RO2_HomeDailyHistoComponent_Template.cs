namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_HomeDailyHistoComponent_Template : RO2_HomeComponent_Template {
		public float leaderboardFocusSpeedThreshold;
		public uint queryResultSize;
		public Path nodeScenePath;
		public Path mainNodeScenePath;
		public float maxHeight;
		public float firstNodeSpace;
		public float nodeSpace;
		public Vec3d nodeSpeed;
		public float segmentThickness;
		public float rollOverOffset;
		public float rollOverSize;
		public float rollOverBlendSpeedMin;
		public float rollOverBlendSpeedOffset;
		public uint slideNodeCount;
		public uint coverflowNodeCount;
		public float coverflowNodeSpace;
		public GFXMaterialSerializable gfxMaterial;
		public Path startBrickPath;
		public Path endBrickPath;
		public Path firstLeftBrickPath;
		public Path firstRightBrickPath;
		public float tilesSize;
		public string anchorLeft;
		public string anchorRight;
		public CListO<Path> tilesPath;
		public Path friendActorPath;
		public uint friendCountMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			leaderboardFocusSpeedThreshold = s.Serialize<float>(leaderboardFocusSpeedThreshold, name: "leaderboardFocusSpeedThreshold");
			queryResultSize = s.Serialize<uint>(queryResultSize, name: "queryResultSize");
			nodeScenePath = s.SerializeObject<Path>(nodeScenePath, name: "nodeScenePath");
			mainNodeScenePath = s.SerializeObject<Path>(mainNodeScenePath, name: "mainNodeScenePath");
			maxHeight = s.Serialize<float>(maxHeight, name: "maxHeight");
			firstNodeSpace = s.Serialize<float>(firstNodeSpace, name: "firstNodeSpace");
			nodeSpace = s.Serialize<float>(nodeSpace, name: "nodeSpace");
			nodeSpeed = s.SerializeObject<Vec3d>(nodeSpeed, name: "nodeSpeed");
			segmentThickness = s.Serialize<float>(segmentThickness, name: "segmentThickness");
			rollOverOffset = s.Serialize<float>(rollOverOffset, name: "rollOverOffset");
			rollOverSize = s.Serialize<float>(rollOverSize, name: "rollOverSize");
			rollOverBlendSpeedMin = s.Serialize<float>(rollOverBlendSpeedMin, name: "rollOverBlendSpeedMin");
			rollOverBlendSpeedOffset = s.Serialize<float>(rollOverBlendSpeedOffset, name: "rollOverBlendSpeedOffset");
			slideNodeCount = s.Serialize<uint>(slideNodeCount, name: "slideNodeCount");
			coverflowNodeCount = s.Serialize<uint>(coverflowNodeCount, name: "coverflowNodeCount");
			coverflowNodeSpace = s.Serialize<float>(coverflowNodeSpace, name: "coverflowNodeSpace");
			gfxMaterial = s.SerializeObject<GFXMaterialSerializable>(gfxMaterial, name: "gfxMaterial");
			startBrickPath = s.SerializeObject<Path>(startBrickPath, name: "startBrickPath");
			endBrickPath = s.SerializeObject<Path>(endBrickPath, name: "endBrickPath");
			firstLeftBrickPath = s.SerializeObject<Path>(firstLeftBrickPath, name: "firstLeftBrickPath");
			firstRightBrickPath = s.SerializeObject<Path>(firstRightBrickPath, name: "firstRightBrickPath");
			tilesSize = s.Serialize<float>(tilesSize, name: "tilesSize");
			anchorLeft = s.Serialize<string>(anchorLeft, name: "anchorLeft");
			anchorRight = s.Serialize<string>(anchorRight, name: "anchorRight");
			tilesPath = s.SerializeObject<CListO<Path>>(tilesPath, name: "tilesPath");
			friendActorPath = s.SerializeObject<Path>(friendActorPath, name: "friendActorPath");
			friendCountMax = s.Serialize<uint>(friendCountMax, name: "friendCountMax");
		}
		public override uint? ClassCRC => 0x5FA2F830;
	}
}

