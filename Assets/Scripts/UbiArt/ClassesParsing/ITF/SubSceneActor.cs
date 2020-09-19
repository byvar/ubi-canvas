using Cysharp.Threading.Tasks;
using UnityEngine;

namespace UbiArt.ITF {
	public partial class SubSceneActor {
		ContainerFile<Scene> sceneFile;

		protected override async UniTask InitGameObject() {
			await base.InitGameObject();
			if (Settings.s.engineVersion > Settings.EngineVersion.RO) {
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
			if (isFirstLoad && !EMBED_SCENE) {
				MapLoader l = MapLoader.Loader;
				l.Load(RELATIVEPATH, (extS) => {
					if (l.isc.ContainsKey(RELATIVEPATH.stringID)) {
						sceneFile = l.isc[RELATIVEPATH.stringID];
					} else {
						extS.log = l.logEnabled;
						sceneFile = extS.SerializeObject<ContainerFile<Scene>>(sceneFile);
						l.isc[RELATIVEPATH.stringID] = sceneFile;
					}
					if (sceneFile != null) {
						if (Settings.s.engineVersion <= Settings.EngineVersion.RO) {
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
