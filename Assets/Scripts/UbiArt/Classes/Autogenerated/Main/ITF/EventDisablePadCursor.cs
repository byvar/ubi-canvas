using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventDisablePadCursor : Event {
		[Serialize("Disabled")] public bool Disabled;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Disabled));
		}
		public override uint? ClassCRC => 0x5B0A456D;
	}
}

