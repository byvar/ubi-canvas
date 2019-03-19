using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_FlyingLanternComponent : RO2_HangSpotComponent {
		[Serialize("returnSpeed")] public float returnSpeed;
		[Serialize("triggerOnce")] public bool triggerOnce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(returnSpeed));
			SerializeField(s, nameof(triggerOnce));
		}
		public override uint? ClassCRC => 0xB16171A7;
	}
}

