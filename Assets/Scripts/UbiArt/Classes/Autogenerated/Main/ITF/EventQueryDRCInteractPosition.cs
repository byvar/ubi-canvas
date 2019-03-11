using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventQueryDRCInteractPosition : Event {
		[Serialize("position")] public Vector2 position;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(position));
		}
		public override uint? ClassCRC => 0x03B0E285;
	}
}

