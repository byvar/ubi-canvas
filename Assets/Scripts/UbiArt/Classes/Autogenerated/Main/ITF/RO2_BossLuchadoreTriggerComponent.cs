using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BossLuchadoreTriggerComponent : ActorComponent {
		[Serialize("luchadoreEvent"         )] public LE luchadoreEvent;
		[Serialize("phaseTag"               )] public StringID phaseTag;
		[Serialize("instructionTag"         )] public StringID instructionTag;
		[Serialize("neededFlags"            )] public LF neededFlags;
		[Serialize("tweenSelection"         )] public LT tweenSelection;
		[Serialize("secondaryTweenSelection")] public LT secondaryTweenSelection;
		[Serialize("triggerOnce"            )] public bool triggerOnce;
		[Serialize("tweenOffset"            )] public Vector2 tweenOffset;
		[Serialize("tweenSelection"         )] public LT_Legends tweenSelectionLegends;
		[Serialize("secondaryTweenSelection")] public LT_Legends secondaryTweenSelectionLegends;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(luchadoreEvent));
				SerializeField(s, nameof(phaseTag));
				SerializeField(s, nameof(instructionTag));
				SerializeField(s, nameof(neededFlags));
				SerializeField(s, nameof(tweenSelectionLegends));
				SerializeField(s, nameof(secondaryTweenSelectionLegends));
				SerializeField(s, nameof(triggerOnce));
				SerializeField(s, nameof(tweenOffset));
			} else {
				SerializeField(s, nameof(luchadoreEvent));
				SerializeField(s, nameof(phaseTag));
				SerializeField(s, nameof(instructionTag));
				SerializeField(s, nameof(neededFlags));
				SerializeField(s, nameof(tweenSelection));
				SerializeField(s, nameof(secondaryTweenSelection));
				SerializeField(s, nameof(triggerOnce));
				SerializeField(s, nameof(tweenOffset));
			}
		}
		public enum LE {
			[Serialize("LE_None"                )] None = -1,
			[Serialize("LE_OnInstructionEnter"  )] OnInstructionEnter = 0,
			[Serialize("LE_OnInstructionHit"    )] OnInstructionHit = 1,
			[Serialize("LE_OnInstructionExit"   )] OnInstructionExit = 2,
			[Serialize("LE_OnPhaseEnter"        )] OnPhaseEnter = 3,
			[Serialize("LE_OnPhaseExit"         )] OnPhaseExit = 4,
			[Serialize("LE_OnOpportunityEnter"  )] OnOpportunityEnter = 5,
			[Serialize("LE_OnOpportunitySuccess")] OnOpportunitySuccess = 6,
			[Serialize("LE_OnOpportunityFailed" )] OnOpportunityFailed = 7,
			[Serialize("LE_OnOpportunityExit"   )] OnOpportunityExit = 8,
			[Serialize("LE_OnHitEnter"          )] OnHitEnter = 9,
			[Serialize("LE_OnHitExit"           )] OnHitExit = 10,
			[Serialize("LE_OnInstructionHitBack")] OnInstructionHitBack = 11,
			[Serialize("LE_OnPhasePrepare"      )] OnPhasePrepare = 12,
		}
		public enum LF {
			[Serialize("LF_None"                     )] None = 0,
			[Serialize("LF_WaitOutForbiddenZoneToEnd")] WaitOutForbiddenZoneToEnd = 1,
			[Serialize("LF_Aiming"                   )] Aiming = 2,
		}
		public enum LT {
			[Serialize("LT_None"        )] None = 0,
			[Serialize("LT_ClosestLeft" )] ClosestLeft = 1,
			[Serialize("LT_ClosestRight")] ClosestRight = 2,
			[Serialize("LT_MaxLeft"     )] MaxLeft = 3,
			[Serialize("LT_MaxRight"    )] MaxRight = 4,
		}
		public enum LT_Legends {
			[Serialize("LT_None")] None = 0,
			[Serialize("LT_ClosestLeft")] ClosestLeft = 1,
			[Serialize("LT_ClosestRight")] ClosestRight = 2,
			[Serialize("LT_MaxLeft")] MaxLeft = 3,
			[Serialize("LT_MaxRight")] MaxRight = 4,
			[Serialize("Value_5")] Value_5 = 5,
		}
		public override uint? ClassCRC => 0x90F490C2;
	}
}

