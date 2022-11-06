using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_465_sub_B91FE0 : CSerializable {
		public Placeholder moveAction;
		public Placeholder openingAction;
		public Placeholder alarmAction;
		public Placeholder explodeAction;
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
			moveAction = s.SerializeObject<Placeholder>(moveAction, name: "moveAction");
			openingAction = s.SerializeObject<Placeholder>(openingAction, name: "openingAction");
			alarmAction = s.SerializeObject<Placeholder>(alarmAction, name: "alarmAction");
			explodeAction = s.SerializeObject<Placeholder>(explodeAction, name: "explodeAction");
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

