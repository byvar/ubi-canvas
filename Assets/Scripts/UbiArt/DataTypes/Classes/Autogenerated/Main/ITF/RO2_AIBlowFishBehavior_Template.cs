namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_AIBlowFishBehavior_Template : RO2_AIGroundBaseBehavior_Template {
		public Generic<AIAction_Template> idle;
		public Generic<AIAction_Template> detect;
		public Generic<AIAction_Template> inflatedIdle;
		public Generic<AIAction_Template> inflate;
		public Generic<AIAction_Template> deflate;
		public Generic<AIAction_Template> hold;
		public float detectionRange;
		public float detectionCloseRange;
		public float inflateDuration;
		public float inflatedScaleMultiplier;
		public float deflateDuration;
		public float minIdleDuration;
		public float minInflatedDuration;
		public float repulsionForce;
		public float attractionForce;
		public float friction;
		public float memorizedHitTime;
		public float minHoldTime;
		public uint lumsByReward;
		public uint countMaxReward;
		public float timeBetweenRewardInSwipe;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			idle = s.SerializeObject<Generic<AIAction_Template>>(idle, name: "idle");
			detect = s.SerializeObject<Generic<AIAction_Template>>(detect, name: "detect");
			inflatedIdle = s.SerializeObject<Generic<AIAction_Template>>(inflatedIdle, name: "inflatedIdle");
			inflate = s.SerializeObject<Generic<AIAction_Template>>(inflate, name: "inflate");
			deflate = s.SerializeObject<Generic<AIAction_Template>>(deflate, name: "deflate");
			hold = s.SerializeObject<Generic<AIAction_Template>>(hold, name: "hold");
			detectionRange = s.Serialize<float>(detectionRange, name: "detectionRange");
			detectionCloseRange = s.Serialize<float>(detectionCloseRange, name: "detectionCloseRange");
			inflateDuration = s.Serialize<float>(inflateDuration, name: "inflateDuration");
			inflatedScaleMultiplier = s.Serialize<float>(inflatedScaleMultiplier, name: "inflatedScaleMultiplier");
			deflateDuration = s.Serialize<float>(deflateDuration, name: "deflateDuration");
			minIdleDuration = s.Serialize<float>(minIdleDuration, name: "minIdleDuration");
			minInflatedDuration = s.Serialize<float>(minInflatedDuration, name: "minInflatedDuration");
			repulsionForce = s.Serialize<float>(repulsionForce, name: "repulsionForce");
			attractionForce = s.Serialize<float>(attractionForce, name: "attractionForce");
			friction = s.Serialize<float>(friction, name: "friction");
			memorizedHitTime = s.Serialize<float>(memorizedHitTime, name: "memorizedHitTime");
			minHoldTime = s.Serialize<float>(minHoldTime, name: "minHoldTime");
			lumsByReward = s.Serialize<uint>(lumsByReward, name: "lumsByReward");
			countMaxReward = s.Serialize<uint>(countMaxReward, name: "countMaxReward");
			timeBetweenRewardInSwipe = s.Serialize<float>(timeBetweenRewardInSwipe, name: "timeBetweenRewardInSwipe");
		}
		public override uint? ClassCRC => 0x798C5FA2;
	}
}

