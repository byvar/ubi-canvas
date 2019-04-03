using UnityEngine;

namespace UbiArt.ITF {
	public partial class SubSceneActor {
		protected override void InitGameObject() {
			base.InitGameObject();
			if (SCENE.read) {
				SCENE.value.SetGameObjectParent(gao);
			}
		}
	}
}
