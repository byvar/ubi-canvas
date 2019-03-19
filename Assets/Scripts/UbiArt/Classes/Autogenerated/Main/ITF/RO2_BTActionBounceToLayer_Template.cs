using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionBounceToLayer_Template : BTAction_Template {
		[Serialize("anim")] public StringID anim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(anim));
		}
		public override uint? ClassCRC => 0xE9AE4E3E;
	}
}

