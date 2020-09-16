using UbiArt.Animation;
using UnityEngine;

namespace UbiArt.ITF {
	public partial class SubAnim_Template {
		public AnimTrack anim;

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (name != null && isFirstLoad) {
				MapLoader l = MapLoader.Loader;
				if (l.loadAnimations) {
					l.Load(name, (extS) => {
						if (l.anm.ContainsKey(name.stringID)) {
							anim = l.anm[name.stringID];
						} else {
							extS.log = l.logEnabled;
							extS.Serialize(ref anim);
							l.anm[name.stringID] = anim;
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
