namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionDrag_Template : BTAction_Template {
		public StringID anim;
		public StringID animDrop;
		public StringID animFreeFall;
		public StringID animImpact;
		public StringID animReceiveHitDrag;
		public float bulletTouchDirNormThreshold = 500f;
		public float DRCSpeedSmoothFactor = 5f;
		public Vec2d offsetDrag;
		public float speedBulletMultiplier = 1f;
		public float smoothFactor = 0.1f;
		public float smoothFactorOnPoly = 0.4f;
		public float smoothFactorOnDoublePoly = 0.4f;
		public bool useRehitStim = true;
		public float speedMaxBullet = 30f;
		public bool acceptRoofCrash = true;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			anim = s.SerializeObject<StringID>(anim, name: "anim");
			animDrop = s.SerializeObject<StringID>(animDrop, name: "animDrop");
			animFreeFall = s.SerializeObject<StringID>(animFreeFall, name: "animFreeFall");
			animImpact = s.SerializeObject<StringID>(animImpact, name: "animImpact");
			animReceiveHitDrag = s.SerializeObject<StringID>(animReceiveHitDrag, name: "animReceiveHitDrag");
			bulletTouchDirNormThreshold = s.Serialize<float>(bulletTouchDirNormThreshold, name: "bulletTouchDirNormThreshold");
			DRCSpeedSmoothFactor = s.Serialize<float>(DRCSpeedSmoothFactor, name: "DRCSpeedSmoothFactor");
			offsetDrag = s.SerializeObject<Vec2d>(offsetDrag, name: "offsetDrag");
			speedBulletMultiplier = s.Serialize<float>(speedBulletMultiplier, name: "speedBulletMultiplier");
			smoothFactor = s.Serialize<float>(smoothFactor, name: "smoothFactor");
			smoothFactorOnPoly = s.Serialize<float>(smoothFactorOnPoly, name: "smoothFactorOnPoly");
			smoothFactorOnDoublePoly = s.Serialize<float>(smoothFactorOnDoublePoly, name: "smoothFactorOnDoublePoly");
			useRehitStim = s.Serialize<bool>(useRehitStim, name: "useRehitStim");
			speedMaxBullet = s.Serialize<float>(speedMaxBullet, name: "speedMaxBullet");
			acceptRoofCrash = s.Serialize<bool>(acceptRoofCrash, name: "acceptRoofCrash");
		}
		public override uint? ClassCRC => 0xB1FA9D86;
	}
}

