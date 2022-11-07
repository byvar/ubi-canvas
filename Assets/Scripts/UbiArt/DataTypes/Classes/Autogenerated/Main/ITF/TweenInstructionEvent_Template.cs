namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class TweenInstructionEvent_Template : TweenInstruction_Template {
		public Generic<Event> _event;
		public int triggerSelf;
		public int triggerChildren;
		public int triggerBoundChildren;
		public int triggerGameManager;
		public int triggerBroadcast;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			_event = s.SerializeObject<Generic<Event>>(_event, name: "event");
			triggerSelf = s.Serialize<int>(triggerSelf, name: "triggerSelf");
			triggerChildren = s.Serialize<int>(triggerChildren, name: "triggerChildren");
			triggerBoundChildren = s.Serialize<int>(triggerBoundChildren, name: "triggerBoundChildren");
			triggerGameManager = s.Serialize<int>(triggerGameManager, name: "triggerGameManager");
			triggerBroadcast = s.Serialize<int>(triggerBroadcast, name: "triggerBroadcast");
		}
		public override uint? ClassCRC => 0x1633B282;
	}
}

