using UnityEngine;

public class CameraSettings {
	public bool? IsOrthographic { get; set; }
	public float? FieldOfView { get; set; }
	public float? ClipNear { get; set; }
	public float? ClipFar { get; set; }
	public float? OrthographicSize { get; set; }
	public Vector3? Position { get; set; }
	public Quaternion? Rotation { get; set; }

	public void ApplyCameraSettings(Camera c, bool applyTransform = true, CameraComponent cc = null) {
		if (ClipFar.HasValue) c.farClipPlane = ClipFar.Value;
		if (ClipNear.HasValue) c.nearClipPlane = ClipNear.Value;
		if (FieldOfView.HasValue) c.fieldOfView = FieldOfView.Value;
		if (IsOrthographic.HasValue) c.orthographic = IsOrthographic.Value;
		if (OrthographicSize.HasValue) c.orthographicSize = OrthographicSize.Value;

		if (applyTransform) {
			if (Position.HasValue) c.transform.localPosition = Position.Value;
			if (Rotation.HasValue) c.transform.localRotation = Rotation.Value;
		}
		if (cc != null) cc.StopLerp();
	}
}