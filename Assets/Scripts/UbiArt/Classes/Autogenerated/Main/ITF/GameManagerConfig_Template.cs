using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class GameManagerConfig_Template : TemplateObj {
		[Serialize("debugMenuMapList"                           )] public CArray<Path> debugMenuMapList;
		[Serialize("gameTextFilePath"                           )] public Path gameTextFilePath;
		[Serialize("loading"                                    )] public Path loading;
		[Serialize("playerIDInfo"                               )] public CList<PlayerIDInfo> playerIDInfo;
		[Serialize("familyList"                                 )] public CArray<string> familyList;
		[Serialize("cameraShakeConfig"                          )] public Path cameraShakeConfig;
		[Serialize("cutSceneDefaultUnskippableDurationFirstTime")] public float cutSceneDefaultUnskippableDurationFirstTime;
		[Serialize("maxLocalPlayers"                            )] public uint maxLocalPlayers;
		[Serialize("maxOnlinePlayers"                           )] public uint maxOnlinePlayers;
		[Serialize("DRCPlayerFamilyName"                        )] public string DRCPlayerFamilyName;
		[Serialize("maxBonusTeensy"                             )] public uint maxBonusTeensy;
		[Serialize("key"                                        )] public TeaKey key;
		[Serialize("textHighlightColor"                         )] public Color textHighlightColor;
		[Serialize("mapListPressConf"                           )] public Placeholder mapListPressConf;
		[Serialize("menus"                                      )] public Placeholder menus;
		[Serialize("luaIncludes"                                )] public Placeholder luaIncludes;
		[Serialize("inputs"                                     )] public Placeholder inputs;
		[Serialize("musicThemes"                                )] public Placeholder musicThemes;
		[Serialize("baseMap"                                    )] public Path baseMap;
		[Serialize("game2dWorld"                                )] public Path game2dWorld;
		[Serialize("gameTextFilePath"                           )] public CString gameTextFilePathOrigins;
		[Serialize("mainMenuBackMap"                            )] public Path mainMenuBackMap;
		[Serialize("mainMenuBackMapForDebugSaves"               )] public Path mainMenuBackMapForDebugSaves;
		[Serialize("worldMap"                                   )] public Path worldMap;
		[Serialize("splash1Map"                                 )] public Path splash1Map;
		[Serialize("levelEndedMap"                              )] public Path levelEndedMap;
		[Serialize("menuSoundMap"                               )] public Path menuSoundMap;
		[Serialize("usePressConfMenu"                           )] public int usePressConfMenu;
		[Serialize("TEMP_threshold"                             )] public float TEMP_threshold;
		[Serialize("TEMP_useshake"                              )] public int TEMP_useshake;
		[Serialize("TEMP_delay"                                 )] public float TEMP_delay;
		[Serialize("TEMP_runUseB"                               )] public int TEMP_runUseB;
		[Serialize("TEMP_runUseShake"                           )] public int TEMP_runUseShake;
		[Serialize("TEMP_swimMaxSpeed"                          )] public float TEMP_swimMaxSpeed;
		[Serialize("TEMP_swimSmooth"                            )] public float TEMP_swimSmooth;
		[Serialize("TEMP_runTimerStop"                          )] public float TEMP_runTimerStop;
		[Serialize("iconsButtonPath"                            )] public Path iconsButtonPath;
		[Serialize("gpeIconsPath"                               )] public Path gpeIconsPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(debugMenuMapList));
				SerializeField(s, nameof(mapListPressConf));
				SerializeField(s, nameof(menus));
				SerializeField(s, nameof(luaIncludes));
				SerializeField(s, nameof(inputs));
				SerializeField(s, nameof(musicThemes));
				SerializeField(s, nameof(baseMap));
				SerializeField(s, nameof(game2dWorld));
				SerializeField(s, nameof(gameTextFilePathOrigins));
				SerializeField(s, nameof(mainMenuBackMap));
				SerializeField(s, nameof(mainMenuBackMapForDebugSaves));
				SerializeField(s, nameof(worldMap));
				SerializeField(s, nameof(splash1Map));
				SerializeField(s, nameof(levelEndedMap));
				SerializeField(s, nameof(menuSoundMap));
				SerializeField(s, nameof(loading));
				SerializeField(s, nameof(usePressConfMenu));
				SerializeField(s, nameof(playerIDInfo));
				SerializeField(s, nameof(familyList));
				SerializeField(s, nameof(cameraShakeConfig));
				SerializeField(s, nameof(cutSceneDefaultUnskippableDurationFirstTime));
				SerializeField(s, nameof(TEMP_threshold));
				SerializeField(s, nameof(TEMP_useshake));
				SerializeField(s, nameof(TEMP_delay));
				SerializeField(s, nameof(TEMP_runUseB));
				SerializeField(s, nameof(TEMP_runUseShake));
				SerializeField(s, nameof(TEMP_swimMaxSpeed));
				SerializeField(s, nameof(TEMP_swimSmooth));
				SerializeField(s, nameof(TEMP_runTimerStop));
				SerializeField(s, nameof(iconsButtonPath));
				SerializeField(s, nameof(gpeIconsPath));
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(debugMenuMapList));
				SerializeField(s, nameof(gameTextFilePath));
				SerializeField(s, nameof(loading));
				SerializeField(s, nameof(playerIDInfo));
				SerializeField(s, nameof(familyList));
				SerializeField(s, nameof(cameraShakeConfig));
				SerializeField(s, nameof(cutSceneDefaultUnskippableDurationFirstTime));
				SerializeField(s, nameof(maxLocalPlayers));
				SerializeField(s, nameof(maxOnlinePlayers));
				SerializeField(s, nameof(DRCPlayerFamilyName));
				SerializeField(s, nameof(maxBonusTeensy));
			} else {
				SerializeField(s, nameof(debugMenuMapList));
				SerializeField(s, nameof(gameTextFilePath));
				SerializeField(s, nameof(loading));
				SerializeField(s, nameof(playerIDInfo));
				SerializeField(s, nameof(familyList));
				SerializeField(s, nameof(cameraShakeConfig));
				SerializeField(s, nameof(cutSceneDefaultUnskippableDurationFirstTime));
				SerializeField(s, nameof(maxLocalPlayers));
				SerializeField(s, nameof(maxOnlinePlayers));
				SerializeField(s, nameof(DRCPlayerFamilyName));
				SerializeField(s, nameof(maxBonusTeensy));
				SerializeField(s, nameof(key));
				SerializeField(s, nameof(textHighlightColor));
			}
		}
		public override uint? ClassCRC => 0x7B54A1F4;
	}
}

