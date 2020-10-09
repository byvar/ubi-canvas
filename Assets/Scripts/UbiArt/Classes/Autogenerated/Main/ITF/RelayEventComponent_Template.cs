using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class RelayEventComponent_Template : ActorComponent_Template {
		public CListO<ITF.RelayData> relays;
		public CListO<ITF.RelayEventComponent_Template.RelayData> relays2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RJR) {
				relays2 = s.SerializeObject<CListO<ITF.RelayEventComponent_Template.RelayData>>(relays2, name: "relays");
			} else {
				relays = s.SerializeObject<CListO<ITF.RelayData>>(relays, name: "relays");
			}
		}
		[Games(GameFlags.ROVersion)]
		public partial class RelayData : CSerializable {
			public Generic<Event> eventToListen;
			public Generic<Event> eventToRelay;
			public float delay;
			public bool triggerSelf;
			public bool triggerChildren;
			public bool triggerBroadcast;
			public bool replaceSender;
			public bool replaceSenderByActivator;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				eventToListen = s.SerializeObject<Generic<Event>>(eventToListen, name: "eventToListen");
				eventToRelay = s.SerializeObject<Generic<Event>>(eventToRelay, name: "eventToRelay");
				delay = s.Serialize<float>(delay, name: "delay");
				triggerSelf = s.Serialize<bool>(triggerSelf, name: "triggerSelf");
				triggerChildren = s.Serialize<bool>(triggerChildren, name: "triggerChildren");
				triggerBroadcast = s.Serialize<bool>(triggerBroadcast, name: "triggerBroadcast");
				replaceSender = s.Serialize<bool>(replaceSender, name: "replaceSender");
				replaceSenderByActivator = s.Serialize<bool>(replaceSenderByActivator, name: "replaceSenderByActivator");
			}
		}
		public override uint? ClassCRC => 0x060B7DC1;
	}
}

