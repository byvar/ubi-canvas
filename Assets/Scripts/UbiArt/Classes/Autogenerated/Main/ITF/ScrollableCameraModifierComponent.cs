using UnityEngine;

namespace UbiArt.ITF {
	public partial class ScrollableCameraModifierComponent : CameraModifierComponent {
		[Serialize("cameraBrake"                        )] public float cameraBrake;
		[Serialize("cameraBrakeMin"                     )] public float cameraBrakeMin;
		[Serialize("zoomMaxRatio"                       )] public float zoomMaxRatio;
		[Serialize("smartFocusZoomThreshold"            )] public float smartFocusZoomThreshold;
		[Serialize("focusZoomRatio"                     )] public float focusZoomRatio;
		[Serialize("cameraMaxSpeed"                     )] public float cameraMaxSpeed;
		[Serialize("cameraInterpolateSpeed"             )] public float cameraInterpolateSpeed;
		[Serialize("outOfBoundsSlowCoef"                )] public float outOfBoundsSlowCoef;
		[Serialize("outOfBoundsForcePercentage"         )] public float outOfBoundsForcePercentage;
		[Serialize("outOfBoundsForceMin"                )] public float outOfBoundsForceMin;
		[Serialize("perpendicularInertiaSavedPercentage")] public float perpendicularInertiaSavedPercentage;
		[Serialize("angularPanCamera"                   )] public float angularPanCamera;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(cameraBrake));
			SerializeField(s, nameof(cameraBrakeMin));
			SerializeField(s, nameof(zoomMaxRatio));
			SerializeField(s, nameof(smartFocusZoomThreshold));
			SerializeField(s, nameof(focusZoomRatio));
			SerializeField(s, nameof(cameraMaxSpeed));
			SerializeField(s, nameof(cameraInterpolateSpeed));
			SerializeField(s, nameof(outOfBoundsSlowCoef));
			SerializeField(s, nameof(outOfBoundsForcePercentage));
			SerializeField(s, nameof(outOfBoundsForceMin));
			SerializeField(s, nameof(perpendicularInertiaSavedPercentage));
			SerializeField(s, nameof(angularPanCamera));
		}
		public override uint? ClassCRC => 0xC0FA5526;
	}
}

