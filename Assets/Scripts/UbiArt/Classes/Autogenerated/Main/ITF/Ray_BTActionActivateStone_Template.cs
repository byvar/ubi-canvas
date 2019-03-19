using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_BTActionActivateStone_Template : BTAction_Template {
		[Serialize("anim"      )] public StringID anim;
		[Serialize("finishAnim")] public StringID finishAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(anim));
			SerializeField(s, nameof(finishAnim));
		}
		public override uint? ClassCRC => 0x24B88610;
	}
}

