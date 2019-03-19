using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionScoreRecap_Template : BTAction_Template {
		[Serialize("animHappy"            )] public StringID animHappy;
		[Serialize("animWalk"             )] public StringID animWalk;
		[Serialize("animJump"             )] public StringID animJump;
		[Serialize("animDance"            )] public StringID animDance;
		[Serialize("animIncantation_Step1")] public StringID animIncantation_Step1;
		[Serialize("animIncantation_Step2")] public StringID animIncantation_Step2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animHappy));
			SerializeField(s, nameof(animWalk));
			SerializeField(s, nameof(animJump));
			SerializeField(s, nameof(animDance));
			SerializeField(s, nameof(animIncantation_Step1));
			SerializeField(s, nameof(animIncantation_Step2));
		}
		public override uint? ClassCRC => 0x1C661DEA;
	}
}

