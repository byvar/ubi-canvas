using UnityEngine;

namespace UbiArt.ITF {
	public partial class AISendEventAction_Template : AIAction_Template {
		[Serialize("eventToSend"    )] public Generic<Event> eventToSend;
		[Serialize("triggerSelf"    )] public bool triggerSelf;
		[Serialize("triggerChildren")] public bool triggerChildren;
		[Serialize("triggerBinded"  )] public bool triggerBinded;
		[Serialize("broadcast"      )] public bool broadcast;
		[Serialize("virtualChild"   )] public StringID virtualChild;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(eventToSend));
			SerializeField(s, nameof(triggerSelf));
			SerializeField(s, nameof(triggerChildren));
			SerializeField(s, nameof(triggerBinded));
			SerializeField(s, nameof(broadcast));
			SerializeField(s, nameof(virtualChild));
		}
		public override uint? ClassCRC => 0xF053FC8A;
	}
}

