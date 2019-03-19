using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BossLuchadoreTriggerComponent_Template : ActorComponent_Template {
		[Serialize("event")] public Generic<Event> _event;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(_event));
		}
		public override uint? ClassCRC => 0x12F75463;
	}
}

