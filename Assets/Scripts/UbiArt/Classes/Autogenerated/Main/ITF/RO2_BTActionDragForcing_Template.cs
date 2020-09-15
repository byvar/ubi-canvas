using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionDragForcing_Template : BTAction_Template {
		[Serialize("animDrag"               )] public StringID animDrag;
		[Serialize("animSpring"             )] public StringID animSpring;
		[Serialize("animReceiveHitDrag"     )] public StringID animReceiveHitDrag;
		[Serialize("useAnimation"           )] public bool useAnimation;
		[Serialize("offsetDrag"             )] public Vec2d offsetDrag;
		[Serialize("smoothFactor"           )] public float smoothFactor;
		[Serialize("orientToOrigin"         )] public bool orientToOrigin;
		[Serialize("useRelativeScreenSpace" )] public bool useRelativeScreenSpace;
		[Serialize("fxGrab"                 )] public StringID fxGrab;
		[Serialize("fxInputMove"            )] public StringID fxInputMove;
		[Serialize("fxRelease"              )] public StringID fxRelease;
		[Serialize("dragRadius"             )] public float dragRadius;
		[Serialize("releaseDragSmoothFactor")] public float releaseDragSmoothFactor;
		[Serialize("releaseDragDuration"    )] public float releaseDragDuration;
		[Serialize("fxRoot"                 )] public StringID fxRoot;
		[Serialize("autoReleaseDrag"        )] public bool autoReleaseDrag;
		[Serialize("useDRCSnapping"         )] public bool useDRCSnapping;
		[Serialize("dragSuccessDistance"    )] public float dragSuccessDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animDrag));
			SerializeField(s, nameof(animSpring));
			SerializeField(s, nameof(animReceiveHitDrag));
			SerializeField(s, nameof(useAnimation));
			SerializeField(s, nameof(offsetDrag));
			SerializeField(s, nameof(smoothFactor));
			SerializeField(s, nameof(orientToOrigin));
			SerializeField(s, nameof(useRelativeScreenSpace));
			SerializeField(s, nameof(fxGrab));
			SerializeField(s, nameof(fxInputMove));
			SerializeField(s, nameof(fxRelease));
			SerializeField(s, nameof(dragRadius));
			SerializeField(s, nameof(releaseDragSmoothFactor));
			SerializeField(s, nameof(releaseDragDuration));
			SerializeField(s, nameof(fxRoot));
			SerializeField(s, nameof(autoReleaseDrag));
			SerializeField(s, nameof(useDRCSnapping));
			SerializeField(s, nameof(dragSuccessDistance));
		}
		public override uint? ClassCRC => 0x75ACF28B;
	}
}

