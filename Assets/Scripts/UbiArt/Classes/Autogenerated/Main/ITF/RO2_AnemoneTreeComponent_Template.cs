using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_AnemoneTreeComponent_Template : ActorComponent_Template {
		public bool fastMode;
		public bool polylineDisableOnTransition;
		public Path headActor;
		public float headAttachOffset;
		public StringID bulbAttachBone;
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
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			fastMode = s.Serialize<bool>(fastMode, name: "fastMode");
			polylineDisableOnTransition = s.Serialize<bool>(polylineDisableOnTransition, name: "polylineDisableOnTransition");
			headActor = s.SerializeObject<Path>(headActor, name: "headActor");
			headAttachOffset = s.Serialize<float>(headAttachOffset, name: "headAttachOffset");
			bulbAttachBone = s.SerializeObject<StringID>(bulbAttachBone, name: "bulbAttachBone");
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
		}
		public override uint? ClassCRC => 0x54A3CD6F;
	}
}

