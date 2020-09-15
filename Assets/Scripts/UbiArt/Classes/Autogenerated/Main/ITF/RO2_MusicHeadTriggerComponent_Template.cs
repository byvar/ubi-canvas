using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_MusicHeadTriggerComponent_Template : ActorComponent_Template {
		public float sqrRadius;
		public Generic<Event> _event;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sqrRadius = s.Serialize<float>(sqrRadius, name: "sqrRadius");
			_event = s.SerializeObject<Generic<Event>>(_event, name: "_event");
		}
		public override uint? ClassCRC => 0x892C3F31;
	}
}

