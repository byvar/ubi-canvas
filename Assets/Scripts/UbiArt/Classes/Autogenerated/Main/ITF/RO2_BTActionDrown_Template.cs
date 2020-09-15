using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionDrown_Template : BTAction_Template {
		public float timeDrown;
		public float waterPerturbationForce;
		public float waterPerturbationRadius;
		public StringID animFallInWater;
		public StringID animDrown;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			timeDrown = s.Serialize<float>(timeDrown, name: "timeDrown");
			waterPerturbationForce = s.Serialize<float>(waterPerturbationForce, name: "waterPerturbationForce");
			waterPerturbationRadius = s.Serialize<float>(waterPerturbationRadius, name: "waterPerturbationRadius");
			animFallInWater = s.SerializeObject<StringID>(animFallInWater, name: "animFallInWater");
			animDrown = s.SerializeObject<StringID>(animDrown, name: "animDrown");
		}
		public override uint? ClassCRC => 0x0453F2AC;
	}
}

