namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionFollowActorSpring_Template : BTAction_Template {
		public StringID animFollow;
		public StringID animSpring;
		public StringID animExplode;
		public float radiusMax = 5f;
		public float durationReturnSpring = 0.5f;
		public float forceMinBeforeExit = 1f;
		public float speedReturnSpring = 10f;
		public bool explode = true;
		public Vec2d offsetFollow;
		public float smoothFactor = 0.1f;
		public float followMaxDist = 10f;
		public float followMaxTime = 4f;
		public float minPulsation = 1f;
		public float maxPulsation = 2f;
		public float minScaleAtStart = 2f;
		public float maxScaleAtStart = 2f;
		public float minScaleAtEnd = 0.5f;
		public float maxScaleAtEnd = 3f;
		public float speedBlend = 1f;
		public float speedMin;
		public float speedMax = 1f;
		public float blendAtSpeedMin;
		public float blendAtSpeedMax = 1f;
		public StringID followStartFX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animFollow = s.SerializeObject<StringID>(animFollow, name: "animFollow");
			animSpring = s.SerializeObject<StringID>(animSpring, name: "animSpring");
			animExplode = s.SerializeObject<StringID>(animExplode, name: "animExplode");
			radiusMax = s.Serialize<float>(radiusMax, name: "radiusMax");
			durationReturnSpring = s.Serialize<float>(durationReturnSpring, name: "durationReturnSpring");
			forceMinBeforeExit = s.Serialize<float>(forceMinBeforeExit, name: "forceMinBeforeExit");
			speedReturnSpring = s.Serialize<float>(speedReturnSpring, name: "speedReturnSpring");
			explode = s.Serialize<bool>(explode, name: "explode");
			offsetFollow = s.SerializeObject<Vec2d>(offsetFollow, name: "offsetFollow");
			smoothFactor = s.Serialize<float>(smoothFactor, name: "smoothFactor");
			followMaxDist = s.Serialize<float>(followMaxDist, name: "followMaxDist");
			followMaxTime = s.Serialize<float>(followMaxTime, name: "followMaxTime");
			minPulsation = s.Serialize<float>(minPulsation, name: "minPulsation");
			maxPulsation = s.Serialize<float>(maxPulsation, name: "maxPulsation");
			minScaleAtStart = s.Serialize<float>(minScaleAtStart, name: "minScaleAtStart");
			maxScaleAtStart = s.Serialize<float>(maxScaleAtStart, name: "maxScaleAtStart");
			minScaleAtEnd = s.Serialize<float>(minScaleAtEnd, name: "minScaleAtEnd");
			maxScaleAtEnd = s.Serialize<float>(maxScaleAtEnd, name: "maxScaleAtEnd");
			speedBlend = s.Serialize<float>(speedBlend, name: "speedBlend");
			speedMin = s.Serialize<float>(speedMin, name: "speedMin");
			speedMax = s.Serialize<float>(speedMax, name: "speedMax");
			blendAtSpeedMin = s.Serialize<float>(blendAtSpeedMin, name: "blendAtSpeedMin");
			blendAtSpeedMax = s.Serialize<float>(blendAtSpeedMax, name: "blendAtSpeedMax");
			followStartFX = s.SerializeObject<StringID>(followStartFX, name: "followStartFX");
		}
		public override uint? ClassCRC => 0x38C2A06A;
	}
}

