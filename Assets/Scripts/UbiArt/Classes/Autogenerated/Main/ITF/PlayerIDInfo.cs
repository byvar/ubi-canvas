using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class PlayerIDInfo : CSerializable {
		public string id;
		public string family;
		public uint lineIdName;
		public uint lineIdDescription;
		public uint costumeIconAnimationId;
		public CList<PlayerIDInfo.GameScreenInfo> gameScreens;
		public PlayerIDInfo.GameScreenInfo defaultGameScreenInfo;
		public PlayerIDInfo.ActorInfo actorInfo;
		public Color deathBubbleColor;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.engineVersion == Settings.EngineVersion.RO) {
				id = s.Serialize<string>(id, name: "id");
				family = s.Serialize<string>(family, name: "family");
				deathBubbleColor = s.SerializeObject<Color>(deathBubbleColor, name: "deathBubbleColor");
				gameScreens = s.SerializeObject<CList<PlayerIDInfo.GameScreenInfo>>(gameScreens, name: "gameScreens");
			} else if (Settings.s.game == Settings.Game.RL) {
				id = s.Serialize<string>(id, name: "id");
				family = s.Serialize<string>(family, name: "family");
				gameScreens = s.SerializeObject<CList<PlayerIDInfo.GameScreenInfo>>(gameScreens, name: "gameScreens");
				defaultGameScreenInfo = s.SerializeObject<PlayerIDInfo.GameScreenInfo>(defaultGameScreenInfo, name: "defaultGameScreenInfo");
			} else if (Settings.s.game == Settings.Game.COL) {
			} else if (Settings.s.game == Settings.Game.VH) {
				actorInfo = s.SerializeObject<PlayerIDInfo.ActorInfo>(actorInfo, name: "actorInfo");
				id = s.Serialize<string>(id, name: "id");
				family = s.Serialize<string>(family, name: "family");
				gameScreens = s.SerializeObject<CList<PlayerIDInfo.GameScreenInfo>>(gameScreens, name: "gameScreens");
				defaultGameScreenInfo = s.SerializeObject<PlayerIDInfo.GameScreenInfo>(defaultGameScreenInfo, name: "defaultGameScreenInfo");
			} else {
				actorInfo = s.SerializeObject<PlayerIDInfo.ActorInfo>(actorInfo, name: "actorInfo");
				id = s.Serialize<string>(id, name: "id");
				family = s.Serialize<string>(family, name: "family");
				lineIdName = s.Serialize<uint>(lineIdName, name: "lineIdName");
				lineIdDescription = s.Serialize<uint>(lineIdDescription, name: "lineIdDescription");
				costumeIconAnimationId = s.Serialize<uint>(costumeIconAnimationId, name: "costumeIconAnimationId");
				gameScreens = s.SerializeObject<CList<PlayerIDInfo.GameScreenInfo>>(gameScreens, name: "gameScreens");
				defaultGameScreenInfo = s.SerializeObject<PlayerIDInfo.GameScreenInfo>(defaultGameScreenInfo, name: "defaultGameScreenInfo");
			}
		}
		[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL)]
		public partial class ActorInfo : CSerializable {
			public Path file;
			public bool isAlwaysActive;
			public bool isPlayable;
			public CList<uint> gameModes;
			public bool isDynamicallyLoaded;
			public uint mainGameMode;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				file = s.SerializeObject<Path>(file, name: "file");
				isAlwaysActive = s.Serialize<bool>(isAlwaysActive, name: "isAlwaysActive");
				isPlayable = s.Serialize<bool>(isPlayable, name: "isPlayable");
				gameModes = s.SerializeObject<CList<uint>>(gameModes, name: "gameModes");
				if (Settings.s.engineVersion > Settings.EngineVersion.RO) {
					isDynamicallyLoaded = s.Serialize<bool>(isDynamicallyLoaded, name: "isDynamicallyLoaded");
					mainGameMode = s.Serialize<uint>(mainGameMode, name: "mainGameMode");
				}
			}
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class GameScreenInfo : CSerializable {
			public StringID gameScreen;
			public CList<PlayerIDInfo.ActorInfo> actors;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				gameScreen = s.SerializeObject<StringID>(gameScreen, name: "gameScreen");
				actors = s.SerializeObject<CList<PlayerIDInfo.ActorInfo>>(actors, name: "actors");
			}
		}
		public override uint? ClassCRC => 0x1F8C15FF;
	}
}

