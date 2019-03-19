using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_MultipleEventTriggerComponent : ActorComponent {
		[Serialize("eventConditionList")] public CList<RO2_MultipleEventTriggerComponent.EventCondition> eventConditionList;
		[Serialize("validationEvent"   )] public Generic<Event> validationEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(eventConditionList));
			SerializeField(s, nameof(validationEvent));
		}
		[Games(GameFlags.RA)]
		public partial class EventCondition : CSerializable {
			[Serialize("event"           )] public Generic<Event> _event;
			[Serialize("operator"        )] public Enum_operator _operator;
			[Serialize("validityDuration")] public float validityDuration;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(_event));
				SerializeField(s, nameof(_operator));
				SerializeField(s, nameof(validityDuration));
			}
			public enum Enum_operator {
				[Serialize("OR" )] OR = 0,
				[Serialize("AND")] AND = 1,
			}
		}
		public override uint? ClassCRC => 0x2ADDCE2C;
	}
}

