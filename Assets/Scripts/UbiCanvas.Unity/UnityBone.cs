using UnityEngine;
using UbiArt;

public class UnityBone : MonoBehaviour {
	public UnityBone parent;
	public Vector3 localPosition;
	public float localRotation;
	public Vector3 localScale = Vector3.one;
	public Vector3 bindPosition;
	public float bindRotation;
	public Vector3 bindScale = Vector3.one;
	public bool bind = false;
	public Vector3 globalPosition = Vector3.zero;
	public float globalAngle;
	public Vector3 computedScale = Vector3.one;
	public float boneLength = 0f;
	public float xScaleMultiplier = 1f;
	public float localZ = 0;
	public float bindZ = 0;
	public float bindAlpha = 1f;
	public float localAlpha = 0f;
	
	public bool visualize = false;
	public GameObject Visual { get; set; }

	private void Start() {		
	}
	void Update() {
		UpdateBone();
		UpdateVisual();
	}

	public void UpdateBone() {
		var c = Controller.MainContext;
		if (bind) {
			if (parent != null) {
				globalAngle = parent.globalAngle + bindRotation + localRotation;
				float xPos = (parent.computedScale.x) * (bindPosition.x + localPosition.x + parent.boneLength);
				float yPos = -(parent.computedScale.y) * (bindPosition.y + localPosition.y);
				var rotatedPos = new Vec2d(xPos, yPos).Rotate(parent.globalAngle);
				globalPosition = parent.globalPosition + new Vector3(rotatedPos.x, rotatedPos.y, 0f);
			} else {
				// Check ITF::AnimInfo::ComputeBonesFromLocalToWorld
				globalPosition = localPosition;
				globalAngle = bindRotation + localRotation;
			}
			computedScale = Vector3.Scale(localScale, bindScale);
			if (c.Settings.EngineVersion == EngineVersion.RO) {
				transform.localScale = new Vector3(computedScale.x * xScaleMultiplier, computedScale.y, 1f);
			} else {
				transform.localScale = computedScale;
			}
			transform.localRotation = new Angle(globalAngle).GetUnityQuaternion();
			transform.localPosition = globalPosition;
		} else {
			if (parent != null) {
				transform.localPosition = parent.transform.localPosition + parent.transform.localRotation * localPosition;
				transform.localRotation = parent.transform.localRotation * new Angle(localRotation).GetUnityQuaternion();
				transform.localScale = localScale;
			} else {
				transform.localPosition = localPosition;
				transform.localRotation = new Angle(localRotation).GetUnityQuaternion();
				transform.localScale = localScale;
			}
		}
	}

	public void UpdateVisual() {
		if (visualize && Visual == null) {
			var subobj = new GameObject("SR");
			subobj.transform.SetParent(transform, false);
			subobj.transform.localPosition = Vector3.zero;
			subobj.transform.localRotation = Quaternion.Euler(0, 0, 0);
			subobj.transform.localScale = new Vector3(1f, 0.1f, 0.1f);

			SpriteRenderer sr = subobj.AddComponent<SpriteRenderer>();
			sr.sprite = Controller.Obj.GetIcon("bone");
			sr.sortingLayerName = "Gizmo";

			Visual = subobj;
		}
		if (Visual != null && Visual.activeSelf != visualize) {
			Visual.SetActive(visualize);
		}
	}
}
