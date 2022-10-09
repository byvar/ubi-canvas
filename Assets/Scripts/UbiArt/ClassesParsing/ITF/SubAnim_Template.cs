using UbiArt.Animation;
using UnityEngine;

namespace UbiArt.ITF {
	public partial class SubAnim_Template {
		public AnimTrack anim;

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (name != null && IsFirstLoad) {
				Context l = s.Context;
				if (l.loadAnimations) {
					l.LoadFile<AnimTrack>(name, result => anim = result);
				}
			}
		}
	}
}
