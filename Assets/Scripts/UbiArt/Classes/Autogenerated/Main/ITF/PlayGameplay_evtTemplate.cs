using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class PlayGameplay_evtTemplate : SequenceEventWithActor_Template {
		[Serialize("onEnterEventName")] public string onEnterEventName;
		[Serialize("onEnterEvent"    )] public Generic<Event> onEnterEvent;
		[Serialize("onExitEventName" )] public string onExitEventName;
		[Serialize("onExitEvent"     )] public Generic<Event> onExitEvent;
		[Serialize("executeOnce"     )] public bool executeOnce;
		[Serialize("broadcast"       )] public bool broadcast;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(onEnterEventName));
			SerializeField(s, nameof(onEnterEvent));
			SerializeField(s, nameof(onExitEventName));
			SerializeField(s, nameof(onExitEvent));
			SerializeField(s, nameof(executeOnce));
			SerializeField(s, nameof(broadcast));
		}
		public override uint? ClassCRC => 0x58127C88;
	}
}

