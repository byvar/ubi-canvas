namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_ExitRitualManagerComponent_Template : ActorComponent_Template {
		public StringID animVictoryPlayer;
		public StringID animFlying;
		public StringID animAfterJumpAnim;
		public float maxDelayBeforeAppearing = 1f;
		public float victoryTime = 3f;
		public float flyTime = 1f;
		public Path runePath;
		public CListO<StringID> runeBonesList;
		public CArrayO<Path> medalPaths;
		public CListO<StringID> medalBones;
		public float teensieScale = 0.9f;
		public float appearPosOffset = -10f;
		public Vec3d teensieOffsetOnRune = new Vec3d(0,1,0.2f);
		public float teleportDuration = 1f;
		public Vec3d murphyPodiumOffset;
		public Vec3d murphyInAirOffset;
		public CListO<StringID> podiumBoneList;
		public StringID startRitualFX;
		public StringID startTeleportFX;
		public StringID onPositionFX;
		public StringID cameraFX;
		public StringID fireworkFX;
		public CArrayO<Vec3d> fireworksOffsets;
		public float minTimeBetweenFireworks = 0.2f;
		public float maxTimeBetweenFireworks = 0.4f;
		public Vec3d cameraOffset = new Vec3d(0, 0, 13f);
		public Vec3d cameraOffsetInAir = new Vec3d(0, 0, 13f);
		public float cameraBlend = 0.3f;
		public float depthForHighestY;
		public float depthForLowestY = 0.5f;
		public Path eyeDoor;
		public float eyeDoorOffset = 0.001f;
		public StringID eyeDoorSnapPoly;
		public bool retroMode;
		public StringID appearAnim;
		public Generic<Event> musicEvent;
		public Generic<Event> onStartFadeEvent;
		public Generic<Event> onFadeFinishedEvent;
		public bool isUsedInCinematic;
		public bool isUsedInInvasion;
		public Path transformFlashFX;
		public float waitTransformFlashFX = 0.3f;
		public float minDelayBeforeAppearing;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL) {
				animVictoryPlayer = s.SerializeObject<StringID>(animVictoryPlayer, name: "animVictoryPlayer");
				animFlying = s.SerializeObject<StringID>(animFlying, name: "animFlying");
				animAfterJumpAnim = s.SerializeObject<StringID>(animAfterJumpAnim, name: "animAfterJumpAnim");
				if (s.Settings.Platform != GamePlatform.Vita) {
					minDelayBeforeAppearing = s.Serialize<float>(minDelayBeforeAppearing, name: "minDelayBeforeAppearing");
				}
				maxDelayBeforeAppearing = s.Serialize<float>(maxDelayBeforeAppearing, name: "maxDelayBeforeAppearing");
				victoryTime = s.Serialize<float>(victoryTime, name: "victoryTime");
				flyTime = s.Serialize<float>(flyTime, name: "flyTime");
				runePath = s.SerializeObject<Path>(runePath, name: "runePath");
				runeBonesList = s.SerializeObject<CListO<StringID>>(runeBonesList, name: "runeBonesList");
				medalPaths = s.SerializeObject<CArrayO<Path>>(medalPaths, name: "medalPaths");
				medalBones = s.SerializeObject<CListO<StringID>>(medalBones, name: "medalBones");
				teensieScale = s.Serialize<float>(teensieScale, name: "teensieScale");
				appearPosOffset = s.Serialize<float>(appearPosOffset, name: "appearPosOffset");
				teensieOffsetOnRune = s.SerializeObject<Vec3d>(teensieOffsetOnRune, name: "teensieOffsetOnRune");
				teleportDuration = s.Serialize<float>(teleportDuration, name: "teleportDuration");
				murphyPodiumOffset = s.SerializeObject<Vec3d>(murphyPodiumOffset, name: "murphyPodiumOffset");
				if (s.Settings.Platform != GamePlatform.Vita) {
					murphyInAirOffset = s.SerializeObject<Vec3d>(murphyInAirOffset, name: "murphyInAirOffset");
				}
				podiumBoneList = s.SerializeObject<CListO<StringID>>(podiumBoneList, name: "podiumBoneList");
				startRitualFX = s.SerializeObject<StringID>(startRitualFX, name: "startRitualFX");
				startTeleportFX = s.SerializeObject<StringID>(startTeleportFX, name: "startTeleportFX");
				onPositionFX = s.SerializeObject<StringID>(onPositionFX, name: "onPositionFX");
				cameraFX = s.SerializeObject<StringID>(cameraFX, name: "cameraFX");
				fireworkFX = s.SerializeObject<StringID>(fireworkFX, name: "fireworkFX");
				fireworksOffsets = s.SerializeObject<CArrayO<Vec3d>>(fireworksOffsets, name: "fireworksOffsets");
				minTimeBetweenFireworks = s.Serialize<float>(minTimeBetweenFireworks, name: "minTimeBetweenFireworks");
				maxTimeBetweenFireworks = s.Serialize<float>(maxTimeBetweenFireworks, name: "maxTimeBetweenFireworks");
				cameraOffset = s.SerializeObject<Vec3d>(cameraOffset, name: "cameraOffset");
				if (s.Settings.Platform != GamePlatform.Vita) {
					cameraOffsetInAir = s.SerializeObject<Vec3d>(cameraOffsetInAir, name: "cameraOffsetInAir");
				}
				cameraBlend = s.Serialize<float>(cameraBlend, name: "cameraBlend");
				depthForHighestY = s.Serialize<float>(depthForHighestY, name: "depthForHighestY");
				depthForLowestY = s.Serialize<float>(depthForLowestY, name: "depthForLowestY");
				eyeDoor = s.SerializeObject<Path>(eyeDoor, name: "eyeDoor");
				eyeDoorOffset = s.Serialize<float>(eyeDoorOffset, name: "eyeDoorOffset");
				eyeDoorSnapPoly = s.SerializeObject<StringID>(eyeDoorSnapPoly, name: "eyeDoorSnapPoly");
				retroMode = s.Serialize<bool>(retroMode, name: "retroMode");
				appearAnim = s.SerializeObject<StringID>(appearAnim, name: "appearAnim");
				musicEvent = s.SerializeObject<Generic<Event>>(musicEvent, name: "musicEvent");
				onStartFadeEvent = s.SerializeObject<Generic<Event>>(onStartFadeEvent, name: "onStartFadeEvent");
				onFadeFinishedEvent = s.SerializeObject<Generic<Event>>(onFadeFinishedEvent, name: "onFadeFinishedEvent");
				isUsedInCinematic = s.Serialize<bool>(isUsedInCinematic, name: "isUsedInCinematic");
				if (s.Settings.Platform != GamePlatform.Vita) {
					isUsedInInvasion = s.Serialize<bool>(isUsedInInvasion, name: "isUsedInInvasion");
				}
				transformFlashFX = s.SerializeObject<Path>(transformFlashFX, name: "transformFlashFX");
				waitTransformFlashFX = s.Serialize<float>(waitTransformFlashFX, name: "waitTransformFlashFX");
			} else {
				animVictoryPlayer = s.SerializeObject<StringID>(animVictoryPlayer, name: "animVictoryPlayer");
				animFlying = s.SerializeObject<StringID>(animFlying, name: "animFlying");
				animAfterJumpAnim = s.SerializeObject<StringID>(animAfterJumpAnim, name: "animAfterJumpAnim");
				maxDelayBeforeAppearing = s.Serialize<float>(maxDelayBeforeAppearing, name: "maxDelayBeforeAppearing");
				victoryTime = s.Serialize<float>(victoryTime, name: "victoryTime");
				flyTime = s.Serialize<float>(flyTime, name: "flyTime");
				runePath = s.SerializeObject<Path>(runePath, name: "runePath");
				runeBonesList = s.SerializeObject<CListO<StringID>>(runeBonesList, name: "runeBonesList");
				medalPaths = s.SerializeObject<CArrayO<Path>>(medalPaths, name: "medalPaths");
				medalPaths = s.SerializeObject<CArrayO<Path>>(medalPaths, name: "medalPaths");
				medalBones = s.SerializeObject<CListO<StringID>>(medalBones, name: "medalBones");
				teensieScale = s.Serialize<float>(teensieScale, name: "teensieScale");
				appearPosOffset = s.Serialize<float>(appearPosOffset, name: "appearPosOffset");
				teensieOffsetOnRune = s.SerializeObject<Vec3d>(teensieOffsetOnRune, name: "teensieOffsetOnRune");
				teleportDuration = s.Serialize<float>(teleportDuration, name: "teleportDuration");
				murphyPodiumOffset = s.SerializeObject<Vec3d>(murphyPodiumOffset, name: "murphyPodiumOffset");
				murphyInAirOffset = s.SerializeObject<Vec3d>(murphyInAirOffset, name: "murphyInAirOffset");
				podiumBoneList = s.SerializeObject<CListO<StringID>>(podiumBoneList, name: "podiumBoneList");
				startRitualFX = s.SerializeObject<StringID>(startRitualFX, name: "startRitualFX");
				startTeleportFX = s.SerializeObject<StringID>(startTeleportFX, name: "startTeleportFX");
				onPositionFX = s.SerializeObject<StringID>(onPositionFX, name: "onPositionFX");
				cameraFX = s.SerializeObject<StringID>(cameraFX, name: "cameraFX");
				fireworkFX = s.SerializeObject<StringID>(fireworkFX, name: "fireworkFX");
				fireworksOffsets = s.SerializeObject<CArrayO<Vec3d>>(fireworksOffsets, name: "fireworksOffsets");
				fireworksOffsets = s.SerializeObject<CArrayO<Vec3d>>(fireworksOffsets, name: "fireworksOffsets");
				minTimeBetweenFireworks = s.Serialize<float>(minTimeBetweenFireworks, name: "minTimeBetweenFireworks");
				maxTimeBetweenFireworks = s.Serialize<float>(maxTimeBetweenFireworks, name: "maxTimeBetweenFireworks");
				cameraOffset = s.SerializeObject<Vec3d>(cameraOffset, name: "cameraOffset");
				cameraOffsetInAir = s.SerializeObject<Vec3d>(cameraOffsetInAir, name: "cameraOffsetInAir");
				cameraBlend = s.Serialize<float>(cameraBlend, name: "cameraBlend");
				depthForHighestY = s.Serialize<float>(depthForHighestY, name: "depthForHighestY");
				depthForLowestY = s.Serialize<float>(depthForLowestY, name: "depthForLowestY");
				eyeDoor = s.SerializeObject<Path>(eyeDoor, name: "eyeDoor");
				eyeDoorOffset = s.Serialize<float>(eyeDoorOffset, name: "eyeDoorOffset");
				eyeDoorSnapPoly = s.SerializeObject<StringID>(eyeDoorSnapPoly, name: "eyeDoorSnapPoly");
				retroMode = s.Serialize<bool>(retroMode, name: "retroMode");
				appearAnim = s.SerializeObject<StringID>(appearAnim, name: "appearAnim");
				musicEvent = s.SerializeObject<Generic<Event>>(musicEvent, name: "musicEvent");
				onStartFadeEvent = s.SerializeObject<Generic<Event>>(onStartFadeEvent, name: "onStartFadeEvent");
				onFadeFinishedEvent = s.SerializeObject<Generic<Event>>(onFadeFinishedEvent, name: "onFadeFinishedEvent");
				isUsedInCinematic = s.Serialize<bool>(isUsedInCinematic, name: "isUsedInCinematic");
				isUsedInInvasion = s.Serialize<bool>(isUsedInInvasion, name: "isUsedInInvasion");
				transformFlashFX = s.SerializeObject<Path>(transformFlashFX, name: "transformFlashFX");
				waitTransformFlashFX = s.Serialize<float>(waitTransformFlashFX, name: "waitTransformFlashFX");
			}
		}
		public override uint? ClassCRC => 0x772FDBD5;
	}
}

