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
					l.Load(skeleton, (extS) => {
						if (l.skl.ContainsKey(skeleton.stringID)) {
							skel = l.skl[skeleton.stringID];
						} else {
							extS.log = l.logEnabled;
							skel = extS.SerializeObject<AnimSkeleton>(skel);
							l.skl[skeleton.stringID] = skel;
							if (extS.Position != extS.Length) {
								l.print("Read:" + extS.Position + " - Length:" + extS.Length + " - " + (extS.Position == extS.Length ? "good!" : "bad!"));
							}
						}
					});
				}
			}
		}
	}
}
