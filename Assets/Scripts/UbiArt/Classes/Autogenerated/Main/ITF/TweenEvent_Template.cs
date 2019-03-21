using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class TweenEvent_Template : TweenInstruction_Template {
		[Serialize("event"               )] public Generic<Event> _event;
		[Serialize("triggerSelf"         )] public bool triggerSelf;
		[Serialize("triggerChildren"     )] public bool triggerChildren;
		[Serialize("triggerBoundChildren")] public bool triggerBoundChildren;
		[Serialize("triggerGameManager"  )] public bool triggerGameManager;
		[Serialize("triggerBroadcast"    )] public bool triggerBroadcast;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(_event));
			SerializeField(s, nameof(triggerSelf));
			SerializeField(s, nameof(triggerChildren));
			SerializeField(s, nameof(triggerBoundChildren));
			SerializeField(s, nameof(triggerGameManager));
			SerializeField(s, nameof(triggerBroadcast));
		}
		public override uint? ClassCRC => 0xA6179C86;
	}
}

