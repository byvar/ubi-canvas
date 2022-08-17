using System;
using UnityEngine;

// Very simple smooth mouselook modifier for the MainCamera in Unity
// by Francis R. Griffiths-Keam - www.runningdimensions.com
// http://forum.unity3d.com/threads/a-free-simple-smooth-mouselook.73117/


public class CameraComponent : MonoBehaviour {
	public Controller controller;
	Vector2 _mouseAbsolute;
	Vector2 _smoothMouse;

	public Vector2 clampInDegrees = new Vector2(360, 180);
	public Vector2 sensitivity = new Vector2(2, 2);
	public Vector2 sensitivityRMB = new Vector2(1.6f, 1.6f);
	public Vector2 smoothing = new Vector2(3, 3);
	public Quaternion? targetDirection;

	public bool MouseLookEnabled { get; private set; } = false;
	public bool MouseLookRMBEnabled { get; private set; } = false;
	private bool _shifted = false;
	public float flySpeed = 20f;
	public float flySpeedShiftMultiplier = 2.0f;
	private float flySpeedFactor = 30f;
	private float _flySpeedShiftMultiplier = 1.0f;
	public float panningThreshold = 10f;
	private Vector3 panStart;
	public Camera cam;

	public float lerpFactor = 1f;
	Vector3? targetPos = null;
	Quaternion? targetRot = null;
	float? targetOrthoSize = null;

	private Vector3 lastMousePosition = Vector3.zero;
	private bool panning = false;

	private CameraSettings PerspectiveSettings { get; set; }
	private CameraSettings OrthographicSettings { get; set; }

	public Camera[] otherCameras;


	void Start() {
		PerspectiveSettings = new CameraSettings() {
			ClipFar = cam.farClipPlane,
			ClipNear = cam.nearClipPlane,
			FieldOfView = cam.fieldOfView,
			IsOrthographic = false,
			OrthographicSize = cam.orthographicSize,
			Position = cam.transform.position,
			Rotation = cam.transform.rotation,
		};
		OrthographicSettings = new CameraSettings() {
			IsOrthographic = true,
			OrthographicSize = 10f,
			Position = new Vector3(cam.transform.position.x, cam.transform.position.y, 0f) - Vector3.forward * cam.farClipPlane * 0.5f,
			Rotation = Quaternion.identity,
		};
	}

    public void JumpTo(GameObject gao, bool frontView = false) {
        Vector3? center = null, size = null;
        center = (gao.transform.position);
		size = gao.transform.lossyScale;
        if (center.HasValue) {
            float cameraDistance = 4.0f; // Constant factor
            float objectSize = Mathf.Min(5f, Mathf.Max(size.Value.x, size.Value.y, size.Value.z));
			bool orthographic = cam.orthographic;
			if (orthographic) {
				targetOrthoSize = objectSize * 2f * 1.5f;
				Vector3 target = cam.transform.InverseTransformPoint(center.Value);
				targetPos = cam.transform.TransformPoint(new Vector3(target.x, target.y, 0f));
			} else {
				float cameraView = 2.0f * Mathf.Tan(0.5f * Mathf.Deg2Rad * cam.fieldOfView); // Visible height 1 meter in front
				float distance = cameraDistance * objectSize / cameraView; // Combined wanted distance from the object
				distance += objectSize; // Estimated offset from the center to the outside of the object * 2
				/*transform.position = center.Value + -transform.right * distance;
				transform.LookAt(center.Value, Vector3.up);*/
				//transform.LookAt(center.Value, Vector3.up);
				//transform.position = center.Value + Vector3.Normalize(transform.position - center.Value) * distance;
				if (frontView) {
					targetPos = center.Value + Vector3.back * distance;
					targetRot = Quaternion.identity;
				} else {
					targetPos = center.Value + Vector3.Normalize(transform.position - center.Value) * distance;
					if (center.Value - transform.position != Vector3.zero) {
						targetRot = Quaternion.LookRotation(center.Value - transform.position, Vector3.up);
					}
				}
			}
		}
	}
	public void StopLerp() {
		targetPos = null;
		targetRot = null;
		targetOrthoSize = null;
	}

