using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionAppearBackground_Rope_Template : BTAction_Template {
		public StringID animStandBack;
		public StringID animClimbBack;
		public StringID animJumpBack;
		public StringID animLandBack;
		public StringID animStandFore;
		public StringID animClimbFore;
		public StringID animJumpFore;
		public StringID animLandFore;
		public bool waitForTrigger;
		public bool disablePhys;
		public bool resetAngle;
		public float speedClimb;
		public float jumpToActorMinTime;
		public float jumpToActorYFuncPoint0Dist;
		public float jumpToActorYFuncPoint1Dist;
		public float jumpToActorXZFuncPoint0T;
		public float jumpToActorXZFuncPoint1T;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animStandBack = s.SerializeObject<StringID>(animStandBack, name: "animStandBack");
			animClimbBack = s.SerializeObject<StringID>(animClimbBack, name: "animClimbBack");
			animJumpBack = s.SerializeObject<StringID>(animJumpBack, name: "animJumpBack");
			animLandBack = s.SerializeObject<StringID>(animLandBack, name: "animLandBack");
			animStandFore = s.SerializeObject<StringID>(animStandFore, name: "animStandFore");
			animClimbFore = s.SerializeObject<StringID>(animClimbFore, name: "animClimbFore");
			animJumpFore = s.SerializeObject<StringID>(animJumpFore, name: "animJumpFore");
			animLandFore = s.SerializeObject<StringID>(animLandFore, name: "animLandFore");
			waitForTrigger = s.Serialize<bool>(waitForTrigger, name: "waitForTrigger");
			disablePhys = s.Serialize<bool>(disablePhys, name: "disablePhys");
			resetAngle = s.Serialize<bool>(resetAngle, name: "resetAngle");
			speedClimb = s.Serialize<float>(speedClimb, name: "speedClimb");
			jumpToActorMinTime = s.Serialize<float>(jumpToActorMinTime, name: "jumpToActorMinTime");
			jumpToActorYFuncPoint0Dist = s.Serialize<float>(jumpToActorYFuncPoint0Dist, name: "jumpToActorYFuncPoint0Dist");
			jumpToActorYFuncPoint1Dist = s.Serialize<float>(jumpToActorYFuncPoint1Dist, name: "jumpToActorYFuncPoint1Dist");
			jumpToActorXZFuncPoint0T = s.Serialize<float>(jumpToActorXZFuncPoint0T, name: "jumpToActorXZFuncPoint0T");
			jumpToActorXZFuncPoint1T = s.Serialize<float>(jumpToActorXZFuncPoint1T, name: "jumpToActorXZFuncPoint1T");
		}
		public override uint? ClassCRC => 0x84C8ACC4;
	}
}

