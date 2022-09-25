using UnityEngine;
using UbiArt;
using UbiArt.ITF;
using UbiCanvas.Helpers;

public class UnityFrise : MonoBehaviour {
	public Frise frise;
	float prevZ = -99999;

	private void Update() {
		if (GlobalLoadState.LoadState != GlobalLoadState.State.Finished) return;
		if (frise != null) {
			float z = transform.position.z;
			if (z != prevZ) {
				prevZ = z;
				ZListManager zman = Controller.Obj.zListManager;
				if (frise.mr_static != null) {
					zman.zDict[frise.mr_static] = z;
					/*foreach (Material m in frise.mr_static.sharedMaterials) {
						zman.zDict[m] = z;
						z += 0.001f;
					}*/
				}
				if (frise.mr_overlay != null) {
					zman.zDict[frise.mr_overlay] = z;
					/*foreach (Material m in frise.mr_static.sharedMaterials) {
						zman.zDict[m] = z;
						z += 0.001f;
					}*/
				}
				if (frise.mr_anim != null) {
					zman.zDict[frise.mr_anim] = z;
					/*foreach (Material m in frise.mr_anim.sharedMaterials) {
						zman.zDict[m] = z;
						z += 0.001f;
					}*/
				}
			}
		}
	}
}
