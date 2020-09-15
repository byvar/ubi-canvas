using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionDragSpring_Template : BTAction_Template {
		[Serialize("animDrag"                )] public StringID animDrag;
		[Serialize("animSpring"              )] public StringID animSpring;
		[Serialize("animReceiveHitDrag"      )] public StringID animReceiveHitDrag;
		[Serialize("useAnimation"            )] public bool useAnimation;
		[Serialize("radiusMax"               )] public float radiusMax;
		[Serialize("durationReturnSpring"    )] public float durationReturnSpring;
		[Serialize("forceMinBeforeExit"      )] public float forceMinBeforeExit;
		[Serialize("speedReturnSpring"       )] public float speedReturnSpring;
		[Serialize("offsetDrag"              )] public Vec2d offsetDrag;
		[Serialize("smoothFactor"            )] public float smoothFactor;
		[Serialize("smoothFactorOnPoly"      )] public float smoothFactorOnPoly;
		[Serialize("smoothFactorOnDoublePoly")] public float smoothFactorOnDoublePoly;
		[Serialize("orientToOrigin"          )] public bool orientToOrigin;
		[Serialize("constraintFromRootPos"   )] public bool constraintFromRootPos;
		[Serialize("useRelativeScreenSpace"  )] public bool useRelativeScreenSpace;
		[Serialize("borderDurationSpring"    )] public float borderDurationSpring;
		[Serialize("borderBounciness"        )] public float borderBounciness;
		[Serialize("fxGrab"                  )] public StringID fxGrab;
		[Serialize("fxInputMove"             )] public StringID fxInputMove;
		[Serialize("fxRelease"               )] public StringID fxRelease;
		[Serialize("autoReleaseDrag"         )] public bool autoReleaseDrag;
		[Serialize("autoReleaseDragRadius"   )] public float autoReleaseDragRadius;
		[Serialize("disableSpring"           )] public bool disableSpring;
		[Serialize("releaseDragSmoothFactor" )] public float releaseDragSmoothFactor;
		[Serialize("releaseDragDuration"     )] public float releaseDragDuration;
		[Serialize("fxRoot"                  )] public StringID fxRoot;
		[Serialize("suspendAction"           )] public bool suspendAction;
		[Serialize("SuspendSwing"            )] public bool SuspendSwing;
		[Serialize("useDRCSnapping"          )] public bool useDRCSnapping;
		[Serialize("dragSuccessDistance"     )] public float dragSuccessDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animDrag));
			SerializeField(s, nameof(animSpring));
			SerializeField(s, nameof(animReceiveHitDrag));
			SerializeField(s, nameof(useAnimation));
			SerializeField(s, nameof(radiusMax));
			SerializeField(s, nameof(durationReturnSpring));
			SerializeField(s, nameof(forceMinBeforeExit));
			SerializeField(s, nameof(speedReturnSpring));
			SerializeField(s, nameof(offsetDrag));
			SerializeField(s, nameof(smoothFactor));
			SerializeField(s, nameof(smoothFactorOnPoly));
			SerializeField(s, nameof(smoothFactorOnDoublePoly));
			SerializeField(s, nameof(orientToOrigin));
			SerializeField(s, nameof(constraintFromRootPos));
			SerializeField(s, nameof(useRelativeScreenSpace));
			SerializeField(s, nameof(borderDurationSpring));
			SerializeField(s, nameof(borderBounciness));
			SerializeField(s, nameof(fxGrab));
			SerializeField(s, nameof(fxInputMove));
			SerializeField(s, nameof(fxRelease));
			SerializeField(s, nameof(autoReleaseDrag));
			SerializeField(s, nameof(autoReleaseDragRadius));
			SerializeField(s, nameof(disableSpring));
			SerializeField(s, nameof(releaseDragSmoothFactor));
			SerializeField(s, nameof(releaseDragDuration));
			SerializeField(s, nameof(fxRoot));
			SerializeField(s, nameof(suspendAction));
			SerializeField(s, nameof(SuspendSwing));
			SerializeField(s, nameof(useDRCSnapping));
			SerializeField(s, nameof(dragSuccessDistance));
		}
		public override uint? ClassCRC => 0x0128552A;
	}
}

