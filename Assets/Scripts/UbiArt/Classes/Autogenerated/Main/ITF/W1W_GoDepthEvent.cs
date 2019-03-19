using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_GoDepthEvent : Event {
		[Serialize("float__0")] public float float__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(float__0));
		}
		public override uint? ClassCRC => 0x160FCA60;
	}
}

