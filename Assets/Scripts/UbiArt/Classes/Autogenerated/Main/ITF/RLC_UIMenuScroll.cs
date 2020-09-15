using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_UIMenuScroll : UIMenuBasic {
		public bool verticalVsHorizontal;
		public bool freeScroll;
		public AABB touchZone;
		public float scrollMaxSpeed;
		public float brakePercentage;
		public float brakeMin;
		public float outOfBoundSlowCoef;
		public float outOfBoundForcePercentage;
		public float outOfBoundForceMin;
		public float contactToScrollBlendSpeed;
		public float minItemsDisplayed;
		public uint lineItemCount;
		public Vec2d forceItemSpacing;
		public Vec2d forceLineSpacing;
		public Vec2d padTouchZoneMargin;
		public Vec2d forceStartPos;
		public float centerXIfNotEnoughElements;
		public CList<ObjectPath> repositionTop;
		public CList<ObjectPath> repositionBottom;
		public uint usedGlobalScissor;
		public bool scaleTouchZone;
		public bool textScrollingMode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			verticalVsHorizontal = s.Serialize<bool>(verticalVsHorizontal, name: "verticalVsHorizontal");
			freeScroll = s.Serialize<bool>(freeScroll, name: "freeScroll");
			touchZone = s.SerializeObject<AABB>(touchZone, name: "touchZone");
			scrollMaxSpeed = s.Serialize<float>(scrollMaxSpeed, name: "scrollMaxSpeed");
			brakePercentage = s.Serialize<float>(brakePercentage, name: "brakePercentage");
			brakeMin = s.Serialize<float>(brakeMin, name: "brakeMin");
			outOfBoundSlowCoef = s.Serialize<float>(outOfBoundSlowCoef, name: "outOfBoundSlowCoef");
			outOfBoundForcePercentage = s.Serialize<float>(outOfBoundForcePercentage, name: "outOfBoundForcePercentage");
			outOfBoundForceMin = s.Serialize<float>(outOfBoundForceMin, name: "outOfBoundForceMin");
			contactToScrollBlendSpeed = s.Serialize<float>(contactToScrollBlendSpeed, name: "contactToScrollBlendSpeed");
			minItemsDisplayed = s.Serialize<float>(minItemsDisplayed, name: "minItemsDisplayed");
			lineItemCount = s.Serialize<uint>(lineItemCount, name: "lineItemCount");
			forceItemSpacing = s.SerializeObject<Vec2d>(forceItemSpacing, name: "forceItemSpacing");
			forceLineSpacing = s.SerializeObject<Vec2d>(forceLineSpacing, name: "forceLineSpacing");
			padTouchZoneMargin = s.SerializeObject<Vec2d>(padTouchZoneMargin, name: "padTouchZoneMargin");
			forceStartPos = s.SerializeObject<Vec2d>(forceStartPos, name: "forceStartPos");
			centerXIfNotEnoughElements = s.Serialize<float>(centerXIfNotEnoughElements, name: "centerXIfNotEnoughElements");
			repositionTop = s.SerializeObject<CList<ObjectPath>>(repositionTop, name: "repositionTop");
			repositionBottom = s.SerializeObject<CList<ObjectPath>>(repositionBottom, name: "repositionBottom");
			usedGlobalScissor = s.Serialize<uint>(usedGlobalScissor, name: "usedGlobalScissor");
			scaleTouchZone = s.Serialize<bool>(scaleTouchZone, name: "scaleTouchZone");
			textScrollingMode = s.Serialize<bool>(textScrollingMode, name: "textScrollingMode");
		}
		public override uint? ClassCRC => 0xB8AF6730;
	}
}

