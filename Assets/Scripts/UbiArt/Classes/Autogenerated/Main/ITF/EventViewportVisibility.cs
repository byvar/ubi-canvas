using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventViewportVisibility : Event {
		[Serialize("ViewportVisibility")] public uint ViewportVisibility;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ViewportVisibility));
		}
		public override uint? ClassCRC => 0x6CBBD40F;
	}
}

