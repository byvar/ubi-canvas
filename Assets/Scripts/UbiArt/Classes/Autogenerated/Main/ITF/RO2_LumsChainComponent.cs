using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_LumsChainComponent : ActorComponent {
		public float moveSpeed;
		public bool useGlobalSpeedFactor;
		public Trajectory trajectory;
		public ChainOrder chainOrder;
		public SpawnMode spawnMode;
		public DRCMode drcMode;
		public uint spawningFrameInterval;
		public uint patternSpawningInterval;
		public float startBlend;
		public uint animFrameOffset;
		public float slowDownDistance;
		public float distanceBetweenFinalPositions;
		public float distanceBetweenPatterns;
		public uint nbPatterns;
		public uint nbLumsInPattern;
		public uint startNode;
		public float spawningEffectMoveSpeed;
		public float disappearTimeInterval;
		public bool isHidden;
		public bool alwaysRed;
		public float disappearingTime;
		public float particleDisappearingInterval;
		public bool particleDisappearForward;
		public InteractiveOffset interactiveActorOffsets;
		public bool flipInteractiveActor;
		public bool useFireflyCloud;
		public bool displayLinks;
		public bool tutoSucceeded;
		public CListO<RO2_LumsChainComponent.st_Particle> particles;
		public CListO<RO2_LumsChainComponent.st_cursors> links;
		public Enum_state state;
		public Enum_state2 state2;
		public bool isActivated;
		public bool perfectActivation;
		public CArrayP<uint> aliveParticles;
		public CListP<float> DuplicateLumChainsOffsets;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					moveSpeed = s.Serialize<float>(moveSpeed, name: "moveSpeed");
					useGlobalSpeedFactor = s.Serialize<bool>(useGlobalSpeedFactor, name: "useGlobalSpeedFactor", options: CSerializerObject.Options.BoolAsByte);
					trajectory = s.Serialize<Trajectory>(trajectory, name: "trajectory");
					chainOrder = s.Serialize<ChainOrder>(chainOrder, name: "chainOrder");
					spawnMode = s.Serialize<SpawnMode>(spawnMode, name: "spawnMode");
					drcMode = s.Serialize<DRCMode>(drcMode, name: "DRCMode");
					spawningFrameInterval = s.Serialize<uint>(spawningFrameInterval, name: "spawningFrameInterval");
					patternSpawningInterval = s.Serialize<uint>(patternSpawningInterval, name: "patternSpawningInterval");
					startBlend = s.Serialize<float>(startBlend, name: "startBlend");
					animFrameOffset = s.Serialize<uint>(animFrameOffset, name: "animFrameOffset");
					slowDownDistance = s.Serialize<float>(slowDownDistance, name: "slowDownDistance");
					distanceBetweenFinalPositions = s.Serialize<float>(distanceBetweenFinalPositions, name: "distanceBetweenFinalPositions");
					distanceBetweenPatterns = s.Serialize<float>(distanceBetweenPatterns, name: "distanceBetweenPatterns");
					nbPatterns = s.Serialize<uint>(nbPatterns, name: "nbPatterns");
					nbLumsInPattern = s.Serialize<uint>(nbLumsInPattern, name: "nbLumsInPattern");
					startNode = s.Serialize<uint>(startNode, name: "startNode");
					spawningEffectMoveSpeed = s.Serialize<float>(spawningEffectMoveSpeed, name: "spawningEffectMoveSpeed");
					disappearTimeInterval = s.Serialize<float>(disappearTimeInterval, name: "disappearTimeInterval");
					interactiveActorOffsets = s.Serialize<InteractiveOffset>(interactiveActorOffsets, name: "interactiveActorOffsets");
					flipInteractiveActor = s.Serialize<bool>(flipInteractiveActor, name: "flipInteractiveActor", options: CSerializerObject.Options.BoolAsByte);
					useFireflyCloud = s.Serialize<bool>(useFireflyCloud, name: "useFireflyCloud", options: CSerializerObject.Options.BoolAsByte);
					displayLinks = s.Serialize<bool>(displayLinks, name: "displayLinks", options: CSerializerObject.Options.BoolAsByte);
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					tutoSucceeded = s.Serialize<bool>(tutoSucceeded, name: "tutoSucceeded");
					particles = s.SerializeObject<CListO<RO2_LumsChainComponent.st_Particle>>(particles, name: "particles");
					aliveParticles = s.SerializeObject<CArrayP<uint>>(aliveParticles, name: "aliveParticles");
					links = s.SerializeObject<CListO<RO2_LumsChainComponent.st_cursors>>(links, name: "links");
					state2 = s.Serialize<Enum_state2>(state2, name: "state");
					isActivated = s.Serialize<bool>(isActivated, name: "isActivated");
					perfectActivation = s.Serialize<bool>(perfectActivation, name: "perfectActivation");
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					moveSpeed = s.Serialize<float>(moveSpeed, name: "moveSpeed");
					useGlobalSpeedFactor = s.Serialize<bool>(useGlobalSpeedFactor, name: "useGlobalSpeedFactor");
					trajectory = s.Serialize<Trajectory>(trajectory, name: "trajectory");
					chainOrder = s.Serialize<ChainOrder>(chainOrder, name: "chainOrder");
					spawnMode = s.Serialize<SpawnMode>(spawnMode, name: "spawnMode");
					drcMode = s.Serialize<DRCMode>(drcMode, name: "DRCMode");
					spawningFrameInterval = s.Serialize<uint>(spawningFrameInterval, name: "spawningFrameInterval");
					patternSpawningInterval = s.Serialize<uint>(patternSpawningInterval, name: "patternSpawningInterval");
					startBlend = s.Serialize<float>(startBlend, name: "startBlend");
					animFrameOffset = s.Serialize<uint>(animFrameOffset, name: "animFrameOffset");
					slowDownDistance = s.Serialize<float>(slowDownDistance, name: "slowDownDistance");
					distanceBetweenFinalPositions = s.Serialize<float>(distanceBetweenFinalPositions, name: "distanceBetweenFinalPositions");
					distanceBetweenPatterns = s.Serialize<float>(distanceBetweenPatterns, name: "distanceBetweenPatterns");
					nbPatterns = s.Serialize<uint>(nbPatterns, name: "nbPatterns");
					nbLumsInPattern = s.Serialize<uint>(nbLumsInPattern, name: "nbLumsInPattern");
					startNode = s.Serialize<uint>(startNode, name: "startNode");
					spawningEffectMoveSpeed = s.Serialize<float>(spawningEffectMoveSpeed, name: "spawningEffectMoveSpeed");
					disappearTimeInterval = s.Serialize<float>(disappearTimeInterval, name: "disappearTimeInterval");
					isHidden = s.Serialize<bool>(isHidden, name: "isHidden");
					alwaysRed = s.Serialize<bool>(alwaysRed, name: "alwaysRed");
					disappearingTime = s.Serialize<float>(disappearingTime, name: "disappearingTime");
					particleDisappearingInterval = s.Serialize<float>(particleDisappearingInterval, name: "particleDisappearingInterval");
					particleDisappearForward = s.Serialize<bool>(particleDisappearForward, name: "particleDisappearForward");
					interactiveActorOffsets = s.Serialize<InteractiveOffset>(interactiveActorOffsets, name: "interactiveActorOffsets");
					flipInteractiveActor = s.Serialize<bool>(flipInteractiveActor, name: "flipInteractiveActor");
					useFireflyCloud = s.Serialize<bool>(useFireflyCloud, name: "useFireflyCloud");
					displayLinks = s.Serialize<bool>(displayLinks, name: "displayLinks");
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					tutoSucceeded = s.Serialize<bool>(tutoSucceeded, name: "tutoSucceeded");
					particles = s.SerializeObject<CListO<RO2_LumsChainComponent.st_Particle>>(particles, name: "particles");
					aliveParticles = s.SerializeObject<CArrayP<uint>>(aliveParticles, name: "aliveParticles");
					links = s.SerializeObject<CListO<RO2_LumsChainComponent.st_cursors>>(links, name: "links");
					state = s.Serialize<Enum_state>(state, name: "state");
					isActivated = s.Serialize<bool>(isActivated, name: "isActivated");
					perfectActivation = s.Serialize<bool>(perfectActivation, name: "perfectActivation");
				} else {
					aliveParticles = s.SerializeObject<CArrayP<uint>>(aliveParticles, name: "aliveParticles");
				}
				DuplicateLumChainsOffsets = s.SerializeObject<CListP<float>>(DuplicateLumChainsOffsets, name: "DuplicateLumChainsOffsets");
			}
		}
		[Games(GameFlags.RA)]
		public partial class st_cursors : CSerializable {
			public uint indexStart;
			public uint indexEnd;
			public float currentCursorStart;
			public float currentCursorEnd;
			public bool catchingStart;
			public bool catchingEnd;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				indexStart = s.Serialize<uint>(indexStart, name: "indexStart");
				indexEnd = s.Serialize<uint>(indexEnd, name: "indexEnd");
				currentCursorStart = s.Serialize<float>(currentCursorStart, name: "currentCursorStart");
				currentCursorEnd = s.Serialize<float>(currentCursorEnd, name: "currentCursorEnd");
				catchingStart = s.Serialize<bool>(catchingStart, name: "catchingStart");
				catchingEnd = s.Serialize<bool>(catchingEnd, name: "catchingEnd");
			}
		}
		[Games(GameFlags.RA)]
		public partial class st_Particle : CSerializable {
			public PARTICLESTATE state;
			public float cursorDest;
			public float currentDistance;
			public float currentTarget;
			public float timeToWait;
			public float currentSpeed;
			public float currentSpeedFactor;
			public float maxSpeedReached;
			public float initialCurveRatio;
			public float attractiveForce;
			public float arrivalBlend;
			public float timeBeforeDisappearing;
			public uint frameToWait;
			public uint bitfield;
			public Vec3d pos;
			public Angle angle;
			public Vec2d speed;
			public uint frameCount;
			public uint frameOffset;
			public ANIM animState;
			public float alpha;
			public uint animIndex;
			public uint frame;
			public float timeInState;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				state = s.Serialize<PARTICLESTATE>(state, name: "state");
				cursorDest = s.Serialize<float>(cursorDest, name: "cursorDest");
				currentDistance = s.Serialize<float>(currentDistance, name: "currentDistance");
				currentTarget = s.Serialize<float>(currentTarget, name: "currentTarget");
				timeToWait = s.Serialize<float>(timeToWait, name: "timeToWait");
				currentSpeed = s.Serialize<float>(currentSpeed, name: "currentSpeed");
				currentSpeedFactor = s.Serialize<float>(currentSpeedFactor, name: "currentSpeedFactor");
				maxSpeedReached = s.Serialize<float>(maxSpeedReached, name: "maxSpeedReached");
				initialCurveRatio = s.Serialize<float>(initialCurveRatio, name: "initialCurveRatio");
				attractiveForce = s.Serialize<float>(attractiveForce, name: "attractiveForce");
				arrivalBlend = s.Serialize<float>(arrivalBlend, name: "arrivalBlend");
				timeBeforeDisappearing = s.Serialize<float>(timeBeforeDisappearing, name: "timeBeforeDisappearing");
				frameToWait = s.Serialize<uint>(frameToWait, name: "frameToWait");
				bitfield = s.Serialize<uint>(bitfield, name: "bitfield");
				pos = s.SerializeObject<Vec3d>(pos, name: "pos");
				angle = s.SerializeObject<Angle>(angle, name: "angle");
				speed = s.SerializeObject<Vec2d>(speed, name: "speed");
				frameCount = s.Serialize<uint>(frameCount, name: "frameCount");
				frameOffset = s.Serialize<uint>(frameOffset, name: "frameOffset");
				animState = s.Serialize<ANIM>(animState, name: "animState");
				alpha = s.Serialize<float>(alpha, name: "alpha");
				animIndex = s.Serialize<uint>(animIndex, name: "animIndex");
				frame = s.Serialize<uint>(frame, name: "frame");
				timeInState = s.Serialize<float>(timeInState, name: "timeInState");
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
		public enum Enum_state {
			[Serialize("CHAINSTATE_READY_TO_SPAWN"          )] CHAINSTATE_READY_TO_SPAWN = 0,
			[Serialize("CHAINSTATE_WAITING_FOR_SPAWN_EFFECT")] CHAINSTATE_WAITING_FOR_SPAWN_EFFECT = 1,
			[Serialize("CHAINSTATE_START_EFFECT"            )] CHAINSTATE_START_EFFECT = 2,
			[Serialize("CHAINSTATE_SPAWNING"                )] CHAINSTATE_SPAWNING = 3,
			[Serialize("CHAINSTATE_MOVING_ON_TRAJECTORY"    )] CHAINSTATE_MOVING_ON_TRAJECTORY = 4,
			[Serialize("CHAINSTATE_REACHED_THE_END"         )] CHAINSTATE_REACHED_THE_END = 5,
			[Serialize("PARTICLESTATE_DISAPPEARING"         )] PARTICLESTATE_DISAPPEARING = 7,
			[Serialize("CHAINSTATE_NONE"                    )] CHAINSTATE_NONE = 6,
		}
		public enum Enum_state2 {
			[Serialize("CHAINSTATE_READY_TO_SPAWN"          )] CHAINSTATE_READY_TO_SPAWN = 0,
			[Serialize("CHAINSTATE_WAITING_FOR_SPAWN_EFFECT")] CHAINSTATE_WAITING_FOR_SPAWN_EFFECT = 1,
			[Serialize("CHAINSTATE_START_EFFECT"            )] CHAINSTATE_START_EFFECT = 2,
			[Serialize("CHAINSTATE_SPAWNING"                )] CHAINSTATE_SPAWNING = 3,
			[Serialize("CHAINSTATE_MOVING_ON_TRAJECTORY"    )] CHAINSTATE_MOVING_ON_TRAJECTORY = 4,
			[Serialize("CHAINSTATE_REACHED_THE_END"         )] CHAINSTATE_REACHED_THE_END = 5,
			[Serialize("PARTICLESTATE_DISAPPEARING"         )] PARTICLESTATE_DISAPPEARING = 8,
			[Serialize("CHAINSTATE_NONE"                    )] CHAINSTATE_NONE = 6,
		}
		public override uint? ClassCRC => 0x7A3F8663;
	}
}

