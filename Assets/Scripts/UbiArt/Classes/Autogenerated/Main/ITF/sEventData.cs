using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class sEventData : CSerializable {
		public Generic<Event> _event;
		public float delay;
		public bool selfListener;
		public bool sendToChildren;
		public StringID tagName;
		public StringID tagValue;
		public bool sendToActivator;
		public bool broadcast;
		public Generic<Event> Generic_Event__0;
		public float float__1;
		public bool bool__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				Generic_Event__0 = s.SerializeObject<Generic<Event>>(Generic_Event__0, name: "Generic<Event>__0");
				float__1 = s.Serialize<float>(float__1, name: "float__1");
				bool__2 = s.Serialize<bool>(bool__2, name: "bool__2");
			} else {
				_event = s.SerializeObject<Generic<Event>>(_event, name: "event");
				delay = s.Serialize<float>(delay, name: "delay");
				selfListener = s.Serialize<bool>(selfListener, name: "selfListener");
				sendToChildren = s.Serialize<bool>(sendToChildren, name: "sendToChildren");
				tagName = s.SerializeObject<StringID>(tagName, name: "tagName");
				tagValue = s.SerializeObject<StringID>(tagValue, name: "tagValue");
				sendToActivator = s.Serialize<bool>(sendToActivator, name: "sendToActivator");
				broadcast = s.Serialize<bool>(broadcast, name: "broadcast");
			}
		}
		public override uint? ClassCRC => 0xE02A766E;
	}
}

