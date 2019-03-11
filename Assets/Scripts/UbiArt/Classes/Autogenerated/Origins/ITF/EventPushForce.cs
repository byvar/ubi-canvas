using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventPushForce : Event {
		[Serialize("force")] public Vector2 force;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(force));
		}
		public override uint? ClassCRC => 0x182FB611;
	}
}

