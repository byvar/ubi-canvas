using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_PlayerControllerComponent_Template : CSerializable {
		[Serialize("clothWindForceMultiplier"        )] public float clothWindForceMultiplier;
		[Serialize("clothWindEnvironmentalDensity"   )] public float clothWindEnvironmentalDensity;
		[Serialize("clothWindMaterialDensity"        )] public float clothWindMaterialDensity;
		[Serialize("poisonInvincibilityDuration"     )] public float poisonInvincibilityDuration;
		[Serialize("maxWindForceForAnim"             )] public float maxWindForceForAnim;
		[Serialize("gotoPositionThreshold"           )] public float gotoPositionThreshold;
		[Serialize("gotoPositionTimeout"             )] public float gotoPositionTimeout;
		[Serialize("blockingMovablesCheckExtraRadius")] public float blockingMovablesCheckExtraRadius;
		[Serialize("flyingClampMargin"               )] public Vec2d flyingClampMargin;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(clothWindForceMultiplier));
			SerializeField(s, nameof(clothWindEnvironmentalDensity));
			SerializeField(s, nameof(clothWindMaterialDensity));
			SerializeField(s, nameof(poisonInvincibilityDuration));
			SerializeField(s, nameof(maxWindForceForAnim));
			SerializeField(s, nameof(gotoPositionThreshold));
			SerializeField(s, nameof(gotoPositionTimeout));
			SerializeField(s, nameof(blockingMovablesCheckExtraRadius));
			SerializeField(s, nameof(flyingClampMargin));
		}
		public override uint? ClassCRC => 0x4FD21A5D;
	}
}

