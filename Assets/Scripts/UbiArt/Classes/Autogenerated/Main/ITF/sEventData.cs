using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class sEventData : CSerializable {
		[Serialize("event"            )] public Generic<Event> _event;
		[Serialize("delay"            )] public float delay;
		[Serialize("selfListener"     )] public bool selfListener;
		[Serialize("sendToChildren"   )] public bool sendToChildren;
		[Serialize("tagName"          )] public StringID tagName;
		[Serialize("tagValue"         )] public StringID tagValue;
		[Serialize("sendToActivator"  )] public bool sendToActivator;
		[Serialize("broadcast"        )] public bool broadcast;
		[Serialize("Generic<Event>__0")] public Generic<Event> Generic_Event__0;
		[Serialize("float__1"         )] public float float__1;
		[Serialize("bool__2"          )] public bool bool__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(Generic_Event__0));
				SerializeField(s, nameof(float__1));
				SerializeField(s, nameof(bool__2));
			} else {
				SerializeField(s, nameof(_event));
				SerializeField(s, nameof(delay));
				SerializeField(s, nameof(selfListener));
				SerializeField(s, nameof(sendToChildren));
				SerializeField(s, nameof(tagName));
				SerializeField(s, nameof(tagValue));
				SerializeField(s, nameof(sendToActivator));
				SerializeField(s, nameof(broadcast));
			}
		}
		public override uint? ClassCRC => 0xE02A766E;
	}
}

