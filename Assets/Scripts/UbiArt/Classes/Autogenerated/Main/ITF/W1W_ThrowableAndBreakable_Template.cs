using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_ThrowableAndBreakable_Template : W1W_ThrowableObject_Template {
		public float float__0__;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			float__0__ = s.Serialize<float>(float__0__, name: "float__0__");
		}
		public override uint? ClassCRC => 0xCF66BD5D;
	}
}

