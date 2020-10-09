using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_PowerUpCreatureDisplay_Template : RLC_BasicCreatureDisplay_Template {
		public float powerActiveDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			powerActiveDuration = s.Serialize<float>(powerActiveDuration, name: "powerActiveDuration");
		}
		public override uint? ClassCRC => 0x0B04D958;
	}
}

