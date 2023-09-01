namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_AIShooterFlyingBombBehavior_Template : TemplateAIBehavior {
		public Generic<AIAction_Template> moveAction;
		public Generic<AIAction_Template> openingAction;
		public Generic<AIAction_Template> alarmAction;
		public Generic<AIAction_Template> explodeAction;
		public StringID alarmAnimName;
		public StringID warnAnimName;
		public float alarmDuration;
		public int isTriggered;
		public float moveActionInitScale;
		public int explodeOnMoveActionsEnd;
		public Vec2d moveActionVecOffsetMin;
		public Vec2d moveActionVecOffsetMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			moveAction = s.SerializeObject<Generic<AIAction_Template>>(moveAction, name: "moveAction");
			openingAction = s.SerializeObject<Generic<AIAction_Template>>(openingAction, name: "openingAction");
			alarmAction = s.SerializeObject<Generic<AIAction_Template>>(alarmAction, name: "alarmAction");
			explodeAction = s.SerializeObject<Generic<AIAction_Template>>(explodeAction, name: "explodeAction");
			alarmAnimName = s.SerializeObject<StringID>(alarmAnimName, name: "alarmAnimName");
			warnAnimName = s.SerializeObject<StringID>(warnAnimName, name: "warnAnimName");
			alarmDuration = s.Serialize<float>(alarmDuration, name: "alarmDuration");
			isTriggered = s.Serialize<int>(isTriggered, name: "isTriggered");
			moveActionInitScale = s.Serialize<float>(moveActionInitScale, name: "moveActionInitScale");
			explodeOnMoveActionsEnd = s.Serialize<int>(explodeOnMoveActionsEnd, name: "explodeOnMoveActionsEnd");
			moveActionVecOffsetMin = s.SerializeObject<Vec2d>(moveActionVecOffsetMin, name: "moveActionVecOffsetMin");
			moveActionVecOffsetMax = s.SerializeObject<Vec2d>(moveActionVecOffsetMax, name: "moveActionVecOffsetMax");
		}
		public override uint? ClassCRC => 0x74980334;
	}
}

