using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class SelfDestroyComponent : ActorComponent {
		[Serialize("Delay"    )] public float Delay;
		[Serialize("waitAnim" )] public eWait waitAnim;
		[Serialize("AnimName" )] public StringID AnimName;
		[Serialize("EventData")] public CList<SelfDestroyComponent.EventData> eventData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Delay));
			SerializeField(s, nameof(waitAnim));
			SerializeField(s, nameof(AnimName));
			SerializeField(s, nameof(eventData));
		}
		[Games(GameFlags.RA)]
		public partial class EventData : CSerializable {
			[Serialize("matchValues")] public bool matchValues;
			[Serialize("Event"      )] public Generic<Event> Event;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(matchValues));
				SerializeField(s, nameof(Event));
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

