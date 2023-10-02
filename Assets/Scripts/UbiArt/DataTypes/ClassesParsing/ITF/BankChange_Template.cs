using UbiArt.Animation;

namespace UbiArt.ITF {
	public partial class BankChange_Template {
		public AnimPatchBank pbk;
		public TextureCooked tex;
		public Path pbkPath => new Path($"{bankPath.GetFilenameWithoutExtension(fullPath: true)}.pbk");

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (bankPath != null && IsFirstLoad) {
				Loader l = s.Context.Loader;
				if (l.LoadAnimations) {
					l.LoadFile<TextureCooked>(bankPath, result => tex = result);
					l.LoadFile<AnimPatchBank>(pbkPath, result => pbk = result);
				}
			}
		}
	}
}
