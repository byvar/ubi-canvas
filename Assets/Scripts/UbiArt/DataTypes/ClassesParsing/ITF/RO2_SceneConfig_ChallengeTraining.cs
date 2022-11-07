
namespace UbiArt.ITF {
	public partial class RO2_SceneConfig_ChallengeTraining {
		public GenericFile<CSerializable> mode;

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (IsFirstLoad) {
				Loader l = s.Context.Loader;
				l.LoadGenericFile(modePath, result => mode = result);
			}
		}
	}
}
