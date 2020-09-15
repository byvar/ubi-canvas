using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionBounceToLayer_Template : BTAction_Template {
		public StringID anim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			anim = s.SerializeObject<StringID>(anim, name: "anim");
		}
		public override uint? ClassCRC => 0xE9AE4E3E;
	}
}

