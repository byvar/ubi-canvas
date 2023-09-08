namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class PlayerIDInfo : CSerializable {
		public string id;
		public string family;
		public uint lineIdName;
		public uint lineIdDescription;
		public uint costumeIconAnimationId;
		public CListO<PlayerIDInfo.GameScreenInfo> gameScreens;
		public PlayerIDInfo.GameScreenInfo defaultGameScreenInfo;
		public PlayerIDInfo.ActorInfo actorInfo;
		public Color deathBubbleColor = Color.White;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.EngineVersion == EngineVersion.RO) {
				id = s.Serialize<string>(id, name: "id");
				family = s.Serialize<string>(family, name: "family");
				deathBubbleColor = s.SerializeObject<Color>(deathBubbleColor, name: "deathBubbleColor");
				gameScreens = s.SerializeObject<CListO<PlayerIDInfo.GameScreenInfo>>(gameScreens, name: "gameScreens");
			} else if (s.Settings.Game == Game.RL) {
				id = s.Serialize<string>(id, name: "id");
				family = s.Serialize<string>(family, name: "family");
				gameScreens = s.SerializeObject<CListO<PlayerIDInfo.GameScreenInfo>>(gameScreens, name: "gameScreens");
				defaultGameScreenInfo = s.SerializeObject<PlayerIDInfo.GameScreenInfo>(defaultGameScreenInfo, name: "defaultGameScreenInfo");
			} else if (s.Settings.Game == Game.COL) {
			} else if (s.Settings.Game == Game.VH) {
				actorInfo = s.SerializeObject<PlayerIDInfo.ActorInfo>(actorInfo, name: "actorInfo");
				id = s.Serialize<string>(id, name: "id");
				family = s.Serialize<string>(family, name: "family");
				gameScreens = s.SerializeObject<CListO<PlayerIDInfo.GameScreenInfo>>(gameScreens, name: "gameScreens");
				defaultGameScreenInfo = s.SerializeObject<PlayerIDInfo.GameScreenInfo>(defaultGameScreenInfo, name: "defaultGameScreenInfo");
			} else {
				actorInfo = s.SerializeObject<PlayerIDInfo.ActorInfo>(actorInfo, name: "actorInfo");
				id = s.Serialize<string>(id, name: "id");
				family = s.Serialize<string>(family, name: "family");
				lineIdName = s.Serialize<uint>(lineIdName, name: "lineIdName");
				lineIdDescription = s.Serialize<uint>(lineIdDescription, name: "lineIdDescription");
				costumeIconAnimationId = s.Serialize<uint>(costumeIconAnimationId, name: "costumeIconAnimationId");
				gameScreens = s.SerializeObject<CListO<PlayerIDInfo.GameScreenInfo>>(gameScreens, name: "gameScreens");
				defaultGameScreenInfo = s.SerializeObject<PlayerIDInfo.GameScreenInfo>(defaultGameScreenInfo, name: "defaultGameScreenInfo");
			}
		}
		[Games(GameFlags.RL | GameFlags.VH | GameFlags.RA)]
		public partial class ActorInfo : CSerializable {
			public Path file;
			public bool isAlwaysActive;
			public bool isPlayable;
			public CListP<uint> gameModes;
			public bool isDynamicallyLoaded;
			public uint mainGameMode = uint.MaxValue;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				file = s.SerializeObject<Path>(file, name: "file");
				isAlwaysActive = s.Serialize<bool>(isAlwaysActive, name: "isAlwaysActive");
				isPlayable = s.Serialize<bool>(isPlayable, name: "isPlayable");
				gameModes = s.SerializeObject<CListP<uint>>(gameModes, name: "gameModes");
				if (s.Settings.EngineVersion > EngineVersion.RO) {
					isDynamicallyLoaded = s.Serialize<bool>(isDynamicallyLoaded, name: "isDynamicallyLoaded");
					mainGameMode = s.Serialize<uint>(mainGameMode, name: "mainGameMode");
				}
			}
		}
		[Games(GameFlags.VH | GameFlags.RA)]
		public partial class GameScreenInfo : CSerializable {
			public StringID gameScreen;
			public CListO<PlayerIDInfo.ActorInfo> actors;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				gameScreen = s.SerializeObject<StringID>(gameScreen, name: "gameScreen");
				actors = s.SerializeObject<CListO<PlayerIDInfo.ActorInfo>>(actors, name: "actors");
			}
		}
		public override uint? ClassCRC => 0x1F8C15FF;
	}
}

