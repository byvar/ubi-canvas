using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_AnemoneTreeComponent_Template : ActorComponent_Template {
		[Serialize("fastMode"                   )] public bool fastMode;
		[Serialize("polylineDisableOnTransition")] public bool polylineDisableOnTransition;
		[Serialize("headActor"                  )] public Path headActor;
		[Serialize("headAttachOffset"           )] public float headAttachOffset;
		[Serialize("bulbAttachBone"             )] public StringID bulbAttachBone;
		[Serialize("childAppearDist"            )] public float childAppearDist;
		[Serialize("childDisappearDist"         )] public float childDisappearDist;
		[Serialize("childOpenDist"              )] public float childOpenDist;
		[Serialize("childCloseDist"             )] public float childCloseDist;
		[Serialize("animOpened"                 )] public StringID animOpened;
		[Serialize("animClosed"                 )] public StringID animClosed;
		[Serialize("animAppear"                 )] public StringID animAppear;
		[Serialize("animDisappear"              )] public StringID animDisappear;
		[Serialize("animHidden"                 )] public StringID animHidden;
		[Serialize("openingDelay"               )] public float openingDelay;
		[Serialize("closingDelay"               )] public float closingDelay;
		[Serialize("softCollision"              )] public RO2_SoftCollision_Template softCollision;
		[Serialize("canWiggle"                  )] public bool canWiggle;
		[Serialize("padRumbleWiggle"            )] public StringID padRumbleWiggle;
		[Serialize("animWiggleOpened"           )] public StringID animWiggleOpened;
		[Serialize("animWiggleClosed"           )] public StringID animWiggleClosed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(fastMode));
			SerializeField(s, nameof(polylineDisableOnTransition));
			SerializeField(s, nameof(headActor));
			SerializeField(s, nameof(headAttachOffset));
			SerializeField(s, nameof(bulbAttachBone));
			SerializeField(s, nameof(childAppearDist));
			SerializeField(s, nameof(childDisappearDist));
			SerializeField(s, nameof(childOpenDist));
			SerializeField(s, nameof(childCloseDist));
			SerializeField(s, nameof(animOpened));
			SerializeField(s, nameof(animClosed));
			SerializeField(s, nameof(animAppear));
			SerializeField(s, nameof(animDisappear));
			SerializeField(s, nameof(animHidden));
			SerializeField(s, nameof(openingDelay));
			SerializeField(s, nameof(closingDelay));
			SerializeField(s, nameof(softCollision));
			SerializeField(s, nameof(canWiggle));
			SerializeField(s, nameof(padRumbleWiggle));
			SerializeField(s, nameof(animWiggleOpened));
			SerializeField(s, nameof(animWiggleClosed));
		}
		public override uint? ClassCRC => 0x54A3CD6F;
	}
}

