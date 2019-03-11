using UnityEngine;

namespace UbiArt.ITF {
	public partial class AlwaysActiveActorComponent_Template : ActorComponent_Template {
		[Serialize("safeTimeOutDuration")] public float safeTimeOutDuration;
		[Serialize("stopOnScreenLeaving")] public bool stopOnScreenLeaving;
		[Serialize("startEvent"         )] public Generic<Event> startEvent;
		[Serialize("stopEvent"          )] public Generic<Event> stopEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(safeTimeOutDuration));
			SerializeField(s, nameof(stopOnScreenLeaving));
			SerializeField(s, nameof(startEvent));
			SerializeField(s, nameof(stopEvent));
		}
		public override uint? ClassCRC => 0x555E08BF;
	}
}

