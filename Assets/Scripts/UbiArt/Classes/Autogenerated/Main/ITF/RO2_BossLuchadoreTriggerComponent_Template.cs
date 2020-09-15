using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BossLuchadoreTriggerComponent_Template : ActorComponent_Template {
		public Generic<Event> _event;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			_event = s.SerializeObject<Generic<Event>>(_event, name: "_event");
		}
		public override uint? ClassCRC => 0x12F75463;
	}
}

