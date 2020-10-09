using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_DragonTriggerComponent_Template : ActorComponent_Template {
		public Generic<Event> OnEnterEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			OnEnterEvent = s.SerializeObject<Generic<Event>>(OnEnterEvent, name: "OnEnterEvent");
		}
		public override uint? ClassCRC => 0x7E4ADEF0;
	}
}

