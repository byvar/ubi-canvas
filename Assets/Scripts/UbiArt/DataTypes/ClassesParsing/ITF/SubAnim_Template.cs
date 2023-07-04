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
				AddToStringCache(s);
			}
		}

		protected void AddToStringCache(CSerializerObject s) {
			if (!string.IsNullOrWhiteSpace(name?.filename)) {
				var newname = name.filename;
				if(newname.EndsWith(".anm")) newname = newname.Substring(0, newname.Length - 4);
				s.Context.AddToStringCache(newname);
			}
		}
	}
}
