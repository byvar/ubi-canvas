using UnityEngine;

namespace UbiArt.ITF {
	public partial class TweenInstructionEvent_Template : CSerializable {
		[Serialize("duration"            )] public float duration;
		[Serialize("name"                )] public StringID name;
		[Serialize("event"               )] public Placeholder _event;
		[Serialize("triggerSelf"         )] public bool triggerSelf;
		[Serialize("triggerChildren"     )] public bool triggerChildren;
		[Serialize("triggerBoundChildren")] public bool triggerBoundChildren;
		[Serialize("triggerGameManager"  )] public bool triggerGameManager;
		[Serialize("triggerBroadcast"    )] public bool triggerBroadcast;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(duration));
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(_event));
			SerializeField(s, nameof(triggerSelf));
			SerializeField(s, nameof(triggerChildren));
			SerializeField(s, nameof(triggerBoundChildren));
			SerializeField(s, nameof(triggerGameManager));
			SerializeField(s, nameof(triggerBroadcast));
		}
		public override uint? ClassCRC => 0x1633B282;
	}
}

