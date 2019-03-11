using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionEjected_Template : BTAction_Template {
		[Serialize("animEjection"                   )] public StringID animEjection;
		[Serialize("animImpact"                     )] public StringID animImpact;
		[Serialize("speedBulletMultiplier"          )] public float speedBulletMultiplier;
		[Serialize("useRehitStim"                   )] public bool useRehitStim;
		[Serialize("reorientOnImpact"               )] public bool reorientOnImpact;
		[Serialize("immuneToHitDuration"            )] public float immuneToHitDuration;
		[Serialize("acceptRoofCrash"                )] public bool acceptRoofCrash;
		[Serialize("gravityBlendSpeedThresholdRatio")] public float gravityBlendSpeedThresholdRatio;
		[Serialize("gravityBlendMaxGravity"         )] public float gravityBlendMaxGravity;
		[Serialize("gravityBlendMinGravity"         )] public float gravityBlendMinGravity;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animEjection));
			SerializeField(s, nameof(animImpact));
			SerializeField(s, nameof(speedBulletMultiplier));
			SerializeField(s, nameof(useRehitStim));
			SerializeField(s, nameof(reorientOnImpact));
			SerializeField(s, nameof(immuneToHitDuration));
			SerializeField(s, nameof(acceptRoofCrash));
			SerializeField(s, nameof(gravityBlendSpeedThresholdRatio));
			SerializeField(s, nameof(gravityBlendMaxGravity));
			SerializeField(s, nameof(gravityBlendMinGravity));
		}
		public override uint? ClassCRC => 0xE770638C;
	}
}

