using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_Brick_Template {
		public ContainerFile<Scene> sceneFile;

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (isFirstLoad) {
				MapLoader l = MapLoader.Loader;
				l.Load(archive, path.filename, (extS) => {
					extS.log = l.logEnabled;
					sceneFile = extS.SerializeObject<ContainerFile<Scene>>(sceneFile);
				});
			}
		}
	}
}
