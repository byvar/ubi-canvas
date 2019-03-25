using UnityEngine;

namespace UbiArt.ITF {
	public partial class SubSceneActor {
		protected override void InitGameObject() {
			base.InitGameObject();
			if (SCENE.read) {
				foreach (Frise f in SCENE.value.FRISE) {
					f.SetGameObjectParent(gao);
				}
				foreach (Generic<Actor> a in SCENE.value.ACTORS) {
					a.obj.SetGameObjectParent(gao);
				}
			}
		}
	}
}
