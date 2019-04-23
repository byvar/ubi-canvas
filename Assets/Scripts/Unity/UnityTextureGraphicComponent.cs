using UnityEngine;
using UbiArt;
using UbiArt.ITF;

public class UnityTextureGraphicComponent : MonoBehaviour {
	public TextureGraphicComponent tgc;
	float prevZ = -99999;

	private void Update() {
		if (tgc != null && tgc.tex_mat != null) {
			float z = transform.position.z;
			if (z != prevZ) {
				prevZ = z;
				ZListManager zman = MapLoader.Loader.controller.zListManager;
				zman.zDict[tgc.tex_mat] = z;
			}
		}
	}
}
