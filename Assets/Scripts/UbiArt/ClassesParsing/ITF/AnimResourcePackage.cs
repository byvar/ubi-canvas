﻿using UbiArt.Animation;
using UnityEngine;

namespace UbiArt.ITF {
	public partial class AnimResourcePackage {
		public AnimSkeleton skel;

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (skeleton != null && IsFirstLoad) {
				Context l = UbiArtContext;
				if (l.loadAnimations) {
					l.LoadFile<AnimSkeleton>(skeleton, result => skel = result);
				}
			}
		}
	}
}
