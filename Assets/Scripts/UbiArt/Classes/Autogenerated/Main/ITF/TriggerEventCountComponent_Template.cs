using UnityEngine;

namespace UbiArt.ITF {
	public partial class TriggerEventCountComponent_Template : ActorComponent_Template {
		[Serialize("eventToCount")] public Generic<Event> eventToCount;
		[Serialize("eventToSend" )] public Generic<Event> eventToSend;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(eventToCount));
			SerializeField(s, nameof(eventToSend));
		}
		public override uint? ClassCRC => 0x609B3DB2;
	}
}

