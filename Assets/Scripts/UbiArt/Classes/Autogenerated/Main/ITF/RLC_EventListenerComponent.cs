using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_EventListenerComponent : ActorComponent {
		[Serialize("TransfertEventToChildren")] public bool TransfertEventToChildren;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(TransfertEventToChildren));
		}
		public override uint? ClassCRC => 0xCFAA85B0;
	}
}

