using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionAppearBackgroundNinja_Template : RO2_BTActionAppearBackground_Template {
		public StringID animNinjaBack;
		public StringID animFallBack;
		public StringID animNinjaFore;
		public StringID animFallFore;
		public float heightNinja;
		public float fallTime;
		public float jumpToActorMinTime;
		public float jumpToActorYFuncPoint0Dist;
		public float jumpToActorYFuncPoint1Dist;
		public float jumpToActorXZFuncPoint0T;
		public float jumpToActorXZFuncPoint1T;
		public bool jumpUseEasing;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animNinjaBack = s.SerializeObject<StringID>(animNinjaBack, name: "animNinjaBack");
			animFallBack = s.SerializeObject<StringID>(animFallBack, name: "animFallBack");
			animNinjaFore = s.SerializeObject<StringID>(animNinjaFore, name: "animNinjaFore");
			animFallFore = s.SerializeObject<StringID>(animFallFore, name: "animFallFore");
			heightNinja = s.Serialize<float>(heightNinja, name: "heightNinja");
			fallTime = s.Serialize<float>(fallTime, name: "fallTime");
			jumpToActorMinTime = s.Serialize<float>(jumpToActorMinTime, name: "jumpToActorMinTime");
			jumpToActorYFuncPoint0Dist = s.Serialize<float>(jumpToActorYFuncPoint0Dist, name: "jumpToActorYFuncPoint0Dist");
			jumpToActorYFuncPoint1Dist = s.Serialize<float>(jumpToActorYFuncPoint1Dist, name: "jumpToActorYFuncPoint1Dist");
			jumpToActorXZFuncPoint0T = s.Serialize<float>(jumpToActorXZFuncPoint0T, name: "jumpToActorXZFuncPoint0T");
			jumpToActorXZFuncPoint1T = s.Serialize<float>(jumpToActorXZFuncPoint1T, name: "jumpToActorXZFuncPoint1T");
			jumpUseEasing = s.Serialize<bool>(jumpUseEasing, name: "jumpUseEasing");
		}
		public override uint? ClassCRC => 0x20D41ABA;
	}
}

