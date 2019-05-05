using UnityEngine;

namespace UbiArt.ITF {
	public partial class SubSceneActor {
		protected override void InitGameObject() {
			base.InitGameObject();
			if (Settings.s.engineVersion > Settings.EngineVersion.RO) {
				if (SCENE != null && SCENE.read) {
					SCENE.value.SetGameObjectParent(gao);
				}
			} else {
				if (SCENE_ORIGINS != null && SCENE_ORIGINS.obj != null) {
					SCENE_ORIGINS.obj.SetGameObjectParent(gao);
				}
			}
		}
	}
}
