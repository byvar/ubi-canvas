using UnityEngine;

namespace UbiArt.ITF {
	public partial class Scene {
		protected GameObject gao;
		public GameObject Gao {
			get {
				if (gao == null) {
					InitGameObject();
				}
				return gao;
			}
		}

		protected virtual void InitGameObject() {
			gao = new GameObject("Scene");
			Gao.transform.localPosition = Vector3.zero;
			Gao.transform.localScale = Vector3.one;
			Gao.transform.localRotation = Quaternion.identity;
			foreach (Frise f in FRISE) {
				f.SetGameObjectParent(gao);
			}
			foreach (Generic<Actor> a in ACTORS) {
				a.obj.SetGameObjectParent(gao);
			}
			if (sceneConfigs != null && sceneConfigs.sceneConfigs != null) {
				for (int i = 0; i < sceneConfigs.sceneConfigs.Count; i++) {
					Generic<SceneConfig> sc = sceneConfigs.sceneConfigs[i];
					if (sc.obj != null) sc.obj.InitUnityComponent(this, gao, i);
				}
			}
		}
		public void SetGameObjectParent(GameObject gp) {
			Gao.transform.SetParent(gp.transform, false);
			Gao.transform.localPosition = Vector3.zero;
			Gao.transform.localScale = Vector3.one;
			Gao.transform.localRotation = Quaternion.identity;
		}
	}
}
