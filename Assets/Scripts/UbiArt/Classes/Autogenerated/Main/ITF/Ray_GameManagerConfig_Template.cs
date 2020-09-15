using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_GameManagerConfig_Template : GameManagerConfig_Template {
		public uint playerMinHitPoints;
		public uint playerMaxHitPoints;
		public uint playerStartHitPoints;
		public uint playerStartHitPointsAfterDeath;
		public uint playerStartMaxHitPoints;
		public float hiddenAreaWaitPlayersLength;
		public float hiddenAreaWaitLoadLength;
		public float checkpointWaitPlayersLength;
		public Path lumPath;
		public float lumSpawnRadius;
		public Path heartPath;
		public Path defaultLumMusicManagerPath;
		public Path electoonToothScore;
		public int debugSaves;
		public float stargateWaitForPlayersTime;
		public float stargateWaitDistFromDoor;
		public float stargateWaitAngleOffset;
		public float stargateWaitPointZOffset;
		public float stargateStartToDoorTimeMultiplier;
		public Vec3d stargateCameraLookAtOffset;
		public float scaleDoorWaitDelay;
		public float scaleDoorMoveK;
		public float scaleDoorMoveD;
		public float bounceToLayerOffsetDistFromTarget;
		public float bounceToLayerAngleOffset;
		public Vec3d throwTeethSurpriseCameraOffset;
		public Vec3d throwTeethThrowCameraOffset;
		public Vec2d throwTeethPlayerOffset;
		public Ray_PowerUpManager_Template powerUps;
		public CList<Ray_GameManagerConfig_Template.MapConfig> levelsInfo;
		public CList<Ray_GameManagerConfig_Template.MissionConfig> missionTypes;
		public uint sprintTutorialFailureCount;
		public float sprintTutorialRequiredDuration;
		public StringID fadeDeath;
		public StringID fadeChangePage;
		public StringID fadeHiddenArea;
		public StringID fadeTeleport;
		public StringID fadeCostume;
		public StringID fadeLoadMap;
		public StringID fadeChangePageWithAnim;
		public StringID fadeWorldMapTeleport;
		public StringID fadeFlash;
		public StringID fadePrologue;
		public ObjectPath wmStartNode;
		public uint loadingMinFrames;
		public uint nbDeathBeforeFirstSkip;
		public uint nbDeathBeforeSecondSkip;
		public Vec3d endSequencePlayerPosition;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			playerMinHitPoints = s.Serialize<uint>(playerMinHitPoints, name: "playerMinHitPoints");
			playerMaxHitPoints = s.Serialize<uint>(playerMaxHitPoints, name: "playerMaxHitPoints");
			playerStartHitPoints = s.Serialize<uint>(playerStartHitPoints, name: "playerStartHitPoints");
			playerStartHitPointsAfterDeath = s.Serialize<uint>(playerStartHitPointsAfterDeath, name: "playerStartHitPointsAfterDeath");
			playerStartMaxHitPoints = s.Serialize<uint>(playerStartMaxHitPoints, name: "playerStartMaxHitPoints");
			hiddenAreaWaitPlayersLength = s.Serialize<float>(hiddenAreaWaitPlayersLength, name: "hiddenAreaWaitPlayersLength");
			hiddenAreaWaitLoadLength = s.Serialize<float>(hiddenAreaWaitLoadLength, name: "hiddenAreaWaitLoadLength");
			checkpointWaitPlayersLength = s.Serialize<float>(checkpointWaitPlayersLength, name: "checkpointWaitPlayersLength");
			lumPath = s.SerializeObject<Path>(lumPath, name: "lumPath");
			lumSpawnRadius = s.Serialize<float>(lumSpawnRadius, name: "lumSpawnRadius");
			heartPath = s.SerializeObject<Path>(heartPath, name: "heartPath");
			defaultLumMusicManagerPath = s.SerializeObject<Path>(defaultLumMusicManagerPath, name: "defaultLumMusicManagerPath");
			electoonToothScore = s.SerializeObject<Path>(electoonToothScore, name: "electoonToothScore");
			debugSaves = s.Serialize<int>(debugSaves, name: "debugSaves");
			stargateWaitForPlayersTime = s.Serialize<float>(stargateWaitForPlayersTime, name: "stargateWaitForPlayersTime");
			stargateWaitDistFromDoor = s.Serialize<float>(stargateWaitDistFromDoor, name: "stargateWaitDistFromDoor");
			stargateWaitAngleOffset = s.Serialize<float>(stargateWaitAngleOffset, name: "stargateWaitAngleOffset");
			stargateWaitPointZOffset = s.Serialize<float>(stargateWaitPointZOffset, name: "stargateWaitPointZOffset");
			stargateStartToDoorTimeMultiplier = s.Serialize<float>(stargateStartToDoorTimeMultiplier, name: "stargateStartToDoorTimeMultiplier");
			stargateCameraLookAtOffset = s.SerializeObject<Vec3d>(stargateCameraLookAtOffset, name: "stargateCameraLookAtOffset");
			scaleDoorWaitDelay = s.Serialize<float>(scaleDoorWaitDelay, name: "scaleDoorWaitDelay");
			scaleDoorMoveK = s.Serialize<float>(scaleDoorMoveK, name: "scaleDoorMoveK");
			scaleDoorMoveD = s.Serialize<float>(scaleDoorMoveD, name: "scaleDoorMoveD");
			bounceToLayerOffsetDistFromTarget = s.Serialize<float>(bounceToLayerOffsetDistFromTarget, name: "bounceToLayerOffsetDistFromTarget");
			bounceToLayerAngleOffset = s.Serialize<float>(bounceToLayerAngleOffset, name: "bounceToLayerAngleOffset");
			throwTeethSurpriseCameraOffset = s.SerializeObject<Vec3d>(throwTeethSurpriseCameraOffset, name: "throwTeethSurpriseCameraOffset");
			throwTeethThrowCameraOffset = s.SerializeObject<Vec3d>(throwTeethThrowCameraOffset, name: "throwTeethThrowCameraOffset");
			throwTeethPlayerOffset = s.SerializeObject<Vec2d>(throwTeethPlayerOffset, name: "throwTeethPlayerOffset");
			powerUps = s.SerializeObject<Ray_PowerUpManager_Template>(powerUps, name: "powerUps");
			levelsInfo = s.SerializeObject<CList<Ray_GameManagerConfig_Template.MapConfig>>(levelsInfo, name: "levelsInfo");
			missionTypes = s.SerializeObject<CList<Ray_GameManagerConfig_Template.MissionConfig>>(missionTypes, name: "missionTypes");
			sprintTutorialFailureCount = s.Serialize<uint>(sprintTutorialFailureCount, name: "sprintTutorialFailureCount");
			sprintTutorialRequiredDuration = s.Serialize<float>(sprintTutorialRequiredDuration, name: "sprintTutorialRequiredDuration");
			fadeDeath = s.SerializeObject<StringID>(fadeDeath, name: "fadeDeath");
			fadeChangePage = s.SerializeObject<StringID>(fadeChangePage, name: "fadeChangePage");
			fadeHiddenArea = s.SerializeObject<StringID>(fadeHiddenArea, name: "fadeHiddenArea");
			fadeTeleport = s.SerializeObject<StringID>(fadeTeleport, name: "fadeTeleport");
			fadeCostume = s.SerializeObject<StringID>(fadeCostume, name: "fadeCostume");
			fadeLoadMap = s.SerializeObject<StringID>(fadeLoadMap, name: "fadeLoadMap");
			fadeChangePageWithAnim = s.SerializeObject<StringID>(fadeChangePageWithAnim, name: "fadeChangePageWithAnim");
			fadeWorldMapTeleport = s.SerializeObject<StringID>(fadeWorldMapTeleport, name: "fadeWorldMapTeleport");
			fadeFlash = s.SerializeObject<StringID>(fadeFlash, name: "fadeFlash");
			fadePrologue = s.SerializeObject<StringID>(fadePrologue, name: "fadePrologue");
			wmStartNode = s.SerializeObject<ObjectPath>(wmStartNode, name: "wmStartNode");
			loadingMinFrames = s.Serialize<uint>(loadingMinFrames, name: "loadingMinFrames");
			nbDeathBeforeFirstSkip = s.Serialize<uint>(nbDeathBeforeFirstSkip, name: "nbDeathBeforeFirstSkip");
			nbDeathBeforeSecondSkip = s.Serialize<uint>(nbDeathBeforeSecondSkip, name: "nbDeathBeforeSecondSkip");
			endSequencePlayerPosition = s.SerializeObject<Vec3d>(endSequencePlayerPosition, name: "endSequencePlayerPosition");
		}
		public override uint? ClassCRC => 0xA4344748;

		[Games(GameFlags.RO)]
		public partial class MapConfig : CSerializable {
			public StringID tag;
			public StringID worldTag;
			public StringID type;
			public StringID music;
			public StringID powerUnlocked;
			public SPOT_STATE defaultState;
			public string defaultDisplayName;
			public LocalisationId titleId;
			public Path path;
			public Path loadingScreen;
			public uint minTeeth;
			public uint minElectoons;
			public CList<StringID> unlock;
			public CList<StringID> unlockedBy;
			public int lastLevel;
			public int isDefaultLevel;
			public Volume musicVolume;
			public int lumAttack1;
			public int lumAttack2;
			public int lumAttack3;
			public int timeAttack1;
			public int timeAttack2;
			public uint richPresenceIndex;
			public int disableRewards;
			public int disableMenuToWM;
			public int isSkippable;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				tag = s.SerializeObject<StringID>(tag, name: "tag");
				worldTag = s.SerializeObject<StringID>(worldTag, name: "worldTag");
				type = s.SerializeObject<StringID>(type, name: "type");
				music = s.SerializeObject<StringID>(music, name: "music");
				powerUnlocked = s.SerializeObject<StringID>(powerUnlocked, name: "powerUnlocked");
				defaultState = s.Serialize<SPOT_STATE>(defaultState, name: "defaultState");
				defaultDisplayName = s.Serialize<string>(defaultDisplayName, name: "defaultDisplayName");
				titleId = s.SerializeObject<LocalisationId>(titleId, name: "titleId");
				path = s.SerializeObject<Path>(path, name: "path");
				loadingScreen = s.SerializeObject<Path>(loadingScreen, name: "loadingScreen");
				minTeeth = s.Serialize<uint>(minTeeth, name: "minTeeth");
				minElectoons = s.Serialize<uint>(minElectoons, name: "minElectoons");
				unlock = s.SerializeObject<CList<StringID>>(unlock, name: "unlock");
				unlockedBy = s.SerializeObject<CList<StringID>>(unlockedBy, name: "unlockedBy");
				lastLevel = s.Serialize<int>(lastLevel, name: "lastLevel");
				isDefaultLevel = s.Serialize<int>(isDefaultLevel, name: "isDefaultLevel");
				musicVolume = s.SerializeObject<Volume>(musicVolume, name: "musicVolume");
				lumAttack1 = s.Serialize<int>(lumAttack1, name: "lumAttack1");
				lumAttack2 = s.Serialize<int>(lumAttack2, name: "lumAttack2");
				lumAttack3 = s.Serialize<int>(lumAttack3, name: "lumAttack3");
				timeAttack1 = s.Serialize<int>(timeAttack1, name: "timeAttack1");
				timeAttack2 = s.Serialize<int>(timeAttack2, name: "timeAttack2");
				richPresenceIndex = s.Serialize<uint>(richPresenceIndex, name: "richPresenceIndex");
				disableRewards = s.Serialize<int>(disableRewards, name: "disableRewards");
				disableMenuToWM = s.Serialize<int>(disableMenuToWM, name: "disableMenuToWM");
				isSkippable = s.Serialize<int>(isSkippable, name: "isSkippable");
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
			public StringID type;
			public CList<MedalSlotConfig> medalSlots;
			public Path medalPath;
			public int lumAttack3;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				type = s.SerializeObject<StringID>(type, name: "type");
				medalSlots = s.SerializeObject<CList<MedalSlotConfig>>(medalSlots, name: "medalSlots");
				medalPath = s.SerializeObject<Path>(medalPath, name: "medalPath");
				lumAttack3 = s.Serialize<int>(lumAttack3, name: "lumAttack3");
			}
		}

		[Games(GameFlags.RO)]
		public partial class MedalSlotConfig : CSerializable {
			public Enum_type type;
			public int value;
			public int cupValue;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				type = s.Serialize<Enum_type>(type, name: "type");
				value = s.Serialize<int>(value, name: "value");
				cupValue = s.Serialize<int>(cupValue, name: "cupValue");
			}
			public enum Enum_type {
				[Serialize("Cage"      )] Cage = 0,
				[Serialize("TimeAttack")] TimeAttack = 1,
				[Serialize("LumAttack" )] LumAttack = 2,
			}
		}
	}
}

