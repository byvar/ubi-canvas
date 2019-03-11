using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_LumsChainComponent : ActorComponent {
		[Serialize("moveSpeed"                    )] public float moveSpeed;
		[Serialize("useGlobalSpeedFactor"         )] public bool useGlobalSpeedFactor;
		[Serialize("trajectory"                   )] public Trajectory trajectory;
		[Serialize("chainOrder"                   )] public ChainOrder chainOrder;
		[Serialize("spawnMode"                    )] public SpawnMode spawnMode;
		[Serialize("DRCMode"                      )] public DRCMode drcMode;
		[Serialize("spawningFrameInterval"        )] public uint spawningFrameInterval;
		[Serialize("patternSpawningInterval"      )] public uint patternSpawningInterval;
		[Serialize("startBlend"                   )] public float startBlend;
		[Serialize("animFrameOffset"              )] public uint animFrameOffset;
		[Serialize("slowDownDistance"             )] public float slowDownDistance;
		[Serialize("distanceBetweenFinalPositions")] public float distanceBetweenFinalPositions;
		[Serialize("distanceBetweenPatterns"      )] public float distanceBetweenPatterns;
		[Serialize("nbPatterns"                   )] public uint nbPatterns;
		[Serialize("nbLumsInPattern"              )] public uint nbLumsInPattern;
		[Serialize("startNode"                    )] public uint startNode;
		[Serialize("spawningEffectMoveSpeed"      )] public float spawningEffectMoveSpeed;
		[Serialize("disappearTimeInterval"        )] public float disappearTimeInterval;
		[Serialize("isHidden"                     )] public bool isHidden;
		[Serialize("alwaysRed"                    )] public bool alwaysRed;
		[Serialize("disappearingTime"             )] public float disappearingTime;
		[Serialize("particleDisappearingInterval" )] public float particleDisappearingInterval;
		[Serialize("particleDisappearForward"     )] public bool particleDisappearForward;
		[Serialize("interactiveActorOffsets"      )] public InteractiveOffset interactiveActorOffsets;
		[Serialize("flipInteractiveActor"         )] public bool flipInteractiveActor;
		[Serialize("useFireflyCloud"              )] public bool useFireflyCloud;
		[Serialize("displayLinks"                 )] public bool displayLinks;
		[Serialize("tutoSucceeded"                )] public bool tutoSucceeded;
		[Serialize("particles"                    )] public CList<RO2_LumsChainComponent.st_Particle> particles;
		[Serialize("links"                        )] public CList<RO2_LumsChainComponent.st_cursors> links;
		[Serialize("state"                        )] public CHAINSTATE state;
		[Serialize("state"                        )] public CHAINSTATE_Legends stateLegends;
		[Serialize("isActivated"                  )] public bool isActivated;
		[Serialize("perfectActivation"            )] public bool perfectActivation;
		[Serialize("aliveParticles"               )] public CArray<uint> aliveParticles;
		[Serialize("DuplicateLumChainsOffsets"    )] public CList<float> DuplicateLumChainsOffsets;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(moveSpeed));
					SerializeField(s, nameof(useGlobalSpeedFactor));
					SerializeField(s, nameof(trajectory));
					SerializeField(s, nameof(chainOrder));
					SerializeField(s, nameof(spawnMode));
					SerializeField(s, nameof(drcMode));
					SerializeField(s, nameof(spawningFrameInterval));
					SerializeField(s, nameof(patternSpawningInterval));
					SerializeField(s, nameof(startBlend));
					SerializeField(s, nameof(animFrameOffset));
					SerializeField(s, nameof(slowDownDistance));
					SerializeField(s, nameof(distanceBetweenFinalPositions));
					SerializeField(s, nameof(distanceBetweenPatterns));
					SerializeField(s, nameof(nbPatterns));
					SerializeField(s, nameof(nbLumsInPattern));
					SerializeField(s, nameof(startNode));
					SerializeField(s, nameof(spawningEffectMoveSpeed));
					SerializeField(s, nameof(disappearTimeInterval));
					SerializeField(s, nameof(interactiveActorOffsets));
					SerializeField(s, nameof(flipInteractiveActor));
					SerializeField(s, nameof(useFireflyCloud));
					SerializeField(s, nameof(displayLinks));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(tutoSucceeded));
					SerializeField(s, nameof(particles));
					SerializeField(s, nameof(aliveParticles));
					SerializeField(s, nameof(links));
					SerializeField(s, nameof(stateLegends));
					SerializeField(s, nameof(isActivated));
					SerializeField(s, nameof(perfectActivation));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(moveSpeed));
					SerializeField(s, nameof(useGlobalSpeedFactor));
					SerializeField(s, nameof(trajectory));
					SerializeField(s, nameof(chainOrder));
					SerializeField(s, nameof(spawnMode));
					SerializeField(s, nameof(drcMode));
					SerializeField(s, nameof(spawningFrameInterval));
					SerializeField(s, nameof(patternSpawningInterval));
					SerializeField(s, nameof(startBlend));
					SerializeField(s, nameof(animFrameOffset));
					SerializeField(s, nameof(slowDownDistance));
					SerializeField(s, nameof(distanceBetweenFinalPositions));
					SerializeField(s, nameof(distanceBetweenPatterns));
					SerializeField(s, nameof(nbPatterns));
					SerializeField(s, nameof(nbLumsInPattern));
					SerializeField(s, nameof(startNode));
					SerializeField(s, nameof(spawningEffectMoveSpeed));
					SerializeField(s, nameof(disappearTimeInterval));
					SerializeField(s, nameof(isHidden));
					SerializeField(s, nameof(alwaysRed));
					SerializeField(s, nameof(disappearingTime));
					SerializeField(s, nameof(particleDisappearingInterval));
					SerializeField(s, nameof(particleDisappearForward));
					SerializeField(s, nameof(interactiveActorOffsets));
					SerializeField(s, nameof(flipInteractiveActor));
					SerializeField(s, nameof(useFireflyCloud));
					SerializeField(s, nameof(displayLinks));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(tutoSucceeded));
					SerializeField(s, nameof(particles));
					SerializeField(s, nameof(links));
					SerializeField(s, nameof(state));
					SerializeField(s, nameof(isActivated));
					SerializeField(s, nameof(perfectActivation));
					SerializeField(s, nameof(aliveParticles));
				}
				SerializeField(s, nameof(DuplicateLumChainsOffsets));
			}
		}
		public partial class st_cursors : CSerializable {
			[Serialize("indexStart"        )] public uint indexStart;
			[Serialize("indexEnd"          )] public uint indexEnd;
			[Serialize("currentCursorStart")] public float currentCursorStart;
			[Serialize("currentCursorEnd"  )] public float currentCursorEnd;
			[Serialize("catchingStart"     )] public bool catchingStart;
			[Serialize("catchingEnd"       )] public bool catchingEnd;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(indexStart));
				SerializeField(s, nameof(indexEnd));
				SerializeField(s, nameof(currentCursorStart));
				SerializeField(s, nameof(currentCursorEnd));
				SerializeField(s, nameof(catchingStart));
				SerializeField(s, nameof(catchingEnd));
			}
		}
		public partial class st_Particle : CSerializable {
			[Serialize("state"                 )] public PARTICLESTATE state;
			[Serialize("cursorDest"            )] public float cursorDest;
			[Serialize("currentDistance"       )] public float currentDistance;
			[Serialize("currentTarget"         )] public float currentTarget;
			[Serialize("timeToWait"            )] public float timeToWait;
			[Serialize("currentSpeed"          )] public float currentSpeed;
			[Serialize("currentSpeedFactor"    )] public float currentSpeedFactor;
			[Serialize("maxSpeedReached"       )] public float maxSpeedReached;
			[Serialize("initialCurveRatio"     )] public float initialCurveRatio;
			[Serialize("attractiveForce"       )] public float attractiveForce;
			[Serialize("arrivalBlend"          )] public float arrivalBlend;
			[Serialize("timeBeforeDisappearing")] public float timeBeforeDisappearing;
			[Serialize("frameToWait"           )] public uint frameToWait;
			[Serialize("bitfield"              )] public uint bitfield;
			[Serialize("pos"                   )] public Vector3 pos;
			[Serialize("speed"                 )] public Vector2 speed;
			[Serialize("frameCount"            )] public uint frameCount;
			[Serialize("frameOffset"           )] public uint frameOffset;
			[Serialize("animState"             )] public ANIM animState;
			[Serialize("alpha"                 )] public float alpha;
			[Serialize("animIndex"             )] public uint animIndex;
			[Serialize("frame"                 )] public uint frame;
			[Serialize("timeInState"           )] public float timeInState;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(state));
				SerializeField(s, nameof(cursorDest));
				SerializeField(s, nameof(currentDistance));
				SerializeField(s, nameof(currentTarget));
				SerializeField(s, nameof(timeToWait));
				SerializeField(s, nameof(currentSpeed));
				SerializeField(s, nameof(currentSpeedFactor));
				SerializeField(s, nameof(maxSpeedReached));
				SerializeField(s, nameof(initialCurveRatio));
				SerializeField(s, nameof(attractiveForce));
				SerializeField(s, nameof(arrivalBlend));
				SerializeField(s, nameof(timeBeforeDisappearing));
				SerializeField(s, nameof(frameToWait));
				SerializeField(s, nameof(bitfield));
				SerializeField(s, nameof(pos));
				SerializeField(s, nameof(speed));
				SerializeField(s, nameof(frameCount));
				SerializeField(s, nameof(frameOffset));
				SerializeField(s, nameof(animState));
				SerializeField(s, nameof(alpha));
				SerializeField(s, nameof(animIndex));
				SerializeField(s, nameof(frame));
				SerializeField(s, nameof(timeInState));
			}
			public enum PARTICLESTATE {
				[Serialize("PARTICLESTATE_NOTREADY"               )] NOTREADY = 0,
				[Serialize("PARTICLESTATE_READY"                  )] READY = 1,
				[Serialize("PARTICLESTATE_WAITING_TO_MOVE"        )] WAITING_TO_MOVE = 2,
				[Serialize("PARTICLESTATE_MOVING"                 )] MOVING = 3,
				[Serialize("PARTICLESTATE_STANDING"               )] STANDING = 4,
				[Serialize("PARTICLESTATE_GRABBED"                )] GRABBED = 5,
				[Serialize("PARTICLESTATE_RETURNING_TO_TRAJECTORY")] RETURNING_TO_TRAJECTORY = 6,
				[Serialize("PARTICLESTATE_DISAPPEARING"           )] DISAPPEARING = 7,
				[Serialize("PARTICLESTATE_FOLLOWING_OWNER"        )] FOLLOWING_OWNER = 8,
				[Serialize("PARTICLESTATE_REMOVING"               )] REMOVING = 9,
				[Serialize("PARTICLESTATE_REMOVED"                )] REMOVED = 10,
			}
			public enum ANIM {
				[Serialize("ANIM_TINY_STAND"     )] TINY_STAND = 0,
				[Serialize("ANIM_TINY_STAND2"    )] TINY_STAND2 = 1,
				[Serialize("ANIM_TINY_STAND3"    )] TINY_STAND3 = 2,
				[Serialize("ANIM_TINY_TO_BIG"    )] TINY_TO_BIG = 3,
				[Serialize("ANIM_YELLOW_STAND"   )] YELLOW_STAND = 4,
				[Serialize("ANIM_YELLOW_TO_RED"  )] YELLOW_TO_RED = 5,
				[Serialize("ANIM_RED_STAND"      )] RED_STAND = 6,
				[Serialize("ANIM_RED_TO_YELLOW"  )] RED_TO_YELLOW = 7,
				[Serialize("ANIM_DISAPPEAR"      )] DISAPPEAR = 8,
				[Serialize("ANIM_DISAPPEAR_RED"  )] DISAPPEAR_RED = 9,
				[Serialize("ANIM_TINY_RED_STAND" )] TINY_RED_STAND = 10,
				[Serialize("ANIM_TINY_RED_TO_BIG")] TINY_RED_TO_BIG = 11,
			}
		}
		public enum Trajectory {
			[Serialize("Trajectory_FollowChain")] FollowChain = 0,
			[Serialize("Trajectory_GoToTheEnd" )] GoToTheEnd = 1,
		}
		public enum ChainOrder {
			[Serialize("ChainOrder_BeginToEnd")] BeginToEnd = 0,
			[Serialize("ChainOrder_EndToBegin")] EndToBegin = 1,
		}
		public enum SpawnMode {
			[Serialize("SpawnMode_Delayed"                   )] Delayed = 0,
			[Serialize("SpawnMode_StartSpawned_Begin"        )] StartSpawned_Begin = 1,
			[Serialize("SpawnMode_StartSpawned_End"          )] StartSpawned_End = 2,
			[Serialize("SpawnMode_StartSpawned_Begin_Delayed")] StartSpawned_Begin_Delayed = 3,
			[Serialize("SpawnMode_DelayedWithStartEffect"    )] DelayedWithStartEffect = 4,
		}
		public enum DRCMode {
			[Serialize("DRCMode_DrawAllYellow"       )] DrawAllYellow = 0,
			[Serialize("DRCMode_Timed_Activation"    )] Timed_Activation = 2,
			[Serialize("DRCMode_FirstPurpleAllYellow")] FirstPurpleAllYellow = 3,
		}
		public enum InteractiveOffset {
			[Serialize("InteractiveOffset_Down"                )] Down = 0,
			[Serialize("InteractiveOffset_Middle"              )] Middle = 1,
			[Serialize("InteractiveOffset_BreakableMiddle_Up"  )] BreakableMiddle_Up = 2,
			[Serialize("InteractiveOffset_BreakableDown"       )] BreakableDown = 3,
			[Serialize("InteractiveOffset_BreakableMiddle_Down")] BreakableMiddle_Down = 4,
		}
		public enum CHAINSTATE {
			[Serialize("CHAINSTATE_READY_TO_SPAWN"          )] CHAINSTATE_READY_TO_SPAWN = 0,
			[Serialize("CHAINSTATE_WAITING_FOR_SPAWN_EFFECT")] CHAINSTATE_WAITING_FOR_SPAWN_EFFECT = 1,
			[Serialize("CHAINSTATE_START_EFFECT"            )] CHAINSTATE_START_EFFECT = 2,
			[Serialize("CHAINSTATE_SPAWNING"                )] CHAINSTATE_SPAWNING = 3,
			[Serialize("CHAINSTATE_MOVING_ON_TRAJECTORY"    )] CHAINSTATE_MOVING_ON_TRAJECTORY = 4,
			[Serialize("CHAINSTATE_REACHED_THE_END"         )] CHAINSTATE_REACHED_THE_END = 5,
			[Serialize("PARTICLESTATE_DISAPPEARING"         )] PARTICLESTATE_DISAPPEARING = 7,
			[Serialize("CHAINSTATE_NONE"                    )] CHAINSTATE_NONE = 6,
		}
		public enum CHAINSTATE_Legends {
			[Serialize("CHAINSTATE_READY_TO_SPAWN")] CHAINSTATE_READY_TO_SPAWN = 0,
			[Serialize("CHAINSTATE_WAITING_FOR_SPAWN_EFFECT")] CHAINSTATE_WAITING_FOR_SPAWN_EFFECT = 1,
			[Serialize("CHAINSTATE_START_EFFECT")] CHAINSTATE_START_EFFECT = 2,
			[Serialize("CHAINSTATE_SPAWNING")] CHAINSTATE_SPAWNING = 3,
			[Serialize("CHAINSTATE_MOVING_ON_TRAJECTORY")] CHAINSTATE_MOVING_ON_TRAJECTORY = 4,
			[Serialize("CHAINSTATE_REACHED_THE_END")] CHAINSTATE_REACHED_THE_END = 5,
			[Serialize("PARTICLESTATE_DISAPPEARING")] PARTICLESTATE_DISAPPEARING = 8,
			[Serialize("CHAINSTATE_NONE")] CHAINSTATE_NONE = 6,
		}
		public override uint? ClassCRC => 0x7A3F8663;
	}
}

