using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventGeneric : EventGeneric {
		[Serialize("float__0")] public float float__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(float__0));
		}
		public override uint? ClassCRC => 0x7E674CD1;
	}
}

