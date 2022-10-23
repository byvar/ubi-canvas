using Cysharp.Threading.Tasks;
using UnityEngine;

namespace UbiArt.ITF {
	public partial class SubSceneActor {
		ContainerFile<Scene> sceneFile;

		protected override async UniTask InitGameObject() {
			await base.InitGameObject();
			if (UbiArtContext.Settings.engineVersion > Settings.EngineVersion.RO) {
				if (SCENE != null && SCENE.read) {
					await SCENE.value.SetGameObjectParent(gao, this);
				}
			} else {
				if (SCENE_ORIGINS != null && SCENE_ORIGINS.obj != null) {
					await SCENE_ORIGINS.obj.SetGameObjectParent(gao, this);
				}
			}
		}

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (IsFirstLoad && !EMBED_SCENE) {
				Loader l = s.Context.Loader;
				l.LoadFile<ContainerFile<Scene>>(RELATIVEPATH, result => {
					sceneFile = result;

					if (sceneFile != null) {
						if (l.Settings.engineVersion <= Settings.EngineVersion.RO) {
							SCENE_ORIGINS = new Generic<Scene>(sceneFile.obj);
						} else {
							SCENE = new Nullable<Scene>() {
								read = true,
								value = sceneFile.obj
							};
						}
					}
				});
			}
		}
	}
}
