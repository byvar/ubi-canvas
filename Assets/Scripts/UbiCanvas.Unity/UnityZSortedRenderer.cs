using UnityEngine;
using UbiArt;
using UbiArt.ITF;
using UbiCanvas.Helpers;

public class UnityZSortedRenderer : MonoBehaviour {
	public Renderer Renderer;
	float prevZ = -99999;

	private void Update() {
		if (GlobalLoadState.LoadState != GlobalLoadState.State.Finished) return;
		if (Renderer != null) {
			float z = transform.position.z;
			if (z != prevZ) {
				prevZ = z;
				ZListManager zman = Controller.Obj.zListManager;
				zman.zDict[Renderer] = z;
			}
		}
	}
}
