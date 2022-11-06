using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionAppearBackgroundLadders_Template : RO2_BTActionAppearBackground_Template {
		public StringID animClimbBack;
		public StringID animClimbFore;
		public float speedClimb;
		public float jumpToActorMinTime;
		public float jumpToActorYFuncPoint0Dist;
		public float jumpToActorYFuncPoint1Dist;
		public float jumpToActorXZFuncPoint0T;
		public float jumpToActorXZFuncPoint1T;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animClimbBack = s.SerializeObject<StringID>(animClimbBack, name: "animClimbBack");
			animClimbFore = s.SerializeObject<StringID>(animClimbFore, name: "animClimbFore");
			speedClimb = s.Serialize<float>(speedClimb, name: "speedClimb");
			jumpToActorMinTime = s.Serialize<float>(jumpToActorMinTime, name: "jumpToActorMinTime");
			jumpToActorYFuncPoint0Dist = s.Serialize<float>(jumpToActorYFuncPoint0Dist, name: "jumpToActorYFuncPoint0Dist");
			jumpToActorYFuncPoint1Dist = s.Serialize<float>(jumpToActorYFuncPoint1Dist, name: "jumpToActorYFuncPoint1Dist");
			jumpToActorXZFuncPoint0T = s.Serialize<float>(jumpToActorXZFuncPoint0T, name: "jumpToActorXZFuncPoint0T");
			jumpToActorXZFuncPoint1T = s.Serialize<float>(jumpToActorXZFuncPoint1T, name: "jumpToActorXZFuncPoint1T");
		}
		public override uint? ClassCRC => 0xAF94397F;
	}
}

