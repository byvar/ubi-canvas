using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class ScrollableCameraModifierComponent : CameraModifierComponent {
		public float cameraBrake;
		public float cameraBrakeMin;
		public float zoomMaxRatio;
		public float smartFocusZoomThreshold;
		public float focusZoomRatio;
		public float cameraMaxSpeed;
		public float cameraInterpolateSpeed;
		public float outOfBoundsSlowCoef;
		public float outOfBoundsForcePercentage;
		public float outOfBoundsForceMin;
		public float perpendicularInertiaSavedPercentage;
		public float angularPanCamera;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			cameraBrake = s.Serialize<float>(cameraBrake, name: "cameraBrake");
			cameraBrakeMin = s.Serialize<float>(cameraBrakeMin, name: "cameraBrakeMin");
			zoomMaxRatio = s.Serialize<float>(zoomMaxRatio, name: "zoomMaxRatio");
			smartFocusZoomThreshold = s.Serialize<float>(smartFocusZoomThreshold, name: "smartFocusZoomThreshold");
			focusZoomRatio = s.Serialize<float>(focusZoomRatio, name: "focusZoomRatio");
			cameraMaxSpeed = s.Serialize<float>(cameraMaxSpeed, name: "cameraMaxSpeed");
			cameraInterpolateSpeed = s.Serialize<float>(cameraInterpolateSpeed, name: "cameraInterpolateSpeed");
			outOfBoundsSlowCoef = s.Serialize<float>(outOfBoundsSlowCoef, name: "outOfBoundsSlowCoef");
			outOfBoundsForcePercentage = s.Serialize<float>(outOfBoundsForcePercentage, name: "outOfBoundsForcePercentage");
			outOfBoundsForceMin = s.Serialize<float>(outOfBoundsForceMin, name: "outOfBoundsForceMin");
			perpendicularInertiaSavedPercentage = s.Serialize<float>(perpendicularInertiaSavedPercentage, name: "perpendicularInertiaSavedPercentage");
			angularPanCamera = s.Serialize<float>(angularPanCamera, name: "angularPanCamera");
		}
		public override uint? ClassCRC => 0xC0FA5526;
	}
}

