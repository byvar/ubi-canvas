using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_GameManagerConfig_Template : GameManagerConfig_Template {
		[Serialize("playerMinHitPoints"               )] public uint playerMinHitPoints;
		[Serialize("playerMaxHitPoints"               )] public uint playerMaxHitPoints;
		[Serialize("playerStartHitPoints"             )] public uint playerStartHitPoints;
		[Serialize("playerStartHitPointsAfterDeath"   )] public uint playerStartHitPointsAfterDeath;
		[Serialize("playerStartMaxHitPoints"          )] public uint playerStartMaxHitPoints;
		[Serialize("hiddenAreaWaitPlayersLength"      )] public float hiddenAreaWaitPlayersLength;
		[Serialize("hiddenAreaWaitLoadLength"         )] public float hiddenAreaWaitLoadLength;
		[Serialize("checkpointWaitPlayersLength"      )] public float checkpointWaitPlayersLength;
		[Serialize("lumPath"                          )] public Path lumPath;
		[Serialize("lumSpawnRadius"                   )] public float lumSpawnRadius;
		[Serialize("heartPath"                        )] public Path heartPath;
		[Serialize("defaultLumMusicManagerPath"       )] public Path defaultLumMusicManagerPath;
		[Serialize("electoonToothScore"               )] public Path electoonToothScore;
		[Serialize("debugSaves"                       )] public int debugSaves;
		[Serialize("stargateWaitForPlayersTime"       )] public float stargateWaitForPlayersTime;
		[Serialize("stargateWaitDistFromDoor"         )] public float stargateWaitDistFromDoor;
		[Serialize("stargateWaitAngleOffset"          )] public float stargateWaitAngleOffset;
		[Serialize("stargateWaitPointZOffset"         )] public float stargateWaitPointZOffset;
		[Serialize("stargateStartToDoorTimeMultiplier")] public float stargateStartToDoorTimeMultiplier;
		[Serialize("stargateCameraLookAtOffset"       )] public Vector3 stargateCameraLookAtOffset;
		[Serialize("scaleDoorWaitDelay"               )] public float scaleDoorWaitDelay;
		[Serialize("scaleDoorMoveK"                   )] public float scaleDoorMoveK;
		[Serialize("scaleDoorMoveD"                   )] public float scaleDoorMoveD;
		[Serialize("bounceToLayerOffsetDistFromTarget")] public float bounceToLayerOffsetDistFromTarget;
		[Serialize("bounceToLayerAngleOffset"         )] public float bounceToLayerAngleOffset;
		[Serialize("throwTeethSurpriseCameraOffset"   )] public Vector3 throwTeethSurpriseCameraOffset;
		[Serialize("throwTeethThrowCameraOffset"      )] public Vector3 throwTeethThrowCameraOffset;
		[Serialize("throwTeethPlayerOffset"           )] public Vector2 throwTeethPlayerOffset;
		[Serialize("powerUps"                         )] public Ray_PowerUpManager_Template powerUps;
		[Serialize("levelsInfo"                       )] public CList<Ray_GameManagerConfig_Template.MapConfig> levelsInfo;
		[Serialize("missionTypes"                     )] public CList<Ray_GameManagerConfig_Template.MissionConfig> missionTypes;
		[Serialize("sprintTutorialFailureCount"       )] public uint sprintTutorialFailureCount;
		[Serialize("sprintTutorialRequiredDuration"   )] public float sprintTutorialRequiredDuration;
		[Serialize("fadeDeath"                        )] public StringID fadeDeath;
		[Serialize("fadeChangePage"                   )] public StringID fadeChangePage;
		[Serialize("fadeHiddenArea"                   )] public StringID fadeHiddenArea;
		[Serialize("fadeTeleport"                     )] public StringID fadeTeleport;
		[Serialize("fadeCostume"                      )] public StringID fadeCostume;
		[Serialize("fadeLoadMap"                      )] public StringID fadeLoadMap;
		[Serialize("fadeChangePageWithAnim"           )] public StringID fadeChangePageWithAnim;
		[Serialize("fadeWorldMapTeleport"             )] public StringID fadeWorldMapTeleport;
		[Serialize("fadeFlash"                        )] public StringID fadeFlash;
		[Serialize("fadePrologue"                     )] public StringID fadePrologue;
		[Serialize("wmStartNode"                      )] public ObjectPath wmStartNode;
		[Serialize("loadingMinFrames"                 )] public uint loadingMinFrames;
		[Serialize("nbDeathBeforeFirstSkip"           )] public uint nbDeathBeforeFirstSkip;
		[Serialize("nbDeathBeforeSecondSkip"          )] public uint nbDeathBeforeSecondSkip;
		[Serialize("endSequencePlayerPosition"        )] public Vector3 endSequencePlayerPosition;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(playerMinHitPoints));
			SerializeField(s, nameof(playerMaxHitPoints));
			SerializeField(s, nameof(playerStartHitPoints));
			SerializeField(s, nameof(playerStartHitPointsAfterDeath));
			SerializeField(s, nameof(playerStartMaxHitPoints));
			SerializeField(s, nameof(hiddenAreaWaitPlayersLength));
			SerializeField(s, nameof(hiddenAreaWaitLoadLength));
			SerializeField(s, nameof(checkpointWaitPlayersLength));
			SerializeField(s, nameof(lumPath));
			SerializeField(s, nameof(lumSpawnRadius));
			SerializeField(s, nameof(heartPath));
			SerializeField(s, nameof(defaultLumMusicManagerPath));
			SerializeField(s, nameof(electoonToothScore));
			SerializeField(s, nameof(debugSaves));
			SerializeField(s, nameof(stargateWaitForPlayersTime));
			SerializeField(s, nameof(stargateWaitDistFromDoor));
			SerializeField(s, nameof(stargateWaitAngleOffset));
			SerializeField(s, nameof(stargateWaitPointZOffset));
			SerializeField(s, nameof(stargateStartToDoorTimeMultiplier));
			SerializeField(s, nameof(stargateCameraLookAtOffset));
			SerializeField(s, nameof(scaleDoorWaitDelay));
			SerializeField(s, nameof(scaleDoorMoveK));
			SerializeField(s, nameof(scaleDoorMoveD));
			SerializeField(s, nameof(bounceToLayerOffsetDistFromTarget));
			SerializeField(s, nameof(bounceToLayerAngleOffset));
			SerializeField(s, nameof(throwTeethSurpriseCameraOffset));
			SerializeField(s, nameof(throwTeethThrowCameraOffset));
			SerializeField(s, nameof(throwTeethPlayerOffset));
			SerializeField(s, nameof(powerUps));
			SerializeField(s, nameof(levelsInfo));
			SerializeField(s, nameof(missionTypes));
			SerializeField(s, nameof(sprintTutorialFailureCount));
			SerializeField(s, nameof(sprintTutorialRequiredDuration));
			SerializeField(s, nameof(fadeDeath));
			SerializeField(s, nameof(fadeChangePage));
			SerializeField(s, nameof(fadeHiddenArea));
			SerializeField(s, nameof(fadeTeleport));
			SerializeField(s, nameof(fadeCostume));
			SerializeField(s, nameof(fadeLoadMap));
			SerializeField(s, nameof(fadeChangePageWithAnim));
			SerializeField(s, nameof(fadeWorldMapTeleport));
			SerializeField(s, nameof(fadeFlash));
			SerializeField(s, nameof(fadePrologue));
			SerializeField(s, nameof(wmStartNode));
			SerializeField(s, nameof(loadingMinFrames));
			SerializeField(s, nameof(nbDeathBeforeFirstSkip));
			SerializeField(s, nameof(nbDeathBeforeSecondSkip));
			SerializeField(s, nameof(endSequencePlayerPosition));
		}
		public override uint? ClassCRC => 0xA4344748;

		[Games(GameFlags.RO)]
		public partial class MapConfig : CSerializable {
			[Serialize("tag"               )] public StringID tag;
			[Serialize("worldTag"          )] public StringID worldTag;
			[Serialize("type"              )] public StringID type;
			[Serialize("music"             )] public StringID music;
			[Serialize("powerUnlocked"     )] public StringID powerUnlocked;
			[Serialize("defaultState"      )] public SPOT_STATE defaultState;
			[Serialize("defaultDisplayName")] public string defaultDisplayName;
			[Serialize("titleId"           )] public LocalisationId titleId;
			[Serialize("path"              )] public Path path;
			[Serialize("loadingScreen"     )] public Path loadingScreen;
			[Serialize("minTeeth"          )] public uint minTeeth;
			[Serialize("minElectoons"      )] public uint minElectoons;
			[Serialize("unlock"            )] public CList<StringID> unlock;
			[Serialize("unlockedBy"        )] public CList<StringID> unlockedBy;
			[Serialize("lastLevel"         )] public int lastLevel;
			[Serialize("isDefaultLevel"    )] public int isDefaultLevel;
			[Serialize("musicVolume"       )] public Volume musicVolume;
			[Serialize("lumAttack1"        )] public int lumAttack1;
			[Serialize("lumAttack2"        )] public int lumAttack2;
			[Serialize("lumAttack3"        )] public int lumAttack3;
			[Serialize("timeAttack1"       )] public int timeAttack1;
			[Serialize("timeAttack2"       )] public int timeAttack2;
			[Serialize("richPresenceIndex" )] public uint richPresenceIndex;
			[Serialize("disableRewards"    )] public int disableRewards;
			[Serialize("disableMenuToWM"   )] public int disableMenuToWM;
			[Serialize("isSkippable"       )] public int isSkippable;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(tag));
				SerializeField(s, nameof(worldTag));
				SerializeField(s, nameof(type));
				SerializeField(s, nameof(music));
				SerializeField(s, nameof(powerUnlocked));
				SerializeField(s, nameof(defaultState));
				SerializeField(s, nameof(defaultDisplayName));
				SerializeField(s, nameof(titleId));
				SerializeField(s, nameof(path));
				SerializeField(s, nameof(loadingScreen));
				SerializeField(s, nameof(minTeeth));
				SerializeField(s, nameof(minElectoons));
				SerializeField(s, nameof(unlock));
				SerializeField(s, nameof(unlockedBy));
				SerializeField(s, nameof(lastLevel));
				SerializeField(s, nameof(isDefaultLevel));
				SerializeField(s, nameof(musicVolume));
				SerializeField(s, nameof(lumAttack1));
				SerializeField(s, nameof(lumAttack2));
				SerializeField(s, nameof(lumAttack3));
				SerializeField(s, nameof(timeAttack1));
				SerializeField(s, nameof(timeAttack2));
				SerializeField(s, nameof(richPresenceIndex));
				SerializeField(s, nameof(disableRewards));
				SerializeField(s, nameof(disableMenuToWM));
				SerializeField(s, nameof(isSkippable));
			}
			public enum SPOT_STATE {
				[Serialize("SPOT_STATE_CLOSED"      )] CLOSED = 0,
				[Serialize("SPOT_STATE_NEW"         )] NEW = 1,
				[Serialize("SPOT_STATE_CANNOT_ENTER")] CANNOT_ENTER = 2,
				[Serialize("SPOT_STATE_OPEN"        )] OPEN = 3,
				[Serialize("SPOT_STATE_COMPLETED"   )] COMPLETED = 4,
			}
		}

		[Games(GameFlags.RO)]
		public partial class MissionConfig : CSerializable {
			[Serialize("type"      )] public StringID type;
			[Serialize("medalSlots")] public CList<MedalSlotConfig> medalSlots;
			[Serialize("medalPath" )] public Path medalPath;
			[Serialize("lumAttack3")] public int lumAttack3;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(type));
				SerializeField(s, nameof(medalSlots));
				SerializeField(s, nameof(medalPath));
				SerializeField(s, nameof(lumAttack3));
			}
		}

		[Games(GameFlags.RO)]
		public partial class MedalSlotConfig : CSerializable {
			[Serialize("type"    )] public Enum_type type;
			[Serialize("value"   )] public int value;
			[Serialize("cupValue")] public int cupValue;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(type));
				SerializeField(s, nameof(value));
				SerializeField(s, nameof(cupValue));
			}
			public enum Enum_type {
				[Serialize("Cage"      )] Cage = 0,
				[Serialize("TimeAttack")] TimeAttack = 1,
				[Serialize("LumAttack" )] LumAttack = 2,
			}
		}
	}
}

