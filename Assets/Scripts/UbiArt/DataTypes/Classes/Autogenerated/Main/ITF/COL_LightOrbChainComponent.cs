namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_LightOrbChainComponent : CSerializable {
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
		public InteractiveOffset interactiveActorOffsets;
		public bool flipInteractiveActor;
		public bool useFireflyCloud;
		public bool displayLinks;
		public uint orbCount;
		public float healthOrbsMin;
		public float healthOrbsMax;
		public float manaOrbsMin;
		public float manaOrbsMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
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
				orbCount = s.Serialize<uint>(orbCount, name: "orbCount");
				healthOrbsMin = s.Serialize<float>(healthOrbsMin, name: "healthOrbsMin");
				healthOrbsMax = s.Serialize<float>(healthOrbsMax, name: "healthOrbsMax");
				manaOrbsMin = s.Serialize<float>(manaOrbsMin, name: "manaOrbsMin");
				manaOrbsMax = s.Serialize<float>(manaOrbsMax, name: "manaOrbsMax");
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
		public override uint? ClassCRC => 0xD14D16D5;
	}
}

