namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionDrown_Template : BTAction_Template {
		public float timeDrown = 2f;
		public float waterPerturbationForce = 20f;
		public float waterPerturbationRadius = 1f;
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

