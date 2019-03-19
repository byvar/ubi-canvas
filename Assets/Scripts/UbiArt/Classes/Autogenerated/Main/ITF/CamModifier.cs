using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
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
		[Serialize("int__0"                  )] public int int__0;
		[Serialize("int__1"                  )] public int int__1;
		[Serialize("int__2"                  )] public int int__2;
		[Serialize("int__3"                  )] public int int__3;
		[Serialize("int__4"                  )] public int int__4;
		[Serialize("int__5"                  )] public int int__5;
		[Serialize("ConstraintExtended__6"   )] public ConstraintExtended ConstraintExtended__6;
		[Serialize("ConstraintExtended__7"   )] public ConstraintExtended ConstraintExtended__7;
		[Serialize("ConstraintExtended__8"   )] public ConstraintExtended ConstraintExtended__8;
		[Serialize("ConstraintExtended__9"   )] public ConstraintExtended ConstraintExtended__9;
		[Serialize("float__10"               )] public float float__10;
		[Serialize("float__11"               )] public float float__11;
		[Serialize("Vector2__12"             )] public Vector2 Vector2__12;
		[Serialize("int__13"                 )] public int int__13;
		[Serialize("int__14"                 )] public int int__14;
		[Serialize("Vector3__15"             )] public Vector3 Vector3__15;
		[Serialize("Vector3__16"             )] public Vector3 Vector3__16;
		[Serialize("float__17"               )] public float float__17;
		[Serialize("float__18"               )] public float float__18;
		[Serialize("Vector2__19"             )] public Vector2 Vector2__19;
		[Serialize("bool__20"                )] public bool bool__20;
		[Serialize("Angle__21"               )] public Angle Angle__21;
		[Serialize("float__22"               )] public float float__22;
		[Serialize("Angle__23"               )] public Angle Angle__23;
		[Serialize("float__24"               )] public float float__24;
		[Serialize("float__25"               )] public float float__25;
		[Serialize("float__26"               )] public float float__26;
		[Serialize("Vector2__27"             )] public Vector2 Vector2__27;
		[Serialize("Enum_VH_0__28"           )] public Enum_VH_0 Enum_VH_0__28;
		[Serialize("bool__29"                )] public bool bool__29;
		[Serialize("bool__30"                )] public bool bool__30;
		[Serialize("bool__31"                )] public bool bool__31;
		[Serialize("bool__32"                )] public bool bool__32;
		[Serialize("bool__33"                )] public bool bool__33;
		[Serialize("ConstraintExtended__34"  )] public ConstraintExtended ConstraintExtended__34;
		[Serialize("ConstraintExtended__35"  )] public ConstraintExtended ConstraintExtended__35;
		[Serialize("ConstraintExtended__36"  )] public ConstraintExtended ConstraintExtended__36;
		[Serialize("ConstraintExtended__37"  )] public ConstraintExtended ConstraintExtended__37;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(int__0));
					SerializeField(s, nameof(int__1));
					SerializeField(s, nameof(int__2));
					SerializeField(s, nameof(int__3));
					SerializeField(s, nameof(int__4));
					SerializeField(s, nameof(int__5));
					SerializeField(s, nameof(ConstraintExtended__6));
					SerializeField(s, nameof(ConstraintExtended__7));
					SerializeField(s, nameof(ConstraintExtended__8));
					SerializeField(s, nameof(ConstraintExtended__9));
					SerializeField(s, nameof(float__10));
					SerializeField(s, nameof(float__11));
					SerializeField(s, nameof(Vector2__12));
					SerializeField(s, nameof(int__13));
				}
			} else if (Settings.s.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(int__14));
					SerializeField(s, nameof(Vector3__15));
					SerializeField(s, nameof(Vector3__16));
					SerializeField(s, nameof(float__17));
					SerializeField(s, nameof(float__18));
					SerializeField(s, nameof(Vector2__19));
					SerializeField(s, nameof(bool__20));
					SerializeField(s, nameof(Angle__21));
					SerializeField(s, nameof(float__22));
					SerializeField(s, nameof(Angle__23));
					SerializeField(s, nameof(float__24));
					SerializeField(s, nameof(float__25));
					SerializeField(s, nameof(float__26));
					SerializeField(s, nameof(Vector2__27));
					SerializeField(s, nameof(Enum_VH_0__28));
					SerializeField(s, nameof(bool__29));
					SerializeField(s, nameof(bool__30));
					SerializeField(s, nameof(bool__31));
					SerializeField(s, nameof(bool__32));
					SerializeField(s, nameof(bool__33));
					SerializeField(s, nameof(ConstraintExtended__34));
					SerializeField(s, nameof(ConstraintExtended__35));
					SerializeField(s, nameof(ConstraintExtended__36));
					SerializeField(s, nameof(ConstraintExtended__37));
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
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
	}
}

