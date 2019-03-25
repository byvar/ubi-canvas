using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class CamModifier : CSerializable {
		[Serialize("lookAtOffset"            )] public Vector3 lookAtOffset;
		[Serialize("lookAtOffsetMax"         )] public Vector3 lookAtOffsetMax;
		[Serialize("modifierPriority"        )] public int modifierPriority;
		[Serialize("lookAtOffsetX"           )] public float lookAtOffsetX;
		[Serialize("lookAtOffsetY"           )] public float lookAtOffsetY;
		[Serialize("lookAtOffsetZ"           )] public float lookAtOffsetZ;
		[Serialize("lookAtOffsetMaxX"        )] public float lookAtOffsetMaxX;
		[Serialize("lookAtOffsetMaxY"        )] public float lookAtOffsetMaxY;
		[Serialize("lookAtOffsetMaxZ"        )] public float lookAtOffsetMaxZ;
		[Serialize("blendingZoneStart"       )] public float blendingZoneStart;
		[Serialize("blendingZoneStop"        )] public float blendingZoneStop;
		[Serialize("zoneNeutral"             )] public Vector2 zoneNeutral;
		[Serialize("useRotationCurve"        )] public bool useRotationCurve;
		[Serialize("rotationAngle"           )] public Angle rotationAngle;
		[Serialize("UseDynamicRotation"      )] public bool UseDynamicRotation;
		[Serialize("rotationSpeed"           )] public float rotationSpeed;
		[Serialize("rotationUpDownAngle"     )] public Angle rotationUpDownAngle;
		[Serialize("transitionTime"          )] public float transitionTime;
		[Serialize("moveInertia"             )] public float moveInertia;
		[Serialize("moveInertiaForZoomIn"    )] public float moveInertiaForZoomIn;
		[Serialize("moveInertiaForZoomOut"   )] public float moveInertiaForZoomOut;
		[Serialize("horizontalVersusVertical")] public float horizontalVersusVertical;
		[Serialize("offsetHVS"               )] public Vector2 offsetHVS;
		[Serialize("flipView"                )] public CameraFlip flipView;
		[Serialize("constraintLeftIsActive"  )] public bool constraintLeftIsActive;
		[Serialize("constraintRightIsActive" )] public bool constraintRightIsActive;
		[Serialize("constraintTopIsActive"   )] public bool constraintTopIsActive;
		[Serialize("constraintBottomIsActive")] public bool constraintBottomIsActive;
		[Serialize("constraintMatchView"     )] public bool constraintMatchView;
		[Serialize("constraintExtendedLeft"  )] public ConstraintExtended constraintExtendedLeft;
		[Serialize("constraintExtendedRight" )] public ConstraintExtended constraintExtendedRight;
		[Serialize("constraintExtendedTop"   )] public ConstraintExtended constraintExtendedTop;
		[Serialize("constraintExtendedBottom")] public ConstraintExtended constraintExtendedBottom;
		[Serialize("useDecentering"          )] public bool useDecentering;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(modifierPriority));
					SerializeField(s, nameof(constraintLeftIsActive));
					SerializeField(s, nameof(constraintRightIsActive));
					SerializeField(s, nameof(constraintTopIsActive));
					SerializeField(s, nameof(constraintBottomIsActive));
					SerializeField(s, nameof(constraintMatchView));
					SerializeField(s, nameof(constraintExtendedLeft));
					SerializeField(s, nameof(constraintExtendedRight));
					SerializeField(s, nameof(constraintExtendedTop));
					SerializeField(s, nameof(constraintExtendedBottom));
					SerializeField(s, nameof(blendingZoneStart));
					SerializeField(s, nameof(blendingZoneStop));
					SerializeField(s, nameof(zoneNeutral));
					SerializeField(s, nameof(useDecentering));
				}
			} else if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(modifierPriority));
					SerializeField(s, nameof(lookAtOffset));
					SerializeField(s, nameof(lookAtOffsetMax));
					SerializeField(s, nameof(blendingZoneStart));
					SerializeField(s, nameof(blendingZoneStop));
					SerializeField(s, nameof(zoneNeutral));
					SerializeField(s, nameof(useDecentering), type: typeof(byte));
					SerializeField(s, nameof(rotationAngle));
					SerializeField(s, nameof(rotationSpeed));
					SerializeField(s, nameof(flipView));
					SerializeField(s, nameof(constraintLeftIsActive), type: typeof(byte));
					SerializeField(s, nameof(constraintRightIsActive), type: typeof(byte));
					SerializeField(s, nameof(constraintTopIsActive), type: typeof(byte));
					SerializeField(s, nameof(constraintBottomIsActive), type: typeof(byte));
					SerializeField(s, nameof(constraintMatchView), type: typeof(byte));
					SerializeField(s, nameof(constraintExtendedLeft));
					SerializeField(s, nameof(constraintExtendedRight));
					SerializeField(s, nameof(constraintExtendedTop));
					SerializeField(s, nameof(constraintExtendedBottom));
				}
			} else if (Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(modifierPriority));
					SerializeField(s, nameof(lookAtOffset));
					SerializeField(s, nameof(lookAtOffsetMax));
					SerializeField(s, nameof(blendingZoneStart));
					SerializeField(s, nameof(blendingZoneStop));
					SerializeField(s, nameof(zoneNeutral));
					SerializeField(s, nameof(useDecentering), boolAsByte: true);
					SerializeField(s, nameof(rotationAngle));
					SerializeField(s, nameof(rotationSpeed));
					SerializeField(s, nameof(flipView));
					SerializeField(s, nameof(constraintLeftIsActive), boolAsByte: true);
					SerializeField(s, nameof(constraintRightIsActive), boolAsByte: true);
					SerializeField(s, nameof(constraintTopIsActive), boolAsByte: true);
					SerializeField(s, nameof(constraintBottomIsActive), boolAsByte: true);
					SerializeField(s, nameof(constraintMatchView), boolAsByte: true);
					SerializeField(s, nameof(constraintExtendedLeft));
					SerializeField(s, nameof(constraintExtendedRight));
					SerializeField(s, nameof(constraintExtendedTop));
					SerializeField(s, nameof(constraintExtendedBottom));
				}
			} else if (Settings.s.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(modifierPriority));
					SerializeField(s, nameof(lookAtOffset));
					SerializeField(s, nameof(lookAtOffsetMax));
					SerializeField(s, nameof(blendingZoneStart));
					SerializeField(s, nameof(blendingZoneStop));
					SerializeField(s, nameof(zoneNeutral));
					SerializeField(s, nameof(useDecentering));
					SerializeField(s, nameof(rotationAngle));
					SerializeField(s, nameof(rotationSpeed));
					SerializeField(s, nameof(moveInertia));
					SerializeField(s, nameof(moveInertiaForZoomIn));
					SerializeField(s, nameof(moveInertiaForZoomOut));
					SerializeField(s, nameof(horizontalVersusVertical));
					SerializeField(s, nameof(offsetHVS));
					SerializeField(s, nameof(flipView));
					SerializeField(s, nameof(constraintLeftIsActive));
					SerializeField(s, nameof(constraintRightIsActive));
					SerializeField(s, nameof(constraintTopIsActive));
					SerializeField(s, nameof(constraintBottomIsActive));
					SerializeField(s, nameof(constraintMatchView));
					SerializeField(s, nameof(constraintExtendedLeft));
					SerializeField(s, nameof(constraintExtendedRight));
					SerializeField(s, nameof(constraintExtendedTop));
					SerializeField(s, nameof(constraintExtendedBottom));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(lookAtOffset));
					SerializeField(s, nameof(lookAtOffsetMax));
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(modifierPriority));
					SerializeField(s, nameof(lookAtOffsetX));
					SerializeField(s, nameof(lookAtOffsetY));
					SerializeField(s, nameof(lookAtOffsetZ));
					SerializeField(s, nameof(lookAtOffsetMaxX));
					SerializeField(s, nameof(lookAtOffsetMaxY));
					SerializeField(s, nameof(lookAtOffsetMaxZ));
					SerializeField(s, nameof(blendingZoneStart));
					SerializeField(s, nameof(blendingZoneStop));
					SerializeField(s, nameof(zoneNeutral));
					SerializeField(s, nameof(useRotationCurve));
					SerializeField(s, nameof(rotationAngle));
					SerializeField(s, nameof(rotationAngle));
					SerializeField(s, nameof(UseDynamicRotation));
					SerializeField(s, nameof(rotationSpeed));
					SerializeField(s, nameof(rotationUpDownAngle));
					SerializeField(s, nameof(transitionTime));
					SerializeField(s, nameof(moveInertia));
					SerializeField(s, nameof(moveInertiaForZoomIn));
					SerializeField(s, nameof(moveInertiaForZoomOut));
					SerializeField(s, nameof(horizontalVersusVertical));
					SerializeField(s, nameof(offsetHVS));
					SerializeField(s, nameof(flipView));
					SerializeField(s, nameof(constraintLeftIsActive));
					SerializeField(s, nameof(constraintRightIsActive));
					SerializeField(s, nameof(constraintTopIsActive));
					SerializeField(s, nameof(constraintBottomIsActive));
					SerializeField(s, nameof(constraintMatchView));
					SerializeField(s, nameof(constraintExtendedLeft));
					SerializeField(s, nameof(constraintExtendedRight));
					SerializeField(s, nameof(constraintExtendedTop));
					SerializeField(s, nameof(constraintExtendedBottom));
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

