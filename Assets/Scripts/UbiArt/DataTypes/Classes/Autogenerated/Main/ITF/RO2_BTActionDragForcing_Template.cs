using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionDragForcing_Template : BTAction_Template {
		public StringID animDrag;
		public StringID animSpring;
		public StringID animReceiveHitDrag;
		public bool useAnimation;
		public Vec2d offsetDrag;
		public float smoothFactor;
		public bool orientToOrigin;
		public bool useRelativeScreenSpace;
		public StringID fxGrab;
		public StringID fxInputMove;
		public StringID fxRelease;
		public float dragRadius;
		public float releaseDragSmoothFactor;
		public float releaseDragDuration;
		public StringID fxRoot;
		public bool autoReleaseDrag;
		public bool useDRCSnapping;
		public float dragSuccessDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animDrag = s.SerializeObject<StringID>(animDrag, name: "animDrag");
			animSpring = s.SerializeObject<StringID>(animSpring, name: "animSpring");
			animReceiveHitDrag = s.SerializeObject<StringID>(animReceiveHitDrag, name: "animReceiveHitDrag");
			useAnimation = s.Serialize<bool>(useAnimation, name: "useAnimation");
			offsetDrag = s.SerializeObject<Vec2d>(offsetDrag, name: "offsetDrag");
			smoothFactor = s.Serialize<float>(smoothFactor, name: "smoothFactor");
			orientToOrigin = s.Serialize<bool>(orientToOrigin, name: "orientToOrigin");
			useRelativeScreenSpace = s.Serialize<bool>(useRelativeScreenSpace, name: "useRelativeScreenSpace");
			fxGrab = s.SerializeObject<StringID>(fxGrab, name: "fxGrab");
			fxInputMove = s.SerializeObject<StringID>(fxInputMove, name: "fxInputMove");
			fxRelease = s.SerializeObject<StringID>(fxRelease, name: "fxRelease");
			dragRadius = s.Serialize<float>(dragRadius, name: "dragRadius");
			releaseDragSmoothFactor = s.Serialize<float>(releaseDragSmoothFactor, name: "releaseDragSmoothFactor");
			releaseDragDuration = s.Serialize<float>(releaseDragDuration, name: "releaseDragDuration");
			fxRoot = s.SerializeObject<StringID>(fxRoot, name: "fxRoot");
			autoReleaseDrag = s.Serialize<bool>(autoReleaseDrag, name: "autoReleaseDrag");
			useDRCSnapping = s.Serialize<bool>(useDRCSnapping, name: "useDRCSnapping");
			dragSuccessDistance = s.Serialize<float>(dragSuccessDistance, name: "dragSuccessDistance");
		}
		public override uint? ClassCRC => 0x75ACF28B;
	}
}

