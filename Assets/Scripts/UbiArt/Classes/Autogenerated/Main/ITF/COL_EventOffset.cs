using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventOffset : Event {
		[Serialize("offset")] public int offset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(offset));
		}
		public override uint? ClassCRC => 0xA1FBB08B;
	}
}

