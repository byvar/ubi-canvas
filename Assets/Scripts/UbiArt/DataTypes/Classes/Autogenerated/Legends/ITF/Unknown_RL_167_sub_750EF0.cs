namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_167_sub_750EF0 : CSerializable {
		public int useFilterStickControl;
		public Path graduationActorPath;
		public uint graduationPoolSize;
		public Path nodeActorPath;
		public Path flagIconPath;
		public Path costumeIconPath;
		public Path rankIconPath;
		public uint nodePoolSize;
		public Path barActorPath;
		public uint barPoolSize;
		public Path pointActorPath;
		public uint pointPoolSize;
		public Path nameActorPath;
		public uint namePoolSize;
		public float lineOffset;
		public float rowOffset;
		public float columnOffset;
		public float canvasTopOffset;
		public uint numColumn;
		public uint numRow;
		public Placeholder materialHistoBarFill;
		public Placeholder materialHistoBarTop;
		public Placeholder materialLevel;
		public Placeholder materialCountry;
		public Placeholder materialMedal;
		public Placeholder rankingText;
		public Placeholder emptyRankingText;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			useFilterStickControl = s.Serialize<int>(useFilterStickControl, name: "useFilterStickControl");
			graduationActorPath = s.SerializeObject<Path>(graduationActorPath, name: "graduationActorPath");
			graduationPoolSize = s.Serialize<uint>(graduationPoolSize, name: "graduationPoolSize");
			nodeActorPath = s.SerializeObject<Path>(nodeActorPath, name: "nodeActorPath");
			flagIconPath = s.SerializeObject<Path>(flagIconPath, name: "flagIconPath");
			costumeIconPath = s.SerializeObject<Path>(costumeIconPath, name: "costumeIconPath");
			rankIconPath = s.SerializeObject<Path>(rankIconPath, name: "rankIconPath");
			nodePoolSize = s.Serialize<uint>(nodePoolSize, name: "nodePoolSize");
			barActorPath = s.SerializeObject<Path>(barActorPath, name: "barActorPath");
			barPoolSize = s.Serialize<uint>(barPoolSize, name: "barPoolSize");
			pointActorPath = s.SerializeObject<Path>(pointActorPath, name: "pointActorPath");
			pointPoolSize = s.Serialize<uint>(pointPoolSize, name: "pointPoolSize");
			nameActorPath = s.SerializeObject<Path>(nameActorPath, name: "nameActorPath");
			namePoolSize = s.Serialize<uint>(namePoolSize, name: "namePoolSize");
			lineOffset = s.Serialize<float>(lineOffset, name: "lineOffset");
			rowOffset = s.Serialize<float>(rowOffset, name: "rowOffset");
			columnOffset = s.Serialize<float>(columnOffset, name: "columnOffset");
			canvasTopOffset = s.Serialize<float>(canvasTopOffset, name: "canvasTopOffset");
			numColumn = s.Serialize<uint>(numColumn, name: "numColumn");
			numRow = s.Serialize<uint>(numRow, name: "numRow");
			materialHistoBarFill = s.SerializeObject<Placeholder>(materialHistoBarFill, name: "materialHistoBarFill");
			materialHistoBarTop = s.SerializeObject<Placeholder>(materialHistoBarTop, name: "materialHistoBarTop");
			materialLevel = s.SerializeObject<Placeholder>(materialLevel, name: "materialLevel");
			materialCountry = s.SerializeObject<Placeholder>(materialCountry, name: "materialCountry");
			materialMedal = s.SerializeObject<Placeholder>(materialMedal, name: "materialMedal");
			rankingText = s.SerializeObject<Placeholder>(rankingText, name: "rankingText");
			emptyRankingText = s.SerializeObject<Placeholder>(emptyRankingText, name: "emptyRankingText");
		}
		public override uint? ClassCRC => 0xFE013942;
	}
}

