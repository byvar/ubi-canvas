
namespace UbiArt.ITF {
	public partial class RO2_Brick_Template {
		public ContainerFile<Scene> sceneFile;

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (IsFirstLoad) {
				Loader l = s.Context.Loader;
				l.Load(archive, path.filename, (extS) => {
					sceneFile = extS.SerializeObject<ContainerFile<Scene>>(sceneFile);
				});
			}
		}
	}
}
