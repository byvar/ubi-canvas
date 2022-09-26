using UbiArt.Animation;
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
							skel = extS.SerializeObject<AnimSkeleton>(skel);
							l.skl[skeleton.stringID] = skel;
							if (extS.CurrentPointer != extS.Length) {
								l.SystemLog?.LogInfo("Read:" + extS.CurrentPointer + " - Length:" + extS.Length + " - " + (extS.CurrentPointer == extS.Length ? "good!" : "bad!"));
							}
						}
					});
				}
			}
		}
	}
}
