using UbiArt.Animation;
using UnityEngine;

namespace UbiArt.ITF {
	public partial class AnimResourcePackage {
		public AnimSkeleton skel;

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (skeleton != null && isFirstLoad) {
				MapLoader l = MapLoader.Loader;
				l.Load(skeleton, (extS) => {
					if (l.skl.ContainsKey(skeleton.stringID)) {
						skel = l.skl[skeleton.stringID];
					} else {
						extS.Serialize(ref skel);
						l.skl[skeleton.stringID] = skel;
						l.print("Read:" + extS.Position + " - Length:" + extS.Length + " - " + (extS.Position == extS.Length ? "good!" : "bad!"));
					}
				});
			}
		}
	}
}
