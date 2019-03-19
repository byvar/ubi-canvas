using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_LightOrbChainComponent : CSerializable {
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
		[Serialize("interactiveActorOffsets"      )] public InteractiveOffset interactiveActorOffsets;
		[Serialize("flipInteractiveActor"         )] public bool flipInteractiveActor;
		[Serialize("useFireflyCloud"              )] public bool useFireflyCloud;
		[Serialize("displayLinks"                 )] public bool displayLinks;
		[Serialize("orbCount"                     )] public uint orbCount;
		[Serialize("healthOrbsMin"                )] public float healthOrbsMin;
		[Serialize("healthOrbsMax"                )] public float healthOrbsMax;
		[Serialize("manaOrbsMin"                  )] public float manaOrbsMin;
		[Serialize("manaOrbsMax"                  )] public float manaOrbsMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(moveSpeed));
				SerializeField(s, nameof(useGlobalSpeedFactor), boolAsByte: true);
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
				SerializeField(s, nameof(flipInteractiveActor), boolAsByte: true);
				SerializeField(s, nameof(useFireflyCloud), boolAsByte: true);
				SerializeField(s, nameof(displayLinks), boolAsByte: true);
				SerializeField(s, nameof(orbCount));
				SerializeField(s, nameof(healthOrbsMin));
				SerializeField(s, nameof(healthOrbsMax));
				SerializeField(s, nameof(manaOrbsMin));
				SerializeField(s, nameof(manaOrbsMax));
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
		public override uint? ClassCRC => 0x5D2E5715;
	}
}

