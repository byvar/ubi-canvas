using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_BossLuchadoreTriggerComponent : ActorComponent {
		public LE luchadoreEvent;
		public StringID phaseTag;
		public StringID instructionTag;
		public LF neededFlags;
		public LT tweenSelection;
		public LT secondaryTweenSelection;
		public bool triggerOnce;
		public Vec2d tweenOffset;
		public LTLegends tweenSelection2;
		public LTLegends secondaryTweenSelection2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				luchadoreEvent = s.Serialize<LE>(luchadoreEvent, name: "luchadoreEvent");
				phaseTag = s.SerializeObject<StringID>(phaseTag, name: "phaseTag");
				instructionTag = s.SerializeObject<StringID>(instructionTag, name: "instructionTag");
				neededFlags = s.Serialize<LF>(neededFlags, name: "neededFlags");
				tweenSelection2 = s.Serialize<LTLegends>(tweenSelection2, name: "tweenSelection");
				secondaryTweenSelection2 = s.Serialize<LTLegends>(secondaryTweenSelection2, name: "secondaryTweenSelection");
				triggerOnce = s.Serialize<bool>(triggerOnce, name: "triggerOnce", options: CSerializerObject.Options.BoolAsByte);
				tweenOffset = s.SerializeObject<Vec2d>(tweenOffset, name: "tweenOffset");
			} else {
				luchadoreEvent = s.Serialize<LE>(luchadoreEvent, name: "luchadoreEvent");
				phaseTag = s.SerializeObject<StringID>(phaseTag, name: "phaseTag");
				instructionTag = s.SerializeObject<StringID>(instructionTag, name: "instructionTag");
				neededFlags = s.Serialize<LF>(neededFlags, name: "neededFlags");
				tweenSelection = s.Serialize<LT>(tweenSelection, name: "tweenSelection");
				secondaryTweenSelection = s.Serialize<LT>(secondaryTweenSelection, name: "secondaryTweenSelection");
				triggerOnce = s.Serialize<bool>(triggerOnce, name: "triggerOnce");
				tweenOffset = s.SerializeObject<Vec2d>(tweenOffset, name: "tweenOffset");
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
		public enum LTLegends {
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

