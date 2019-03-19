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
		[Serialize("duration"            )] public float duration;
		[Serialize("name"                )] public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(duration));
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(_event));
				SerializeField(s, nameof(triggerSelf));
				SerializeField(s, nameof(triggerChildren));
				SerializeField(s, nameof(triggerBoundChildren));
				SerializeField(s, nameof(triggerGameManager));
				SerializeField(s, nameof(triggerBroadcast));
			} else {
				SerializeField(s, nameof(_event));
				SerializeField(s, nameof(triggerSelf));
				SerializeField(s, nameof(triggerChildren));
				SerializeField(s, nameof(triggerBoundChildren));
				SerializeField(s, nameof(triggerGameManager));
				SerializeField(s, nameof(triggerBroadcast));
			}
		}
		public override uint? ClassCRC => 0xA6179C86;
	}
}

