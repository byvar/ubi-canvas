using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class RO2_LumsChainComponent : ActorComponent {
		[Serialize(0, "moveSpeed")] public float moveSpeed;
		[Serialize(1, "useGlobalSpeedFactor")] public bool useGlobalSpeedFactor;
		[Serialize(2, "trajectory")] public Trajectory trajectory;
		[Serialize(3, "chainOrder")] public ChainOrder chainOrder;
		[Serialize(4, "spawnMode")] public SpawnMode spawnMode;
		[Serialize(5, "DRCMode")] public DRCMode drcMode;
		[Serialize(6, "spawningFrameInterval")] public uint spawningFrameInterval;
		[Serialize(7, "patternSpawningInterval")] public uint patternSpawningInterval;
		[Serialize(8, "startBlend")] public float startBlend;
		[Serialize(9, "animFrameOffset")] public uint animFrameOffset;
		[Serialize(10, "slowDownDistance")] public float slowDownDistance;
		[Serialize(11, "distanceBetweenFinalPositions")] public float distanceBetweenFinalPositions;
		[Serialize(12, "distanceBetweenPatterns")] public float distanceBetweenPatterns;
		[Serialize(13, "nbPatterns")] public uint nbPatterns;
		[Serialize(14, "nbLumsInPattern")] public uint nbLumsInPattern;
		[Serialize(15, "startNode")] public uint startNode;
		[Serialize(16, "spawningEffectMoveSpeed")] public float spawningEffectMoveSpeed;
		[Serialize(17, "disappearTimeInterval")] public float disappearTimeInterval;
		[Serialize(18, "isHidden", game = Settings.Game.RA)] public bool isHidden;
		[Serialize(19, "alwaysRed", game = Settings.Game.RA)] public bool alwaysRed;
		[Serialize(20, "disappearingTime", game = Settings.Game.RA)] public float disappearingTime;
		[Serialize(21, "particleDisappearingInterval", game = Settings.Game.RA)] public float particleDisappearingInterval;
		[Serialize(22, "particleDisappearForward", game = Settings.Game.RA)] public bool particleDisappearForward;
		[Serialize(23, "interactiveActorOffsets")] public InteractiveOffset interactiveActorOffsets;
		[Serialize(24, "flipInteractiveActor")] public bool flipInteractiveActor;
		[Serialize(25, "useFireflyCloud")] public bool useFireflyCloud;
		[Serialize(26, "displayLinks")] public bool displayLinks;
		[Serialize(27, "DuplicateLumChainsOffsets", game = Settings.Game.RA)] public Container<float> duplicateLumChainsOffsets;


		public RO2_LumsChainComponent(Reader reader) : base(reader) {
		}

		public enum Trajectory {
			FollowChain = 0,
			GoToTheEnd
		}

		public enum ChainOrder {
			BeginToEnd = 0,
			EndToBegin
		}

		public enum SpawnMode {
			Delayed = 0,
			StartSpawnedBegin,
			StartSpawnedEnd,
			StartSpawnedBeginDelayed,
			DelayedWithStartEffect
		}

		public enum DRCMode {
			DrawAllYellow = 0,
			TimedActivation = 2,
			FirstPurpleAllYellow
		}

		public enum InteractiveOffset {
			Down = 0,
			Middle,
			BreakableMiddleUp,
			BreakableDown,
			BreakableMiddleDown
		}
	}
}
