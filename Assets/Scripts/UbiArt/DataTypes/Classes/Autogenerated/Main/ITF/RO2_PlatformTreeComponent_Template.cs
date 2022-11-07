namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_PlatformTreeComponent_Template : ActorComponent_Template {
		public bool ignoreEventTrigger;
		public float maxStartDelay;
		public float childMoveSpeed;
		public float childMoveSpeedRandom;
		public bool fastMode;
		public bool useTouch;
		public float childAngleCorrectionDist;
		public float childLinkFadeDist;
		public float childAppearDist;
		public float childDisappearDist;
		public float childOpenDist;
		public float childCloseDist;
		public StringID animOpened;
		public StringID animClosed;
		public StringID animAppear;
		public StringID animDisappear;
		public StringID animHidden;
		public float openingDelay;
		public float closingDelay;
		public RO2_SoftCollision_Template softCollision;
		public bool canWiggle;
		public StringID padRumbleWiggle;
		public StringID animWiggleOpened;
		public StringID animWiggleClosed;
		public bool disableCollisionDuringTransition;
		public bool disableActorOnOpen;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ignoreEventTrigger = s.Serialize<bool>(ignoreEventTrigger, name: "ignoreEventTrigger");
			maxStartDelay = s.Serialize<float>(maxStartDelay, name: "maxStartDelay");
			childMoveSpeed = s.Serialize<float>(childMoveSpeed, name: "childMoveSpeed");
			childMoveSpeedRandom = s.Serialize<float>(childMoveSpeedRandom, name: "childMoveSpeedRandom");
			fastMode = s.Serialize<bool>(fastMode, name: "fastMode");
			useTouch = s.Serialize<bool>(useTouch, name: "useTouch");
			childAngleCorrectionDist = s.Serialize<float>(childAngleCorrectionDist, name: "childAngleCorrectionDist");
			childLinkFadeDist = s.Serialize<float>(childLinkFadeDist, name: "childLinkFadeDist");
			childAppearDist = s.Serialize<float>(childAppearDist, name: "childAppearDist");
			childDisappearDist = s.Serialize<float>(childDisappearDist, name: "childDisappearDist");
			childOpenDist = s.Serialize<float>(childOpenDist, name: "childOpenDist");
			childCloseDist = s.Serialize<float>(childCloseDist, name: "childCloseDist");
			animOpened = s.SerializeObject<StringID>(animOpened, name: "animOpened");
			animClosed = s.SerializeObject<StringID>(animClosed, name: "animClosed");
			animAppear = s.SerializeObject<StringID>(animAppear, name: "animAppear");
			animDisappear = s.SerializeObject<StringID>(animDisappear, name: "animDisappear");
			animHidden = s.SerializeObject<StringID>(animHidden, name: "animHidden");
			openingDelay = s.Serialize<float>(openingDelay, name: "openingDelay");
			closingDelay = s.Serialize<float>(closingDelay, name: "closingDelay");
			softCollision = s.SerializeObject<RO2_SoftCollision_Template>(softCollision, name: "softCollision");
			canWiggle = s.Serialize<bool>(canWiggle, name: "canWiggle");
			padRumbleWiggle = s.SerializeObject<StringID>(padRumbleWiggle, name: "padRumbleWiggle");
			animWiggleOpened = s.SerializeObject<StringID>(animWiggleOpened, name: "animWiggleOpened");
			animWiggleClosed = s.SerializeObject<StringID>(animWiggleClosed, name: "animWiggleClosed");
			disableCollisionDuringTransition = s.Serialize<bool>(disableCollisionDuringTransition, name: "disableCollisionDuringTransition");
			disableActorOnOpen = s.Serialize<bool>(disableActorOnOpen, name: "disableActorOnOpen");
		}
		public override uint? ClassCRC => 0x69661AA4;
	}
}

