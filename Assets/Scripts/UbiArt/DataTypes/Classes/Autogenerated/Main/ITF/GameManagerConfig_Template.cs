namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class GameManagerConfig_Template : TemplateObj {
		public CArrayO<Path> debugMenuMapList;
		public Path gameTextFilePath;
		public Path loading;
		public CListO<Generic<PlayerIDInfo>> playerIDInfo;
		public CListO<PlayerIDInfo> playerIDInfoRO;
		public CArrayP<string> familyList;
		public Path cameraShakeConfig;
		public float cutSceneDefaultUnskippableDurationFirstTime;
		public uint maxLocalPlayers;
		public uint maxOnlinePlayers;
		public string DRCPlayerFamilyName;
		public uint maxBonusTeensy;
		public TeaKey key;
		public Color textHighlightColor;
		public CArrayO<CString> debugMenuMapListRO;
		public CArrayO<CString> mapListPressConf;
		public CArrayO<CString> menus;
		public CArrayO<Path> luaIncludes;
		public CArrayO<Path> inputs;
		public CArrayO<MusicTheme> musicThemes;
		public Path baseMap;
		public Path game2dWorld;
		public CString gameTextFilePathOrigins;
		public Path mainMenuBackMap;
		public Path mainMenuBackMapForDebugSaves;
		public Path worldMap;
		public Path splash1Map;
		public Path levelEndedMap;
		public Path menuSoundMap;
		public int usePressConfMenu;
		public float TEMP_threshold;
		public int TEMP_useshake;
		public float TEMP_delay;
		public int TEMP_runUseB;
		public int TEMP_runUseShake;
		public float TEMP_swimMaxSpeed;
		public float TEMP_swimSmooth;
		public float TEMP_runTimerStop;
		public Path iconsButtonPath;
		public Path gpeIconsPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RO) {
				debugMenuMapListRO = s.SerializeObject<CArrayO<CString>>(debugMenuMapListRO, name: "debugMenuMapList");
				mapListPressConf = s.SerializeObject<CArrayO<CString>>(mapListPressConf, name: "mapListPressConf");
				menus = s.SerializeObject<CArrayO<CString>>(menus, name: "menus");
				luaIncludes = s.SerializeObject<CArrayO<Path>>(luaIncludes, name: "luaIncludes");
				inputs = s.SerializeObject<CArrayO<Path>>(inputs, name: "inputs");
				musicThemes = s.SerializeObject<CArrayO<MusicTheme>>(musicThemes, name: "musicThemes");
				baseMap = s.SerializeObject<Path>(baseMap, name: "baseMap");
				game2dWorld = s.SerializeObject<Path>(game2dWorld, name: "game2dWorld");
				gameTextFilePathOrigins = s.Serialize<CString>(gameTextFilePathOrigins, name: "gameTextFilePath");
				mainMenuBackMap = s.SerializeObject<Path>(mainMenuBackMap, name: "mainMenuBackMap");
				mainMenuBackMapForDebugSaves = s.SerializeObject<Path>(mainMenuBackMapForDebugSaves, name: "mainMenuBackMapForDebugSaves");
				worldMap = s.SerializeObject<Path>(worldMap, name: "worldMap");
				splash1Map = s.SerializeObject<Path>(splash1Map, name: "splash1Map");
				levelEndedMap = s.SerializeObject<Path>(levelEndedMap, name: "levelEndedMap");
				menuSoundMap = s.SerializeObject<Path>(menuSoundMap, name: "menuSoundMap");
				loading = s.SerializeObject<Path>(loading, name: "loading");
				usePressConfMenu = s.Serialize<int>(usePressConfMenu, name: "usePressConfMenu");
				playerIDInfoRO = s.SerializeObject<CListO<PlayerIDInfo>>(playerIDInfoRO, name: "playerIDInfo");
				familyList = s.SerializeObject<CArrayP<string>>(familyList, name: "familyList");
				cameraShakeConfig = s.SerializeObject<Path>(cameraShakeConfig, name: "cameraShakeConfig");
				cutSceneDefaultUnskippableDurationFirstTime = s.Serialize<float>(cutSceneDefaultUnskippableDurationFirstTime, name: "cutSceneDefaultUnskippableDurationFirstTime");
				TEMP_threshold = s.Serialize<float>(TEMP_threshold, name: "TEMP_threshold");
				TEMP_useshake = s.Serialize<int>(TEMP_useshake, name: "TEMP_useshake");
				TEMP_delay = s.Serialize<float>(TEMP_delay, name: "TEMP_delay");
				TEMP_runUseB = s.Serialize<int>(TEMP_runUseB, name: "TEMP_runUseB");
				TEMP_runUseShake = s.Serialize<int>(TEMP_runUseShake, name: "TEMP_runUseShake");
				TEMP_swimMaxSpeed = s.Serialize<float>(TEMP_swimMaxSpeed, name: "TEMP_swimMaxSpeed");
				TEMP_swimSmooth = s.Serialize<float>(TEMP_swimSmooth, name: "TEMP_swimSmooth");
				TEMP_runTimerStop = s.Serialize<float>(TEMP_runTimerStop, name: "TEMP_runTimerStop");
				iconsButtonPath = s.SerializeObject<Path>(iconsButtonPath, name: "iconsButtonPath");
				gpeIconsPath = s.SerializeObject<Path>(gpeIconsPath, name: "gpeIconsPath");
			} else if (s.Settings.Game == Game.RL || s.Settings.Game == Game.VH || s.Settings.Game == Game.COL) {
				debugMenuMapList = s.SerializeObject<CArrayO<Path>>(debugMenuMapList, name: "debugMenuMapList");
				gameTextFilePath = s.SerializeObject<Path>(gameTextFilePath, name: "gameTextFilePath");
				loading = s.SerializeObject<Path>(loading, name: "loading");
				playerIDInfo = s.SerializeObject<CListO<Generic<PlayerIDInfo>>>(playerIDInfo, name: "playerIDInfo");
				familyList = s.SerializeObject<CArrayP<string>>(familyList, name: "familyList");
				cameraShakeConfig = s.SerializeObject<Path>(cameraShakeConfig, name: "cameraShakeConfig");
				cutSceneDefaultUnskippableDurationFirstTime = s.Serialize<float>(cutSceneDefaultUnskippableDurationFirstTime, name: "cutSceneDefaultUnskippableDurationFirstTime");
				maxLocalPlayers = s.Serialize<uint>(maxLocalPlayers, name: "maxLocalPlayers");
				maxOnlinePlayers = s.Serialize<uint>(maxOnlinePlayers, name: "maxOnlinePlayers");
				DRCPlayerFamilyName = s.Serialize<string>(DRCPlayerFamilyName, name: "DRCPlayerFamilyName");
				maxBonusTeensy = s.Serialize<uint>(maxBonusTeensy, name: "maxBonusTeensy");
			} else {
				debugMenuMapList = s.SerializeObject<CArrayO<Path>>(debugMenuMapList, name: "debugMenuMapList");
				gameTextFilePath = s.SerializeObject<Path>(gameTextFilePath, name: "gameTextFilePath");
				loading = s.SerializeObject<Path>(loading, name: "loading");
				playerIDInfo = s.SerializeObject<CListO<Generic<PlayerIDInfo>>>(playerIDInfo, name: "playerIDInfo");
				familyList = s.SerializeObject<CArrayP<string>>(familyList, name: "familyList");
				cameraShakeConfig = s.SerializeObject<Path>(cameraShakeConfig, name: "cameraShakeConfig");
				cutSceneDefaultUnskippableDurationFirstTime = s.Serialize<float>(cutSceneDefaultUnskippableDurationFirstTime, name: "cutSceneDefaultUnskippableDurationFirstTime");
				maxLocalPlayers = s.Serialize<uint>(maxLocalPlayers, name: "maxLocalPlayers");
				maxOnlinePlayers = s.Serialize<uint>(maxOnlinePlayers, name: "maxOnlinePlayers");
				DRCPlayerFamilyName = s.Serialize<string>(DRCPlayerFamilyName, name: "DRCPlayerFamilyName");
				maxBonusTeensy = s.Serialize<uint>(maxBonusTeensy, name: "maxBonusTeensy");
				key = s.SerializeObject<TeaKey>(key, name: "key");
				textHighlightColor = s.SerializeObject<Color>(textHighlightColor, name: "textHighlightColor");
			}
		}
		public override uint? ClassCRC => 0x7B54A1F4;
	}
}

