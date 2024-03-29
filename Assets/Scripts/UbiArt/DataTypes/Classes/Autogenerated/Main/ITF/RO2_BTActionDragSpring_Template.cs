namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionDragSpring_Template : BTAction_Template {
		public StringID animDrag;
		public StringID animSpring;
		public StringID animReceiveHitDrag;
		public bool useAnimation = true;
		public float radiusMax = 5f;
		public float durationReturnSpring = 0.5f;
		public float forceMinBeforeExit = 1f;
		public float speedReturnSpring = 10f;
		public Vec2d offsetDrag;
		public float smoothFactor = 0.4f;
		public float smoothFactorOnPoly = 0.05f;
		public float smoothFactorOnDoublePoly = 0.01f;
		public bool orientToOrigin = true;
		public bool constraintFromRootPos;
		public bool useRelativeScreenSpace;
		public float borderDurationSpring = 0.2f;
		public float borderBounciness = 10f;
		public StringID fxGrab;
		public StringID fxInputMove;
		public StringID fxRelease;
		public bool autoReleaseDrag;
		public float autoReleaseDragRadius = 5f;
		public bool disableSpring;
		public float releaseDragSmoothFactor = 0.1f;
		public float releaseDragDuration;
		public StringID fxRoot;
		public bool suspendAction;
		public bool SuspendSwing;
		public bool useDRCSnapping;
		public float dragSuccessDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animDrag = s.SerializeObject<StringID>(animDrag, name: "animDrag");
			animSpring = s.SerializeObject<StringID>(animSpring, name: "animSpring");
			animReceiveHitDrag = s.SerializeObject<StringID>(animReceiveHitDrag, name: "animReceiveHitDrag");
			useAnimation = s.Serialize<bool>(useAnimation, name: "useAnimation");
			radiusMax = s.Serialize<float>(radiusMax, name: "radiusMax");
			durationReturnSpring = s.Serialize<float>(durationReturnSpring, name: "durationReturnSpring");
			forceMinBeforeExit = s.Serialize<float>(forceMinBeforeExit, name: "forceMinBeforeExit");
			speedReturnSpring = s.Serialize<float>(speedReturnSpring, name: "speedReturnSpring");
			offsetDrag = s.SerializeObject<Vec2d>(offsetDrag, name: "offsetDrag");
			smoothFactor = s.Serialize<float>(smoothFactor, name: "smoothFactor");
			smoothFactorOnPoly = s.Serialize<float>(smoothFactorOnPoly, name: "smoothFactorOnPoly");
			smoothFactorOnDoublePoly = s.Serialize<float>(smoothFactorOnDoublePoly, name: "smoothFactorOnDoublePoly");
			orientToOrigin = s.Serialize<bool>(orientToOrigin, name: "orientToOrigin");
			constraintFromRootPos = s.Serialize<bool>(constraintFromRootPos, name: "constraintFromRootPos");
			useRelativeScreenSpace = s.Serialize<bool>(useRelativeScreenSpace, name: "useRelativeScreenSpace");
			borderDurationSpring = s.Serialize<float>(borderDurationSpring, name: "borderDurationSpring");
			borderBounciness = s.Serialize<float>(borderBounciness, name: "borderBounciness");
			fxGrab = s.SerializeObject<StringID>(fxGrab, name: "fxGrab");
			fxInputMove = s.SerializeObject<StringID>(fxInputMove, name: "fxInputMove");
			fxRelease = s.SerializeObject<StringID>(fxRelease, name: "fxRelease");
			autoReleaseDrag = s.Serialize<bool>(autoReleaseDrag, name: "autoReleaseDrag");
			autoReleaseDragRadius = s.Serialize<float>(autoReleaseDragRadius, name: "autoReleaseDragRadius");
			disableSpring = s.Serialize<bool>(disableSpring, name: "disableSpring");
			releaseDragSmoothFactor = s.Serialize<float>(releaseDragSmoothFactor, name: "releaseDragSmoothFactor");
			releaseDragDuration = s.Serialize<float>(releaseDragDuration, name: "releaseDragDuration");
			fxRoot = s.SerializeObject<StringID>(fxRoot, name: "fxRoot");
			suspendAction = s.Serialize<bool>(suspendAction, name: "suspendAction");
			SuspendSwing = s.Serialize<bool>(SuspendSwing, name: "SuspendSwing");
			useDRCSnapping = s.Serialize<bool>(useDRCSnapping, name: "useDRCSnapping");
			dragSuccessDistance = s.Serialize<float>(dragSuccessDistance, name: "dragSuccessDistance");
		}
		public override uint? ClassCRC => 0x0128552A;
	}
}

