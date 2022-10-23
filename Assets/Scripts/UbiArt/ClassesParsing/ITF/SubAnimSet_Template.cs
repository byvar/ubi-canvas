using UbiArt.Animation;
using UnityEngine;

namespace UbiArt.ITF {
	public partial class SubAnimSet_Template {
		public ICSerializable[] resources;

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (s.Settings.engineVersion <= Settings.EngineVersion.RO && IsFirstLoad) {
				Loader l = s.Context.Loader;
				if (l.loadAnimations) {
					resources = new ICSerializable[resourceTypeList.Count];
					for (int i = 0; i < resourceTypeList.Count; i++) {
						uint type = resourceTypeList[i];
						Path path = resourceList[i];
						int j = i;
						switch (type) {
							case 0:
								l.LoadTexture(path, tex => resources[j] = tex);
								break;
							case 6:
								l.LoadFile<AnimTrack>(path, result => resources[j] = result);
								break;
							case 7:
								l.LoadFile<AnimSkeleton>(path, result => resources[j] = result);
								break;
							case 8:
								l.LoadFile<AnimPatchBank>(path, result => resources[j] = result);
								break;
						}
					}
				}
			}
		}
	}
}
