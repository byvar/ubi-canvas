using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class MultiTargetUpdateEvent : MultiTargetEvent {
		public float SendEventEveryDelai;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SendEventEveryDelai = s.Serialize<float>(SendEventEveryDelai, name: "SendEventEveryDelai");
		}
		public override uint? ClassCRC => 0x75F18D2E;
	}
}

