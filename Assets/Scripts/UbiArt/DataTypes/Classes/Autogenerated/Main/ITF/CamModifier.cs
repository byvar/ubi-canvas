namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class CamModifier : CSerializable {
		public Vec3d lookAtOffset = new Vec3d(0,0,13);
		public Vec3d lookAtOffsetMax = new Vec3d(0,0,22);
		public int modifierPriority;
		public float lookAtOffsetX { get => lookAtOffset.x; set => lookAtOffset = new Vec3d(value, lookAtOffset.y, lookAtOffset.z); }
		public float lookAtOffsetY { get => lookAtOffset.y; set => lookAtOffset = new Vec3d(lookAtOffset.x, value, lookAtOffset.z); }
		public float lookAtOffsetZ { get => lookAtOffset.z; set => lookAtOffset = new Vec3d(lookAtOffset.x, lookAtOffset.y, value); }
		public float lookAtOffsetMaxX { get => lookAtOffsetMax.x; set => lookAtOffsetMax = new Vec3d(value, lookAtOffsetMax.y, lookAtOffsetMax.z); }
		public float lookAtOffsetMaxY { get => lookAtOffsetMax.y; set => lookAtOffsetMax = new Vec3d(lookAtOffsetMax.x, value, lookAtOffsetMax.z); }
		public float lookAtOffsetMaxZ { get => lookAtOffsetMax.z; set => lookAtOffsetMax = new Vec3d(lookAtOffsetMax.x, lookAtOffsetMax.y, value); }
		public float blendingZoneStart;
		public float blendingZoneStop;
		public Vec2d zoneNeutral;
		public bool useRotationCurve;
		public Angle rotationAngle;
		public Spline rotationCurve;
		public bool UseDynamicRotation;
		public float rotationSpeed = 0.1f;
		public Angle rotationUpDownAngle;
		public float transitionTime = 2f;
		public float moveInertia;
		public float moveInertiaForZoomIn = -1;
		public float moveInertiaForZoomOut = -1;
		public float horizontalVersusVertical;
		public Vec2d offsetHVS;
		public CameraFlip flipView;
		public bool constraintLeftIsActive = true;
		public bool constraintRightIsActive = true;
		public bool constraintTopIsActive = true;
		public bool constraintBottomIsActive = true;
		public bool constraintMatchView;
		public ConstraintExtended constraintExtendedLeft = new ConstraintExtended();
		public ConstraintExtended constraintExtendedRight = new ConstraintExtended();
		public ConstraintExtended constraintExtendedTop = new ConstraintExtended();
		public ConstraintExtended constraintExtendedBottom = new ConstraintExtended();
		public bool useDecentering = true;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RJR || s.Settings.Game == Game.RFR || s.Settings.Game == Game.RO) {
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
			} else if (s.Settings.Game == Game.RL) {
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
			} else if (s.Settings.Game == Game.COL) {
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
			} else if (s.Settings.Game == Game.VH) {
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
					if (s.HasFlags(SerializeFlags.Flags15)) {
						rotationAngle = s.SerializeObject<Angle>(rotationAngle, name: "rotationAngle");
						rotationCurve = s.SerializeObject<Spline>(rotationCurve, name: "rotationCurve");
					} else {
						if (useRotationCurve) {
							rotationCurve = s.SerializeObject<Spline>(rotationCurve, name: "rotationCurve");
						} else {
							rotationAngle = s.SerializeObject<Angle>(rotationAngle, name: "rotationAngle");
						}
					}
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

