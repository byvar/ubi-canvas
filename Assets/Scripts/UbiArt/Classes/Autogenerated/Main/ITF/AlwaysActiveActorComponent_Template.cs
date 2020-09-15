using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class AlwaysActiveActorComponent_Template : ActorComponent_Template {
		public float safeTimeOutDuration;
		public bool stopOnScreenLeaving;
		public Generic<Event> startEvent;
		public Generic<Event> stopEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			safeTimeOutDuration = s.Serialize<float>(safeTimeOutDuration, name: "safeTimeOutDuration");
			stopOnScreenLeaving = s.Serialize<bool>(stopOnScreenLeaving, name: "stopOnScreenLeaving");
			startEvent = s.SerializeObject<Generic<Event>>(startEvent, name: "startEvent");
			stopEvent = s.SerializeObject<Generic<Event>>(stopEvent, name: "stopEvent");
		}
		public override uint? ClassCRC => 0x555E08BF;
	}
}

