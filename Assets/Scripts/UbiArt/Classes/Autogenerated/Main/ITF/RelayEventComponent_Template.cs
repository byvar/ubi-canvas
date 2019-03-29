using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class RelayEventComponent_Template : ActorComponent_Template {
		[Serialize("relays")] public CList<ITF.RelayData> relays;
		[Serialize("relays")] public CList<ITF.RelayEventComponent_Template.RelayData> relays2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RJR) {
				SerializeField(s, nameof(relays2));
			} else {
				SerializeField(s, nameof(relays));
			}
		}
		[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
		public partial class RelayData : CSerializable {
			[Serialize("eventToListen"           )] public Generic<Event> eventToListen;
			[Serialize("eventToRelay"            )] public Generic<Event> eventToRelay;
			[Serialize("delay"                   )] public float delay;
			[Serialize("triggerSelf"             )] public bool triggerSelf;
			[Serialize("triggerChildren"         )] public bool triggerChildren;
			[Serialize("triggerBroadcast"        )] public bool triggerBroadcast;
			[Serialize("replaceSender"           )] public bool replaceSender;
			[Serialize("replaceSenderByActivator")] public bool replaceSenderByActivator;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(eventToListen));
				SerializeField(s, nameof(eventToRelay));
				SerializeField(s, nameof(delay));
				SerializeField(s, nameof(triggerSelf));
				SerializeField(s, nameof(triggerChildren));
				SerializeField(s, nameof(triggerBroadcast));
				SerializeField(s, nameof(replaceSender));
				SerializeField(s, nameof(replaceSenderByActivator));
			}
		}
		public override uint? ClassCRC => 0x060B7DC1;
	}
}

