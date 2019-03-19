using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_TargetingCreatureDisplay_Template : RLC_PowerUpCreatureDisplay_Template {
		[Serialize("targetRange")] public float targetRange;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(targetRange));
		}
		public override uint? ClassCRC => 0x0E07F12C;
	}
}

