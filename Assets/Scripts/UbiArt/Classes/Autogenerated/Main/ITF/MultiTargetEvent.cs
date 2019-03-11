using UnityEngine;

namespace UbiArt.ITF {
	public partial class MultiTargetEvent : CSerializable {
		[Serialize("triggerOnce"         )] public bool triggerOnce;
		[Serialize("triggerSelf"         )] public bool triggerSelf;
		[Serialize("triggerActivator"    )] public bool triggerActivator;
		[Serialize("triggerBroadcast"    )] public bool triggerBroadcast;
		[Serialize("triggerParent"       )] public bool triggerParent;
		[Serialize("triggerChildren"     )] public bool triggerChildren;
		[Serialize("childrenTagList"     )] public CList<ChildrenTagParam> childrenTagList;
		[Serialize("triggerBoundParent"  )] public bool triggerBoundParent;
		[Serialize("triggerBoundChildren")] public bool triggerBoundChildren;
		[Serialize("modeAfterCP"         )] public Mode modeAfterCP;
		[Serialize("triggerOnceDone"     )] public bool triggerOnceDone;
		[Serialize("Events"              )] public CList<Event> Events;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(triggerOnce));
			SerializeField(s, nameof(triggerSelf));
			SerializeField(s, nameof(triggerActivator));
			SerializeField(s, nameof(triggerBroadcast));
			SerializeField(s, nameof(triggerParent));
			SerializeField(s, nameof(triggerChildren));
			SerializeField(s, nameof(childrenTagList));
			SerializeField(s, nameof(triggerBoundParent));
			SerializeField(s, nameof(triggerBoundChildren));
			SerializeField(s, nameof(modeAfterCP));
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(triggerOnceDone));
			}
			SerializeField(s, nameof(Events));
		}
		public enum Mode {
			[Serialize("Mode_None"            )] None = 0,
			[Serialize("Mode_RetriggerAfterCP")] RetriggerAfterCP = 1,
			[Serialize("Mode_ResetAfterCP"    )] ResetAfterCP = 2,
		}
		public override uint? ClassCRC => 0x0F7E24E6;
	}
}

