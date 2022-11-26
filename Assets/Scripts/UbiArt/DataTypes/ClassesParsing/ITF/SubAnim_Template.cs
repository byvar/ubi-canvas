using UbiArt.Animation;

namespace UbiArt.ITF {
	public partial class SubAnim_Template {
		public AnimTrack anim;

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (name != null && IsFirstLoad) {
				Loader l = s.Context.Loader;
				if (l.LoadAnimations) {
					l.LoadFile<AnimTrack>(name, result => anim = result);
				}
			}
		}
	}
}
