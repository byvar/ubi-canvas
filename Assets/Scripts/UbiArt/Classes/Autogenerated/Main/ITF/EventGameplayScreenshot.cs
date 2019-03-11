using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventGameplayScreenshot : Event {
		[Serialize("delay")] public float delay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(delay));
		}
		public override uint? ClassCRC => 0xFBDEF2B8;
	}
}

