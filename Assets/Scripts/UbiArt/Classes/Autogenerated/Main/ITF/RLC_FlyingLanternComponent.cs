using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_FlyingLanternComponent : RO2_HangSpotComponent {
		public float returnSpeed;
		public bool triggerOnce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			returnSpeed = s.Serialize<float>(returnSpeed, name: "returnSpeed");
			triggerOnce = s.Serialize<bool>(triggerOnce, name: "triggerOnce");
		}
		public override uint? ClassCRC => 0xB16171A7;
	}
}

