using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BTActionStunned_Template : CSerializable {
		public StringID name;
		public StringID anim;
		public float stunDuration;
		public float minStunDuration;
		public float postStunDuration;
		public float minTimeBetween2Stuns;
		public float secondStunThreshold;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
			anim = s.SerializeObject<StringID>(anim, name: "anim");
			stunDuration = s.Serialize<float>(stunDuration, name: "stunDuration");
			minStunDuration = s.Serialize<float>(minStunDuration, name: "minStunDuration");
			postStunDuration = s.Serialize<float>(postStunDuration, name: "postStunDuration");
			minTimeBetween2Stuns = s.Serialize<float>(minTimeBetween2Stuns, name: "minTimeBetween2Stuns");
			secondStunThreshold = s.Serialize<float>(secondStunThreshold, name: "secondStunThreshold");
		}
		public override uint? ClassCRC => 0x568F2BFF;
	}
}

