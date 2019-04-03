using UnityEngine;

namespace UbiArt.ITF {
	public partial class SceneConfig {
		public virtual void InitUnityComponent(Scene scene, GameObject gao, int index) {
			UnitySceneConfig usc = gao.AddComponent<UnitySceneConfig>();
			usc.config = this;
		}
	}
}
