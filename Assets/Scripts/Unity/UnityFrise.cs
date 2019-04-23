using UnityEngine;
using UbiArt;
using UbiArt.ITF;

public class UnityFrise : MonoBehaviour {
	public Frise frise;
	float prevZ = -99999;

	private void Update() {
		if (frise != null) {
			float z = transform.position.z;
			if (z != prevZ) {
				prevZ = z;
				ZListManager zman = MapLoader.Loader.controller.zListManager;
				if (frise.mr_static != null) {
					foreach (Material m in frise.mr_static.sharedMaterials) {
						zman.zDict[m] = z;
						z += 0.001f;
					}
				}
				if (frise.mr_anim != null) {
					foreach (Material m in frise.mr_anim.sharedMaterials) {
						zman.zDict[m] = z;
						z += 0.001f;
					}
				}
			}
		}
	}
}
