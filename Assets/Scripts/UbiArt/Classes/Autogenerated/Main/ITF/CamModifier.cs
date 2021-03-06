using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class CamModifier : CSerializable {
		public Vec3d lookAtOffset;
		public Vec3d lookAtOffsetMax;
		public int modifierPriority;
		public float lookAtOffsetX;
		public float lookAtOffsetY;
		public float lookAtOffsetZ;
		public float lookAtOffsetMaxX;
		public float lookAtOffsetMaxY;
		public float lookAtOffsetMaxZ;
		public float blendingZoneStart;
		public float blendingZoneStop;
		public Vec2d zoneNeutral;
		public bool useRotationCurve;
		public Angle rotationAngle;
		public bool UseDynamicRotation;
		public float rotationSpeed;
		public Angle rotationUpDownAngle;
		public float transitionTime;
		public float moveInertia;
		public float moveInertiaForZoomIn;
		public float moveInertiaForZoomOut;
		public float horizontalVersusVertical;
		public Vec2d offsetHVS;
		public CameraFlip flipView;
		public bool constraintLeftIsActive;
		public bool constraintRightIsActive;
		public bool constraintTopIsActive;
		public bool constraintBottomIsActive;
		public bool constraintMatchView;
		public ConstraintExtended constraintExtendedLeft;
		public ConstraintExtended constraintExtendedRight;
		public ConstraintExtended constraintExtendedTop;
		public ConstraintExtended constraintExtendedBottom;
		public bool useDecentering;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Default)) {
					modifierPriority = s.Serialize<int>(modifierPriority, name: "modifierPriority");
					constraintLeftIsActive = s.Serialize<bool>(constraintLeftIsActive, name: "constraintLeftIsActive");
					constraintRightIsActive = s.Serialize<bool>(constraintRightIsActive, name: "constraintRightIsActive");
					constraintTopIsActive = s.Serialize<bool>(constraintTopIsActive, name: "constraintTopIsActive");
					constraintBottomIsActive = s.Serialize<bool>(constraintBottomIsActive, name: "constraintBottomIsActive");
					constraintMatchView = s.Serialize<bool>(constraintMatchView, name: "constraintMatchView");
					constraintExtendedLeft = s.SerializeObject<ConstraintExtended>(constraintExtendedLeft, name: "constraintExtendedLeft");
					constraintExtendedRight = s.SerializeObject<ConstraintExtended>(constraintExtendedRight, name: "constraintExtendedRight");
					constraintExtendedTop = s.SerializeObject<ConstraintExtended>(constraintExtendedTop, name: "constraintExtendedTop");
					constraintExtendedBottom = s.SerializeObject<ConstraintExtended>(constraintExtendedBottom, name: "constraintExtendedBottom");
					blendingZoneStart = s.Serialize<float>(blendingZoneStart, name: "blendingZoneStart");
					blendingZoneStop = s.Serialize<float>(blendingZoneStop, name: "blendingZoneStop");
					zoneNeutral = s.SerializeObject<Vec2d>(zoneNeutral, name: "zoneNeutral");
					useDecentering = s.Serialize<bool>(useDecentering, name: "useDecentering");
				}
			} else if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					modifierPriority = s.Serialize<int>(modifierPriority, name: "modifierPriority");
					lookAtOffset = s.SerializeObject<Vec3d>(lookAtOffset, name: "lookAtOffset");
					lookAtOffsetMax = s.SerializeObject<Vec3d>(lookAtOffsetMax, name: "lookAtOffsetMax");
					blendingZoneStart = s.Serialize<float>(blendingZoneStart, name: "blendingZoneStart");
					blendingZoneStop = s.Serialize<float>(blendingZoneStop, name: "blendingZoneStop");
					zoneNeutral = s.SerializeObject<Vec2d>(zoneNeutral, name: "zoneNeutral");
					useDecentering = s.Serialize<bool>(useDecentering, name: "useDecentering", options: CSerializerObject.Options.ForceAsByte);
					rotationAngle = s.SerializeObject<Angle>(rotationAngle, name: "rotationAngle");
					rotationSpeed = s.Serialize<float>(rotationSpeed, name: "rotationSpeed");
					flipView = s.Serialize<CameraFlip>(flipView, name: "flipView");
					constraintLeftIsActive = s.Serialize<bool>(constraintLeftIsActive, name: "constraintLeftIsActive", options: CSerializerObject.Options.ForceAsByte);
					constraintRightIsActive = s.Serialize<bool>(constraintRightIsActive, name: "constraintRightIsActive", options: CSerializerObject.Options.ForceAsByte);
					constraintTopIsActive = s.Serialize<bool>(constraintTopIsActive, name: "constraintTopIsActive", options: CSerializerObject.Options.ForceAsByte);
					constraintBottomIsActive = s.Serialize<bool>(constraintBottomIsActive, name: "constraintBottomIsActive", options: CSerializerObject.Options.ForceAsByte);
					constraintMatchView = s.Serialize<bool>(constraintMatchView, name: "constraintMatchView", options: CSerializerObject.Options.ForceAsByte);
					constraintExtendedLeft = s.SerializeObject<ConstraintExtended>(constraintExtendedLeft, name: "constraintExtendedLeft");
					constraintExtendedRight = s.SerializeObject<ConstraintExtended>(constraintExtendedRight, name: "constraintExtendedRight");
					constraintExtendedTop = s.SerializeObject<ConstraintExtended>(constraintExtendedTop, name: "constraintExtendedTop");
					constraintExtendedBottom = s.SerializeObject<ConstraintExtended>(constraintExtendedBottom, name: "constraintExtendedBottom");
				}
			} else if (Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					modifierPriority = s.Serialize<int>(modifierPriority, name: "modifierPriority");
					lookAtOffset = s.SerializeObject<Vec3d>(lookAtOffset, name: "lookAtOffset");
					lookAtOffsetMax = s.SerializeObject<Vec3d>(lookAtOffsetMax, name: "lookAtOffsetMax");
					blendingZoneStart = s.Serialize<float>(blendingZoneStart, name: "blendingZoneStart");
					blendingZoneStop = s.Serialize<float>(blendingZoneStop, name: "blendingZoneStop");
					zoneNeutral = s.SerializeObject<Vec2d>(zoneNeutral, name: "zoneNeutral");
					useDecentering = s.Serialize<bool>(useDecentering, name: "useDecentering", options: CSerializerObject.Options.BoolAsByte);
					rotationAngle = s.SerializeObject<Angle>(rotationAngle, name: "rotationAngle");
					rotationSpeed = s.Serialize<float>(rotationSpeed, name: "rotationSpeed");
					flipView = s.Serialize<CameraFlip>(flipView, name: "flipView");
					constraintLeftIsActive = s.Serialize<bool>(constraintLeftIsActive, name: "constraintLeftIsActive", options: CSerializerObject.Options.BoolAsByte);
					constraintRightIsActive = s.Serialize<bool>(constraintRightIsActive, name: "constraintRightIsActive", options: CSerializerObject.Options.BoolAsByte);
					constraintTopIsActive = s.Serialize<bool>(constraintTopIsActive, name: "constraintTopIsActive", options: CSerializerObject.Options.BoolAsByte);
					constraintBottomIsActive = s.Serialize<bool>(constraintBottomIsActive, name: "constraintBottomIsActive", options: CSerializerObject.Options.BoolAsByte);
					constraintMatchView = s.Serialize<bool>(constraintMatchView, name: "constraintMatchView", options: CSerializerObject.Options.BoolAsByte);
					constraintExtendedLeft = s.SerializeObject<ConstraintExtended>(constraintExtendedLeft, name: "constraintExtendedLeft");
					constraintExtendedRight = s.SerializeObject<ConstraintExtended>(constraintExtendedRight, name: "constraintExtendedRight");
					constraintExtendedTop = s.SerializeObject<ConstraintExtended>(constraintExtendedTop, name: "constraintExtendedTop");
					constraintExtendedBottom = s.SerializeObject<ConstraintExtended>(constraintExtendedBottom, name: "constraintExtendedBottom");
				}
			} else if (Settings.s.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Default)) {
					modifierPriority = s.Serialize<int>(modifierPriority, name: "modifierPriority");
					lookAtOffset = s.SerializeObject<Vec3d>(lookAtOffset, name: "lookAtOffset");
					lookAtOffsetMax = s.SerializeObject<Vec3d>(lookAtOffsetMax, name: "lookAtOffsetMax");
					blendingZoneStart = s.Serialize<float>(blendingZoneStart, name: "blendingZoneStart");
					blendingZoneStop = s.Serialize<float>(blendingZoneStop, name: "blendingZoneStop");
					zoneNeutral = s.SerializeObject<Vec2d>(zoneNeutral, name: "zoneNeutral");
					useDecentering = s.Serialize<bool>(useDecentering, name: "useDecentering");
					rotationAngle = s.SerializeObject<Angle>(rotationAngle, name: "rotationAngle");
					rotationSpeed = s.Serialize<float>(rotationSpeed, name: "rotationSpeed");
					moveInertia = s.Serialize<float>(moveInertia, name: "moveInertia");
					moveInertiaForZoomIn = s.Serialize<float>(moveInertiaForZoomIn, name: "moveInertiaForZoomIn");
					moveInertiaForZoomOut = s.Serialize<float>(moveInertiaForZoomOut, name: "moveInertiaForZoomOut");
					horizontalVersusVertical = s.Serialize<float>(horizontalVersusVertical, name: "horizontalVersusVertical");
					offsetHVS = s.SerializeObject<Vec2d>(offsetHVS, name: "offsetHVS");
					flipView = s.Serialize<CameraFlip>(flipView, name: "flipView");
					constraintLeftIsActive = s.Serialize<bool>(constraintLeftIsActive, name: "constraintLeftIsActive");
					constraintRightIsActive = s.Serialize<bool>(constraintRightIsActive, name: "constraintRightIsActive");
					constraintTopIsActive = s.Serialize<bool>(constraintTopIsActive, name: "constraintTopIsActive");
					constraintBottomIsActive = s.Serialize<bool>(constraintBottomIsActive, name: "constraintBottomIsActive");
					constraintMatchView = s.Serialize<bool>(constraintMatchView, name: "constraintMatchView");
					constraintExtendedLeft = s.SerializeObject<ConstraintExtended>(constraintExtendedLeft, name: "constraintExtendedLeft");
					constraintExtendedRight = s.SerializeObject<ConstraintExtended>(constraintExtendedRight, name: "constraintExtendedRight");
					constraintExtendedTop = s.SerializeObject<ConstraintExtended>(constraintExtendedTop, name: "constraintExtendedTop");
					constraintExtendedBottom = s.SerializeObject<ConstraintExtended>(constraintExtendedBottom, name: "constraintExtendedBottom");
				}
			} else {
				if (s.HasFlags(SerializeFlags.Flags8)) {
					lookAtOffset = s.SerializeObject<Vec3d>(lookAtOffset, name: "lookAtOffset");
					lookAtOffsetMax = s.SerializeObject<Vec3d>(lookAtOffsetMax, name: "lookAtOffsetMax");
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					modifierPriority = s.Serialize<int>(modifierPriority, name: "modifierPriority");
					lookAtOffsetX = s.Serialize<float>(lookAtOffsetX, name: "lookAtOffsetX");
					lookAtOffsetY = s.Serialize<float>(lookAtOffsetY, name: "lookAtOffsetY");
					lookAtOffsetZ = s.Serialize<float>(lookAtOffsetZ, name: "lookAtOffsetZ");
					lookAtOffsetMaxX = s.Serialize<float>(lookAtOffsetMaxX, name: "lookAtOffsetMaxX");
					lookAtOffsetMaxY = s.Serialize<float>(lookAtOffsetMaxY, name: "lookAtOffsetMaxY");
					lookAtOffsetMaxZ = s.Serialize<float>(lookAtOffsetMaxZ, name: "lookAtOffsetMaxZ");
					blendingZoneStart = s.Serialize<float>(blendingZoneStart, name: "blendingZoneStart");
					blendingZoneStop = s.Serialize<float>(blendingZoneStop, name: "blendingZoneStop");
					zoneNeutral = s.SerializeObject<Vec2d>(zoneNeutral, name: "zoneNeutral");
					useRotationCurve = s.Serialize<bool>(useRotationCurve, name: "useRotationCurve");
					rotationAngle = s.SerializeObject<Angle>(rotationAngle, name: "rotationAngle");
					rotationAngle = s.SerializeObject<Angle>(rotationAngle, name: "rotationAngle");
					UseDynamicRotation = s.Serialize<bool>(UseDynamicRotation, name: "UseDynamicRotation");
					rotationSpeed = s.Serialize<float>(rotationSpeed, name: "rotationSpeed");
					rotationUpDownAngle = s.SerializeObject<Angle>(rotationUpDownAngle, name: "rotationUpDownAngle");
					transitionTime = s.Serialize<float>(transitionTime, name: "transitionTime");
					moveInertia = s.Serialize<float>(moveInertia, name: "moveInertia");
					moveInertiaForZoomIn = s.Serialize<float>(moveInertiaForZoomIn, name: "moveInertiaForZoomIn");
					moveInertiaForZoomOut = s.Serialize<float>(moveInertiaForZoomOut, name: "moveInertiaForZoomOut");
					horizontalVersusVertical = s.Serialize<float>(horizontalVersusVertical, name: "horizontalVersusVertical");
					offsetHVS = s.SerializeObject<Vec2d>(offsetHVS, name: "offsetHVS");
					flipView = s.Serialize<CameraFlip>(flipView, name: "flipView");
					constraintLeftIsActive = s.Serialize<bool>(constraintLeftIsActive, name: "constraintLeftIsActive");
					constraintRightIsActive = s.Serialize<bool>(constraintRightIsActive, name: "constraintRightIsActive");
					constraintTopIsActive = s.Serialize<bool>(constraintTopIsActive, name: "constraintTopIsActive");
					constraintBottomIsActive = s.Serialize<bool>(constraintBottomIsActive, name: "constraintBottomIsActive");
					constraintMatchView = s.Serialize<bool>(constraintMatchView, name: "constraintMatchView");
					constraintExtendedLeft = s.SerializeObject<ConstraintExtended>(constraintExtendedLeft, name: "constraintExtendedLeft");
					constraintExtendedRight = s.SerializeObject<ConstraintExtended>(constraintExtendedRight, name: "constraintExtendedRight");
					constraintExtendedTop = s.SerializeObject<ConstraintExtended>(constraintExtendedTop, name: "constraintExtendedTop");
					constraintExtendedBottom = s.SerializeObject<ConstraintExtended>(constraintExtendedBottom, name: "constraintExtendedBottom");
				}
			}
		}
		public enum CameraFlip {
			[Serialize("CameraFlip_None")] None = 0,
			[Serialize("CameraFlip_X"   )] X = 1,
			[Serialize("CameraFlip_Y"   )] Y = 2,
			[Serialize("CameraFlip_Both")] Both = 3,
		}
	}
}

