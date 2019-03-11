using UnityEngine;

namespace UbiArt.ITF {
	public partial class AnimMarkerTriggerComponent_Template : TriggerComponent_Template {
		[Serialize("markerEvents")] public CList<MarkerEvent> markerEvents;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(markerEvents));
		}
		public override uint? ClassCRC => 0x5D8DDF58;
	}
}

