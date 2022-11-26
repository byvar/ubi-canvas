using UbiArt.Animation;

namespace UbiArt.ITF {
	public partial class AnimResourcePackage {
		public AnimSkeleton skel;

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (skeleton != null && IsFirstLoad) {
				Loader l = s.Context.Loader;
				if (l.LoadAnimations) {
					l.LoadFile<AnimSkeleton>(skeleton, result => skel = result);
				}
			}
		}
	}
}
