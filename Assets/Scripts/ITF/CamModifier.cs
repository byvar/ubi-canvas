using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class CamModifier : BaseObject {
		[Serialize(0, "modifierPriority")] public int modifierPriority;

		[Serialize(1, "lookAtOffset", game = Settings.Game.RL)] public Vector3 lookAtOffset;
		[Serialize(1, "lookAtOffsetX", game = Settings.Game.RA)] public float lookAtOffsetX;
		[Serialize(2, "lookAtOffsetY", game = Settings.Game.RA)] public float lookAtOffsetY;
		[Serialize(3, "lookAtOffsetZ", game = Settings.Game.RA)] public float lookAtOffsetZ;

		[Serialize(2, "lookAtOffsetMax", game = Settings.Game.RL)] public Vector3 lookAtOffsetMax;
		[Serialize(4, "lookAtOffsetMaxX", game = Settings.Game.RA)] public float lookAtOffsetMaxX;
		[Serialize(5, "lookAtOffsetMaxY", game = Settings.Game.RA)] public float lookAtOffsetMaxY;
		[Serialize(6, "lookAtOffsetMaxZ", game = Settings.Game.RA)] public float lookAtOffsetMaxZ;

		[Serialize(7, "blendingZoneStart")] public float blendingZoneStart;
		[Serialize(8, "blendingZoneStop")] public float blendingZoneStop;
		[Serialize(9, "zoneNeutral")] public Vector2 zoneNeutral;
		[Serialize(10, "useDecentering", game = Settings.Game.RL)] public byte useDecentering;
		[Serialize(10, "useRotationCurve", game = Settings.Game.RA)] public bool useRotationCurve;
		[Serialize(11, "rotationAngle")] public Angle rotationAngle;
		[Serialize(12, "UseDynamicRotation", game = Settings.Game.RA)] public bool UseDynamicRotation;
		[Serialize(13, "rotationSpeed")] public float rotationSpeed;
		[Serialize(14, "rotationUpDownAngle", game = Settings.Game.RA)] public Angle rotationUpDownAngle;
		[Serialize(15, "transitionTime", game = Settings.Game.RA)] public float transitionTime;
		[Serialize(16, "moveInertia", game = Settings.Game.RA)] public float moveInertia;
		[Serialize(17, "moveInertiaForZoomIn", game = Settings.Game.RA)] public float moveInertiaForZoomIn;
		[Serialize(18, "moveInertiaForZoomOut", game = Settings.Game.RA)] public float moveInertiaForZoomOut;
		[Serialize(19, "horizontalVersusVertical", game = Settings.Game.RA)] public float horizontalVersusVertical;
		[Serialize(20, "offsetHVS", game = Settings.Game.RA)] public Vector2 offsetHVS;
		[Serialize(21, "flipView")] public CameraFlip flipView;

		[Serialize(22, "constraintLeftIsActive", game = Settings.Game.RL)] public byte constraintLeftIsActive;
		[Serialize(23, "constraintRightIsActive", game = Settings.Game.RL)] public byte constraintRightIsActive;
		[Serialize(24, "constraintTopIsActive", game = Settings.Game.RL)] public byte constraintTopIsActive;
		[Serialize(25, "constraintBottomIsActive", game = Settings.Game.RL)] public byte constraintBottomIsActive;
		[Serialize(26, "constraintMatchView", game = Settings.Game.RL)] public byte constraintMatchView;

		[Serialize(22, "constraintLeftIsActive", game = Settings.Game.RA)] public bool constraintLeftIsActiveBool;
		[Serialize(23, "constraintRightIsActive", game = Settings.Game.RA)] public bool constraintRightIsActiveBool;
		[Serialize(24, "constraintTopIsActive", game = Settings.Game.RA)] public bool constraintTopIsActiveBool;
		[Serialize(25, "constraintBottomIsActive", game = Settings.Game.RA)] public bool constraintBottomIsActiveBool;
		[Serialize(26, "constraintMatchView", game = Settings.Game.RA)] public bool constraintMatchViewBool;

		[Serialize(27, "constraintExtendedLeft")] public ConstraintExtended constraintExtendedLeft;
		[Serialize(28, "constraintExtendedRight")] public ConstraintExtended constraintExtendedRight;
		[Serialize(29, "constraintExtendedTop")] public ConstraintExtended constraintExtendedTop;
		[Serialize(30, "constraintExtendedBottom")] public ConstraintExtended constraintExtendedBottom;

		public CamModifier(Reader reader) : base(reader) {
		}

		public enum CameraFlip {
			None = 0,
			X,
			Y,
			Both
		}
	}
}
