using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_LightOrbChainComponent : CSerializable {
		[Serialize("moveSpeed"                    )] public float moveSpeed;
		[Serialize("useGlobalSpeedFactor"         )] public bool useGlobalSpeedFactor;
		[Serialize("trajectory"                   )] public Enum_trajectory trajectory;
		[Serialize("chainOrder"                   )] public Enum_chainOrder chainOrder;
		[Serialize("spawnMode"                    )] public Enum_spawnMode spawnMode;
		[Serialize("DRCMode"                      )] public Enum_DRCMode DRCMode;
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
		[Serialize("interactiveActorOffsets"      )] public Enum_interactiveActorOffsets interactiveActorOffsets;
		[Serialize("flipInteractiveActor"         )] public bool flipInteractiveActor;
		[Serialize("useFireflyCloud"              )] public Placeholder useFireflyCloud;
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
				SerializeField(s, nameof(DRCMode));
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
				SerializeField(s, nameof(useFireflyCloud));
				SerializeField(s, nameof(useFireflyCloud));
				SerializeField(s, nameof(displayLinks), boolAsByte: true);
				SerializeField(s, nameof(orbCount));
				SerializeField(s, nameof(healthOrbsMin));
				SerializeField(s, nameof(healthOrbsMax));
				SerializeField(s, nameof(manaOrbsMin));
				SerializeField(s, nameof(manaOrbsMax));
			}
		}
		public enum Enum_trajectory {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
		}
		public enum Enum_spawnMode {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public enum Enum_DRCMode {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public override uint? ClassCRC => 0x5D2E5715;
	}
}

