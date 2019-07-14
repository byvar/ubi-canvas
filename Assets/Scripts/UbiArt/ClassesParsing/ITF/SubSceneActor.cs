using UnityEngine;

namespace UbiArt.ITF {
	public partial class SubSceneActor {
		ContainerFile<Scene> sceneFile;

		protected override void InitGameObject() {
			base.InitGameObject();
			if (Settings.s.engineVersion > Settings.EngineVersion.RO) {
				if (SCENE != null && SCENE.read) {
					SCENE.value.SetGameObjectParent(gao, this);
				}
			} else {
				if (SCENE_ORIGINS != null && SCENE_ORIGINS.obj != null) {
					SCENE_ORIGINS.obj.SetGameObjectParent(gao, this);
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
						extS.Serialize(ref sceneFile);
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
