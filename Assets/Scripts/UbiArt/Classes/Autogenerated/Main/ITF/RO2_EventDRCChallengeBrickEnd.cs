using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventDRCChallengeBrickEnd : Event {
		[Serialize("success")] public bool success;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(success));
		}
		public override uint? ClassCRC => 0xB25AE89E;
	}
}

