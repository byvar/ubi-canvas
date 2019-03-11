using UnityEngine;

namespace UbiArt.ITF {
	public partial class MultiTargetUpdateEvent : MultiTargetEvent {
		[Serialize("SendEventEveryDelai")] public float SendEventEveryDelai;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(SendEventEveryDelai));
		}
		public override uint? ClassCRC => 0x75F18D2E;
	}
}

