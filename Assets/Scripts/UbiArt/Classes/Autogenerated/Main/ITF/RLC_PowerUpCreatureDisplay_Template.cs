using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_PowerUpCreatureDisplay_Template : RLC_BasicCreatureDisplay_Template {
		[Serialize("powerActiveDuration")] public float powerActiveDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(powerActiveDuration));
		}
		public override uint? ClassCRC => 0x0B04D958;
	}
}

