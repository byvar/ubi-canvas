using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIWaterFloatAction_Template : AIPlayAnimAction_Template {
		[Serialize("floatForceDistMultiplier"  )] public float floatForceDistMultiplier;
		[Serialize("floatForceSpeedMultiplier" )] public float floatForceSpeedMultiplier;
		[Serialize("orientForceDistMultiplier" )] public float orientForceDistMultiplier;
		[Serialize("orientForceSpeedMultiplier")] public float orientForceSpeedMultiplier;
		[Serialize("weightMultiplier"          )] public float weightMultiplier;
		[Serialize("speedMultiplier"           )] public float speedMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(floatForceDistMultiplier));
			SerializeField(s, nameof(floatForceSpeedMultiplier));
			SerializeField(s, nameof(orientForceDistMultiplier));
			SerializeField(s, nameof(orientForceSpeedMultiplier));
			SerializeField(s, nameof(weightMultiplier));
			SerializeField(s, nameof(speedMultiplier));
		}
		public override uint? ClassCRC => 0x40F45740;
	}
}

