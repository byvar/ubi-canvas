using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_Brick_Template {
		public SceneFile sceneFile;

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (isFirstLoad) {
				MapLoader l = MapLoader.Loader;
				l.Load(archive, path.filename, (extS) => {
					extS.log = l.logEnabled;
					extS.Serialize(ref sceneFile);
				});
			}
		}
	}
}
