namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class SelfDestroyComponent : ActorComponent {
		public float Delay;
		public eWait waitAnim;
		public StringID AnimName;
		public CListO<SelfDestroyComponent.EventData> eventData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Delay = s.Serialize<float>(Delay, name: "Delay");
			waitAnim = s.Serialize<eWait>(waitAnim, name: "waitAnim");
			AnimName = s.SerializeObject<StringID>(AnimName, name: "AnimName");
			eventData = s.SerializeObject<CListO<SelfDestroyComponent.EventData>>(eventData, name: "EventData");
		}
		[Games(GameFlags.RA)]
		public partial class EventData : CSerializable {
			public bool matchValues;
			public Generic<Event> Event;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				matchValues = s.Serialize<bool>(matchValues, name: "matchValues");
				Event = s.SerializeObject<Generic<Event>>(Event, name: "Event");
			}
		}
		public enum eWait {
			[Serialize("eWaitNothing"     )] Nothing = 0,
			[Serialize("eWaitAnimStart"   )] AnimStart = 1,
			[Serialize("eWaitAnimEnd"     )] AnimEnd = 2,
			[Serialize("eWaitEvent"       )] Event = 3,
			[Serialize("eWaitPaticulesEnd")] PaticulesEnd = 4,
		}
		public override uint? ClassCRC => 0x873203AE;
	}
}

