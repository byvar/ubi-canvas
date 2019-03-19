using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class TweenInstructionEvent_Template : TweenInstruction_Template {
		[Serialize("duration"            )] public float duration;
		[Serialize("name"                )] public StringID name;
		[Serialize("event"               )] public Placeholder _event;
		[Serialize("triggerSelf"         )] public int triggerSelf;
		[Serialize("triggerChildren"     )] public int triggerChildren;
		[Serialize("triggerBoundChildren")] public int triggerBoundChildren;
		[Serialize("triggerGameManager"  )] public int triggerGameManager;
		[Serialize("triggerBroadcast"    )] public int triggerBroadcast;
		[Serialize("Generic<Event>__0"   )] public Generic<Event> Generic_Event__0;
		[Serialize("int__1"              )] public int int__1;
		[Serialize("int__2"              )] public int int__2;
		[Serialize("int__3"              )] public int int__3;
		[Serialize("int__4"              )] public int int__4;
		[Serialize("int__5"              )] public int int__5;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(duration));
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(_event));
				SerializeField(s, nameof(triggerSelf));
				SerializeField(s, nameof(triggerChildren));
				SerializeField(s, nameof(triggerBoundChildren));
				SerializeField(s, nameof(triggerGameManager));
				SerializeField(s, nameof(triggerBroadcast));
			} else {
				SerializeField(s, nameof(Generic_Event__0));
				SerializeField(s, nameof(int__1));
				SerializeField(s, nameof(int__2));
				SerializeField(s, nameof(int__3));
				SerializeField(s, nameof(int__4));
				SerializeField(s, nameof(int__5));
			}
		}
		public override uint? ClassCRC => 0x1633B282;
	}
}

