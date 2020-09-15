using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionScoreRecap_Template : BTAction_Template {
		public StringID animHappy;
		public StringID animWalk;
		public StringID animJump;
		public StringID animDance;
		public StringID animIncantation_Step1;
		public StringID animIncantation_Step2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animHappy = s.SerializeObject<StringID>(animHappy, name: "animHappy");
			animWalk = s.SerializeObject<StringID>(animWalk, name: "animWalk");
			animJump = s.SerializeObject<StringID>(animJump, name: "animJump");
			animDance = s.SerializeObject<StringID>(animDance, name: "animDance");
			animIncantation_Step1 = s.SerializeObject<StringID>(animIncantation_Step1, name: "animIncantation_Step1");
			animIncantation_Step2 = s.SerializeObject<StringID>(animIncantation_Step2, name: "animIncantation_Step2");
		}
		public override uint? ClassCRC => 0x1C661DEA;
	}
}

