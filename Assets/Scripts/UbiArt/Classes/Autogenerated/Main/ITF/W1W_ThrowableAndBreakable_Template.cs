using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_ThrowableAndBreakable_Template : W1W_ThrowableObject_Template {
		[Serialize("float__0")] public float float__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(float__0));
		}
		public override uint? ClassCRC => 0xCF66BD5D;
	}
}

