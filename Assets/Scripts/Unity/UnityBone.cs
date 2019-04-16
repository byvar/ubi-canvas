using UnityEngine;
using UbiArt;
using UbiArt.ITF;

public class UnityBone : MonoBehaviour {
	/*public Transform parent;
	public Vector3 bindPosition;
	public Quaternion bindRotation;
	public Vector3 localPosition;
	public Quaternion localRotation;

	void Update() {
		if (parent != null) {
			transform.localPosition = parent.transform.localPosition + parent.transform.localRotation * (bindPosition + localPosition); // (Vector3.Scale(parent.transform.localScale, localPosition));
			transform.localRotation = parent.transform.localRotation * (bindRotation * localRotation);
		} else {
			transform.localPosition = bindPosition + localPosition;
			transform.localRotation = bindRotation * localRotation;
		}
	}*/

	/*public Transform parent;
	public Vector3 localPosition;
	public Quaternion localRotation;

	void Update() {
		if (parent != null) {
			transform.localPosition = parent.transform.localPosition + parent.transform.localRotation * (Vector3.Scale(parent.transform.localScale, localPosition));
			transform.localRotation = parent.transform.localRotation * localRotation;
		} else {
			transform.localPosition = localPosition;
			transform.localRotation = localRotation;
		}
	}*/

	public UnityBone parent;
	public Vector3 localPosition;
	public Angle localRotation;
	public Vector3 localScale;
	public Vector3 bindPosition;
	public Angle bindRotation;
	public Vector3 bindScale;
	public bool bind = false;
	private Vector3 parentScale = Vector3.one;

	/*void Update() {
		if (parent != null) {
			transform.localPosition = parent.transform.localPosition + parent.transform.localRotation * (Vector3.Scale(parent.transform.localScale, localPosition));
			transform.localRotation = parent.transform.localRotation * localRotation;
			transform.localScale = Vector3.Scale(parent.transform.localScale, localScale);
		} else {
			transform.localPosition = localPosition;
			transform.localRotation = localRotation;
			transform.localScale = localScale;
		}
	}*/
	void Update() {
		UpdateBone();
	}

	public void UpdateBone() {
		if (bind) {
			if (parent != null) {
				transform.localScale = Vector3.Scale(localScale, bindScale);
				parentScale = Vector3.Scale(parent.parentScale,Vector3.Scale(parent.localScale, parent.bindScale));
				
				transform.localPosition = parent.transform.localPosition + parent.transform.localRotation * (bindPosition + localPosition);
				transform.localRotation = parent.transform.localRotation * new Angle(bindRotation + localRotation).QuaternionAngle;
				
				/*transform.localPosition = (bindPosition + localPosition);
				transform.localRotation = new Angle(bindRotation + localRotation).QuaternionAngle;*/
				//transform.localScale = Vector3.Scale(parent.transform.localScale, localScale);
			} else {
				transform.localScale = Vector3.Scale(localScale, bindScale);
				transform.localPosition = bindPosition + localPosition;
				transform.localRotation = new Angle(bindRotation + localRotation).QuaternionAngle;
			}
		} else {
			if (parent != null) {
				transform.localPosition = parent.transform.localPosition + parent.transform.localRotation * localPosition;
				transform.localRotation = parent.transform.localRotation * localRotation.QuaternionAngle;
				//transform.localScale = Vector3.Scale(parent.transform.localScale, localScale);
				transform.localScale = localScale;
			} else {
				transform.localPosition = localPosition;
				transform.localRotation = localRotation.QuaternionAngle;
				transform.localScale = localScale;
			}
		}
	}
}
