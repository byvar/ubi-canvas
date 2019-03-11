using UnityEngine;

namespace UbiArt.ITF {
	public partial class sEventData : CSerializable {
		[Serialize("event"          )] public Generic<Event> _event;
		[Serialize("delay"          )] public float delay;
		[Serialize("selfListener"   )] public bool selfListener;
		[Serialize("sendToChildren" )] public bool sendToChildren;
		[Serialize("tagName"        )] public StringID tagName;
		[Serialize("tagValue"       )] public StringID tagValue;
		[Serialize("sendToActivator")] public bool sendToActivator;
		[Serialize("broadcast"      )] public bool broadcast;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(_event));
			SerializeField(s, nameof(delay));
			SerializeField(s, nameof(selfListener));
			SerializeField(s, nameof(sendToChildren));
			SerializeField(s, nameof(tagName));
			SerializeField(s, nameof(tagValue));
			SerializeField(s, nameof(sendToActivator));
			SerializeField(s, nameof(broadcast));
		}
		public override uint? ClassCRC => 0xE02A766E;
	}
}

