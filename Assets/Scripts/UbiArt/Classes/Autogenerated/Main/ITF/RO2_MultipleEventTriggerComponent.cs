using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_MultipleEventTriggerComponent : ActorComponent {
		public CListO<RO2_MultipleEventTriggerComponent.EventCondition> eventConditionList;
		public Generic<Event> validationEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			eventConditionList = s.SerializeObject<CListO<RO2_MultipleEventTriggerComponent.EventCondition>>(eventConditionList, name: "eventConditionList");
			validationEvent = s.SerializeObject<Generic<Event>>(validationEvent, name: "validationEvent");
		}
		[Games(GameFlags.RA)]
		public partial class EventCondition : CSerializable {
			public Generic<Event> _event;
			public Enum_operator _operator;
			public float validityDuration;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				_event = s.SerializeObject<Generic<Event>>(_event, name: "_event");
				_operator = s.Serialize<Enum_operator>(_operator, name: "_operator");
				validityDuration = s.Serialize<float>(validityDuration, name: "validityDuration");
			}
			public enum Enum_operator {
				[Serialize("OR" )] OR = 0,
				[Serialize("AND")] AND = 1,
			}
		}
		public override uint? ClassCRC => 0x2ADDCE2C;
	}
}

