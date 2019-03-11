using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_DragonTriggerComponent_Template : ActorComponent_Template {
		[Serialize("OnEnterEvent")] public Generic<Event> OnEnterEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(OnEnterEvent));
		}
		public override uint? ClassCRC => 0x7E4ADEF0;
	}
}

