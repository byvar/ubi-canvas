using Cysharp.Threading.Tasks;

namespace UbiArt.ITF {
	public partial class SubSceneActor {
		ContainerFile<Scene> sceneFile;

		public static string DefaultPath => "enginedata/actortemplates/subscene.tpl";

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
			if (EMBED_SCENE && (SCENE == null || SCENE.IsNull)) {
				SCENE = new Nullable<Scene>() {
					read = true,
					value = new Scene(s.Context)
				};
			}
		}
	}
}
