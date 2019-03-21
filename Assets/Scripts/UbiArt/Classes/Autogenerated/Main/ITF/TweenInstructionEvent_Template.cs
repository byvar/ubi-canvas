using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class TweenInstructionEvent_Template : TweenInstruction_Template {
		[Serialize("event"               )] public Generic<Event> _event;
		[Serialize("triggerSelf"         )] public int triggerSelf;
		[Serialize("triggerChildren"     )] public int triggerChildren;
		[Serialize("triggerBoundChildren")] public int triggerBoundChildren;
		[Serialize("triggerGameManager"  )] public int triggerGameManager;
		[Serialize("triggerBroadcast"    )] public int triggerBroadcast;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
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

