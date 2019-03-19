using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIShooterFlyingBombBehavior_Template : TemplateAIBehavior {
		[Serialize("moveAction"             )] public Generic<AIBezierAction_Template> moveAction;
		[Serialize("openingAction"          )] public Generic<AIAction_Template> openingAction;
		[Serialize("alarmAction"            )] public Generic<AIAction_Template> alarmAction;
		[Serialize("explodeAction"          )] public Generic<AIAction_Template> explodeAction;
		[Serialize("alarmAnimName"          )] public StringID alarmAnimName;
		[Serialize("warnAnimName"           )] public StringID warnAnimName;
		[Serialize("alarmDuration"          )] public float alarmDuration;
		[Serialize("isTriggered"            )] public int isTriggered;
		[Serialize("moveActionInitScale"    )] public float moveActionInitScale;
		[Serialize("animationBankState"     )] public uint animationBankState;
		[Serialize("explodeOnMoveActionsEnd")] public int explodeOnMoveActionsEnd;
		[Serialize("moveActionVecOffsetMin" )] public Vector2 moveActionVecOffsetMin;
		[Serialize("moveActionVecOffsetMax" )] public Vector2 moveActionVecOffsetMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(moveAction));
			SerializeField(s, nameof(openingAction));
			SerializeField(s, nameof(alarmAction));
			SerializeField(s, nameof(explodeAction));
			SerializeField(s, nameof(alarmAnimName));
			SerializeField(s, nameof(warnAnimName));
			SerializeField(s, nameof(alarmDuration));
			SerializeField(s, nameof(isTriggered));
			SerializeField(s, nameof(moveActionInitScale));
			SerializeField(s, nameof(animationBankState));
			SerializeField(s, nameof(explodeOnMoveActionsEnd));
			SerializeField(s, nameof(moveActionVecOffsetMin));
			SerializeField(s, nameof(moveActionVecOffsetMax));
		}
		public override uint? ClassCRC => 0x877B0B35;
	}
}

