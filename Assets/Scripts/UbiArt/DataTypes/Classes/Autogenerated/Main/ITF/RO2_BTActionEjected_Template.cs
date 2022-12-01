namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionEjected_Template : BTAction_Template {
		public StringID animEjection;
		public StringID animImpact;
		public float speedBulletMultiplier = 1f;
		public bool useRehitStim = true;
		public bool reorientOnImpact;
		public float immuneToHitDuration;
		public bool acceptRoofCrash = true;
		public float gravityBlendSpeedThresholdRatio = 0.2f;
		public float gravityBlendMaxGravity = 1f;
		public float gravityBlendMinGravity = 0.1f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animEjection = s.SerializeObject<StringID>(animEjection, name: "animEjection");
			animImpact = s.SerializeObject<StringID>(animImpact, name: "animImpact");
			speedBulletMultiplier = s.Serialize<float>(speedBulletMultiplier, name: "speedBulletMultiplier");
			useRehitStim = s.Serialize<bool>(useRehitStim, name: "useRehitStim");
			reorientOnImpact = s.Serialize<bool>(reorientOnImpact, name: "reorientOnImpact");
			immuneToHitDuration = s.Serialize<float>(immuneToHitDuration, name: "immuneToHitDuration");
			acceptRoofCrash = s.Serialize<bool>(acceptRoofCrash, name: "acceptRoofCrash");
			gravityBlendSpeedThresholdRatio = s.Serialize<float>(gravityBlendSpeedThresholdRatio, name: "gravityBlendSpeedThresholdRatio");
			gravityBlendMaxGravity = s.Serialize<float>(gravityBlendMaxGravity, name: "gravityBlendMaxGravity");
			gravityBlendMinGravity = s.Serialize<float>(gravityBlendMinGravity, name: "gravityBlendMinGravity");
		}
		public override uint? ClassCRC => 0xE770638C;
	}
}

