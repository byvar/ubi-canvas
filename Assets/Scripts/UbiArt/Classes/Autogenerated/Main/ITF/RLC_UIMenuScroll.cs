using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_UIMenuScroll : UIMenuBasic {
		[Serialize("verticalVsHorizontal"      )] public bool verticalVsHorizontal;
		[Serialize("freeScroll"                )] public bool freeScroll;
		[Serialize("touchZone"                 )] public AABB touchZone;
		[Serialize("scrollMaxSpeed"            )] public float scrollMaxSpeed;
		[Serialize("brakePercentage"           )] public float brakePercentage;
		[Serialize("brakeMin"                  )] public float brakeMin;
		[Serialize("outOfBoundSlowCoef"        )] public float outOfBoundSlowCoef;
		[Serialize("outOfBoundForcePercentage" )] public float outOfBoundForcePercentage;
		[Serialize("outOfBoundForceMin"        )] public float outOfBoundForceMin;
		[Serialize("contactToScrollBlendSpeed" )] public float contactToScrollBlendSpeed;
		[Serialize("minItemsDisplayed"         )] public float minItemsDisplayed;
		[Serialize("lineItemCount"             )] public uint lineItemCount;
		[Serialize("forceItemSpacing"          )] public Vector2 forceItemSpacing;
		[Serialize("forceLineSpacing"          )] public Vector2 forceLineSpacing;
		[Serialize("padTouchZoneMargin"        )] public Vector2 padTouchZoneMargin;
		[Serialize("forceStartPos"             )] public Vector2 forceStartPos;
		[Serialize("centerXIfNotEnoughElements")] public float centerXIfNotEnoughElements;
		[Serialize("repositionTop"             )] public CList<ObjectPath> repositionTop;
		[Serialize("repositionBottom"          )] public CList<ObjectPath> repositionBottom;
		[Serialize("usedGlobalScissor"         )] public uint usedGlobalScissor;
		[Serialize("scaleTouchZone"            )] public bool scaleTouchZone;
		[Serialize("textScrollingMode"         )] public bool textScrollingMode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(verticalVsHorizontal));
			SerializeField(s, nameof(freeScroll));
			SerializeField(s, nameof(touchZone));
			SerializeField(s, nameof(scrollMaxSpeed));
			SerializeField(s, nameof(brakePercentage));
			SerializeField(s, nameof(brakeMin));
			SerializeField(s, nameof(outOfBoundSlowCoef));
			SerializeField(s, nameof(outOfBoundForcePercentage));
			SerializeField(s, nameof(outOfBoundForceMin));
			SerializeField(s, nameof(contactToScrollBlendSpeed));
			SerializeField(s, nameof(minItemsDisplayed));
			SerializeField(s, nameof(lineItemCount));
			SerializeField(s, nameof(forceItemSpacing));
			SerializeField(s, nameof(forceLineSpacing));
			SerializeField(s, nameof(padTouchZoneMargin));
			SerializeField(s, nameof(forceStartPos));
			SerializeField(s, nameof(centerXIfNotEnoughElements));
			SerializeField(s, nameof(repositionTop));
			SerializeField(s, nameof(repositionBottom));
			SerializeField(s, nameof(usedGlobalScissor));
			SerializeField(s, nameof(scaleTouchZone));
			SerializeField(s, nameof(textScrollingMode));
		}
		public override uint? ClassCRC => 0xB8AF6730;
	}
}