	void SetOrthographic(bool orthographic) {
		if (cam.orthographic) {
			OrthographicSettings.OrthographicSize = cam.orthographicSize;
			OrthographicSettings.Position = new Vector3(cam.transform.position.x, cam.transform.position.y, 0f) - Vector3.forward * cam.farClipPlane * 0.5f;
		} else {
			PerspectiveSettings.Position = cam.transform.position;
			PerspectiveSettings.Rotation = cam.transform.rotation;
		}
		var settings = orthographic ? OrthographicSettings : PerspectiveSettings;

		settings.ApplyCameraSettings(cam, true, this);
		if(otherCameras != null)
			foreach(var oc in otherCameras) settings.ApplyCameraSettings(oc, false, this);
	}

	void Update() {
		cam.transparencySortMode = TransparencySortMode.CustomAxis;
		cam.transparencySortAxis = new Vector3(0.0f, 0.0f, 1.0f);


		MouseLookRMBEnabled = false;
		if (Controller.LoadState != Controller.State.Finished && Controller.LoadState != Controller.State.Error) return;
		if (!targetDirection.HasValue) {
			// Set target direction to the camera's initial orientation.
			targetDirection = transform.localRotation;
		}

		if (Input.GetKeyDown(KeyCode.O)) {
			SetOrthographic(!cam.orthographic);
		}

		bool orthographic = cam.orthographic;

		if (Input.GetKeyUp(KeyCode.LeftShift) & _shifted)
			_shifted = false;

		if ((Input.GetKeyDown(KeyCode.LeftShift) & !_shifted && !Input.GetMouseButton(1)) |
			(Input.GetKeyDown(KeyCode.Escape) & MouseLookEnabled)) {
			_shifted = true;

			if (!MouseLookEnabled) {
				MouseLookEnabled = true;
				Cursor.lockState = CursorLockMode.Locked;
				Cursor.visible = false;
			} else {
				if (Input.GetKeyDown(KeyCode.Escape))
					_shifted = false;

				MouseLookEnabled = false;
				Cursor.lockState = CursorLockMode.None;
				Cursor.visible = true;
			}
		}

		if (!MouseLookEnabled) {
			if (targetPos.HasValue) {
				if (Vector3.Distance(transform.position, targetPos.Value) < 0.4f) {
					targetPos = null;
				} else {
					transform.position = Vector3.Lerp(transform.position, targetPos.Value, Time.deltaTime * lerpFactor);
				}
			}
			if (targetRot.HasValue) {
				if (Mathf.Abs(Quaternion.Angle(transform.rotation, targetRot.Value)) < 10) {
					targetRot = null;
				} else {
					transform.rotation = Quaternion.Lerp(transform.rotation, targetRot.Value, Time.deltaTime * lerpFactor);
				}
			}

			Vector3 mouseDeltaOrtho = Input.mousePosition - lastMousePosition;
			lastMousePosition = Input.mousePosition;

			if (orthographic) {
				if (targetOrthoSize.HasValue) {
					if (Mathf.Abs(targetOrthoSize.Value - cam.orthographicSize) < 0.04f) {
						targetOrthoSize = null;
					} else {
						cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, targetOrthoSize.Value, Time.deltaTime * lerpFactor);
					}
				}

				if (Input.GetMouseButton(1) || (Input.GetMouseButton(0))) {
					StopLerp();

					if (panStart == Vector3.zero) {
						panStart = Input.mousePosition;
					}
					Rect screenRect = new Rect(0, 0, Screen.width, Screen.height);

					if (panning) {

						float xFactor = cam.orthographicSize * 2.0f / cam.pixelHeight;
						float yFactor = cam.orthographicSize * 2.0f / cam.pixelHeight;

						transform.Translate(Vector3.right * xFactor * -mouseDeltaOrtho.x, Space.Self);
						transform.Translate(Vector3.up * yFactor * -mouseDeltaOrtho.y, Space.Self);
					} else if (Input.GetMouseButtonDown(1) || (Input.GetMouseButtonDown(0) && !controller.selector.IsSelecting) && screenRect.Contains(Input.mousePosition)) { // Only start panning if within game window when you click
						panning = true;
					}
				} else {
					panStart = Vector3.zero;
					panning = false;
				}
				CameraControlsOrthographic();
			} else {
				// Right click: drag also works
				if (Input.GetMouseButton(1)) {
					MouseLookRMBEnabled = true;
					StopLerp();

					Cursor.lockState = CursorLockMode.Locked;
					Cursor.visible = false;

					CalculateMouseLook(orthographic, false);

					if (Input.GetKey(KeyCode.LeftShift)) {
						_flySpeedShiftMultiplier = flySpeedShiftMultiplier;
					} else {
						_flySpeedShiftMultiplier = 1.0f;
					}

					CameraControlsPerspective();
				}

				if (Input.GetMouseButtonUp(1)) {
					Cursor.lockState = CursorLockMode.None;
					Cursor.visible = true;
					_flySpeedShiftMultiplier = 1.0f;
				}
			}
			CameraControlsSpeed();

		} else {
			StopLerp();
			//ensure these stay this way
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;

			CalculateMouseLook(orthographic, true);

			//movement
			if (orthographic) {
				CameraControlsOrthographic();

			} else {
				CameraControlsPerspective();
			}
			CameraControlsSpeed();
		}
		if (orthographic) {
			if (otherCameras != null)
				foreach (var oc in otherCameras) {
					oc.orthographicSize = cam.orthographicSize;
				}
		}
	}

	#region Camera Controls
	void CameraControlsOrthographic() {
		float orthoFlySpeedMult = (float)Math.Sqrt(cam.orthographicSize);

		if (Input.GetKey(KeyCode.LeftShift)) {
			_flySpeedShiftMultiplier = flySpeedShiftMultiplier;
		} else {
			_flySpeedShiftMultiplier = 1.0f;
		}

		if (Input.GetAxis("Mouse ScrollWheel") != 0) {
			StopLerp();
			cam.orthographicSize *= (float)Math.Pow(2, (-Input.GetAxis("Mouse ScrollWheel")));
		}

		if (Input.GetAxis("Vertical") != 0) {
			StopLerp();
			transform.Translate(Vector3.up * flySpeed * orthoFlySpeedMult * Time.deltaTime * Input.GetAxis("Vertical"), Space.Self);
		}
		if (Input.GetAxis("Horizontal") != 0) {
			StopLerp();
			transform.Translate(Vector3.right * flySpeed * orthoFlySpeedMult * Time.deltaTime * Input.GetAxis("Horizontal"), Space.Self);
		}
		if (Input.GetAxis("HeightAndZoom") != 0) {
			StopLerp();
			cam.orthographicSize *= (float)Math.Pow(2, (Input.GetAxis("HeightAndZoom") * Time.deltaTime));
		}
	}
	void CameraControlsPerspective() {
		if (Input.GetAxis("Mouse ScrollWheel") != 0) {
			flySpeed = Mathf.Max(0, flySpeed + Time.deltaTime * Input.GetAxis("Mouse ScrollWheel") * 100f * flySpeedFactor);
		}
		if (Input.GetAxis("Vertical") != 0) {
			transform.Translate(cam.transform.forward * flySpeed * Time.deltaTime * _flySpeedShiftMultiplier * Input.GetAxis("Vertical"), Space.World);
		}
		if (Input.GetAxis("Horizontal") != 0) {
			transform.Translate(cam.transform.right * flySpeed * Time.deltaTime * _flySpeedShiftMultiplier * Input.GetAxis("Horizontal"), Space.World);
		}
		if (Input.GetAxis("HeightAndZoom") != 0) {
			transform.Translate(Vector3.up * flySpeed * Time.deltaTime * _flySpeedShiftMultiplier * Input.GetAxis("HeightAndZoom"), Space.World);
		}
		if (Input.GetKey(KeyCode.Keypad8)) {
			transform.Translate(Vector3.up * flySpeed * Time.deltaTime * 0.5f, Space.World);
		} else if (Input.GetKey(KeyCode.Keypad2)) {
			transform.Translate(-Vector3.up * flySpeed * Time.deltaTime * 0.5f, Space.World);
		}
	}
	void CameraControlsSpeed() {
		if (Input.GetKey(KeyCode.Plus) || Input.GetKey(KeyCode.KeypadPlus)) {
			flySpeed += Time.deltaTime * flySpeedFactor;
		} else if (Input.GetKey(KeyCode.Minus) || Input.GetKey(KeyCode.KeypadMinus)) {
			flySpeed = Mathf.Max(0, flySpeed - Time.deltaTime * flySpeedFactor);
		}
	}
	#endregion

	void CalculateMouseLook(bool orthographic, bool smooth) {
		// Allow the script to clamp based on a desired target value.
		Vector3 eulerTargetDir = targetDirection.Value.eulerAngles;
		/*bool eulerDirChanged = false;

		if (eulerTargetDir.z != 0) {
			if (Mathf.Abs(eulerTargetDir.z) < 0.04f) {
				eulerTargetDir = new Vector3(eulerTargetDir.x, eulerTargetDir.y, 0f);
			} else {
				eulerTargetDir = new Vector3(eulerTargetDir.x, eulerTargetDir.y, Mathf.Lerp(eulerTargetDir.z, 0f, Time.deltaTime * lerpFactor));
			}
			eulerDirChanged = true;
		} else if (eulerTargetDir.x != 0) {
			//eulerTargetDir = new Vector3(0f, eulerTargetDir.y, eulerTargetDir.z);
			if (Mathf.Abs(eulerTargetDir.x) < 0.04f) {
				eulerTargetDir = new Vector3(0f, eulerTargetDir.y, eulerTargetDir.z);
			} else {
				eulerTargetDir = new Vector3(Mathf.Lerp(eulerTargetDir.x, 0f, Time.deltaTime * lerpFactor), eulerTargetDir.y, eulerTargetDir.z);
			}
			eulerDirChanged = true;
		}*/
		if (eulerTargetDir.x != 0 || eulerTargetDir.z != 0) {
			if (Mathf.Abs(eulerTargetDir.x) < 0.04f && Mathf.Abs(eulerTargetDir.z) < 0.04f) {
				targetDirection = Quaternion.Euler(0f, eulerTargetDir.y, 0f);
			} else {
				targetDirection = Quaternion.Lerp(targetDirection.Value, Quaternion.Euler(0, eulerTargetDir.y, 0), Time.deltaTime * lerpFactor);
			}
		}
		var targetOrientation = targetDirection.Value;

		// Get raw mouse input for a cleaner reading on more sensitive mice.
		var mouseDelta = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

		// Scale input against the sensitivity setting and multiply that against the smoothing value.
		var sensitivity = smooth ? this.sensitivity : sensitivityRMB;
		mouseDelta = Vector2.Scale(mouseDelta, new Vector2(sensitivity.x * smoothing.x, sensitivity.y * smoothing.y));

		if (smooth) {
			// Interpolate mouse movement over time to apply smoothing delta.
			_smoothMouse.x = Mathf.Lerp(_smoothMouse.x, mouseDelta.x, 1f / smoothing.x);
			_smoothMouse.y = Mathf.Lerp(_smoothMouse.y, mouseDelta.y, 1f / smoothing.y);
			// Find the absolute mouse movement value from point zero.
			_mouseAbsolute += _smoothMouse;
		} else {
			_mouseAbsolute += mouseDelta;
		}

		// Clamp and apply the local x value first, so as not to be affected by world transforms.
		if (clampInDegrees.x < 360)
			_mouseAbsolute.x = Mathf.Clamp(_mouseAbsolute.x, -clampInDegrees.x * 0.5f, clampInDegrees.x * 0.5f);

		// Then clamp and apply the global y value.
		if (clampInDegrees.y < 360)
			_mouseAbsolute.y = Mathf.Clamp(_mouseAbsolute.y, -clampInDegrees.y * 0.5f, clampInDegrees.y * 0.5f);

		if (!orthographic) {
			var xRotation = Quaternion.AngleAxis(-_mouseAbsolute.y, targetOrientation * Vector3.right);
			transform.localRotation = xRotation * targetOrientation;

			// If there's a character body that acts as a parent to the camera
			var yRotation = Quaternion.AngleAxis(_mouseAbsolute.x, transform.InverseTransformDirection(Vector3.up));
			transform.localRotation *= yRotation;
		}
	}

	public bool IsPanningWithThreshold() {
		return panning && (Input.mousePosition - panStart).magnitude > panningThreshold;
	}
}
