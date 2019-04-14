using UnityEngine;
using UbiArt;
using UbiArt.ITF;

public class UnityBone : MonoBehaviour {
	public Transform parent;
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
	}
}
