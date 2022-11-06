using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_BTActionActivateStone_Template : BTAction_Template {
		public StringID anim;
		public StringID finishAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			anim = s.SerializeObject<StringID>(anim, name: "anim");
			finishAnim = s.SerializeObject<StringID>(finishAnim, name: "finishAnim");
		}
		public override uint? ClassCRC => 0x24B88610;
	}
}

