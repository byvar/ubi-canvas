using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionAppearFromGround_Template : BTAction_Template {
		[Serialize("anim")] public StringID anim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(anim));
		}
		public override uint? ClassCRC => 0x9262847B;
	}
}

