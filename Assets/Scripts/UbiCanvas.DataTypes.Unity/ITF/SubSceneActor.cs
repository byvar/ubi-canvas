using Cysharp.Threading.Tasks;
using UnityEngine;

namespace UbiArt.ITF {
	public partial class SubSceneActor {
		protected override async UniTask InitGameObject() {
			await base.InitGameObject();
			if (UbiArtContext.Settings.EngineVersion > EngineVersion.RO) {
				if (SCENE != null && SCENE.read) {
					await SCENE.value.SetGameObjectParent(gao, this);
				}
			} else {
				if (SCENE_ORIGINS != null && SCENE_ORIGINS.obj != null) {
					await SCENE_ORIGINS.obj.SetGameObjectParent(gao, this);
				}
			}
		}
	}
}
