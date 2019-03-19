using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionDrown_Template : BTAction_Template {
		[Serialize("timeDrown"              )] public float timeDrown;
		[Serialize("waterPerturbationForce" )] public float waterPerturbationForce;
		[Serialize("waterPerturbationRadius")] public float waterPerturbationRadius;
		[Serialize("animFallInWater"        )] public StringID animFallInWater;
		[Serialize("animDrown"              )] public StringID animDrown;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(timeDrown));
			SerializeField(s, nameof(waterPerturbationForce));
			SerializeField(s, nameof(waterPerturbationRadius));
			SerializeField(s, nameof(animFallInWater));
			SerializeField(s, nameof(animDrown));
		}
		public override uint? ClassCRC => 0x0453F2AC;
	}
}

