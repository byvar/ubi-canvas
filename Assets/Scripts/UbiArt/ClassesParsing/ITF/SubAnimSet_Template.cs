using UbiArt.Animation;
using UnityEngine;

namespace UbiArt.ITF {
	public partial class SubAnimSet_Template {
		public ICSerializable[] resources;

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (Settings.s.engineVersion <= Settings.EngineVersion.RO && isFirstLoad) {
				MapLoader l = MapLoader.Loader;
				if (l.loadAnimations) {
					resources = new ICSerializable[resourceTypeList.Count];
					for (int i = 0; i < resourceTypeList.Count; i++) {
						uint type = resourceTypeList[i];
						Path path = resourceList[i];
						int j = i;
						switch (type) {
							case 0:
								l.Load(path, (extS) => {
									if (l.tex.ContainsKey(path.stringID)) {
										resources[j] = l.tex[path.stringID];
									} else {
										TextureCooked temp = null;
										temp = extS.SerializeObject<TextureCooked>(temp);
										l.tex[path.stringID] = temp;
										temp.atlas = l.uvAtlasManager.GetAtlasIfExists(path);
										resources[j] = temp;
										l.print("Read:" + extS.Position + " - Length:" + extS.Length + " - " + (extS.Position == extS.Length ? "good!" : "bad!"));
									}
								});
								break;
							case 6:
								l.Load(path, (extS) => {
									if (l.anm.ContainsKey(path.stringID)) {
										resources[j] = l.anm[path.stringID];
									} else {
										extS.log = l.logEnabled;
										AnimTrack temp = null;
										temp = extS.SerializeObject<AnimTrack>(temp);
										l.anm[path.stringID] = temp;
										resources[j] = temp;
										l.print("Read:" + extS.Position + " - Length:" + extS.Length + " - " + (extS.Position == extS.Length ? "good!" : "bad!"));
									}
								});
								break;
							case 7:
								l.Load(path, (extS) => {
									if (l.skl.ContainsKey(path.stringID)) {
										resources[j] = l.skl[path.stringID];
									} else {
										extS.log = l.logEnabled;
										AnimSkeleton temp = null;
										temp = extS.SerializeObject<AnimSkeleton>(temp);
										l.skl[path.stringID] = temp;
										resources[j] = temp;
										l.print("Read:" + extS.Position + " - Length:" + extS.Length + " - " + (extS.Position == extS.Length ? "good!" : "bad!"));
									}
								});
								break;
							case 8:
								l.Load(path, (extS) => {
									if (l.pbk.ContainsKey(path.stringID)) {
										resources[j] = l.pbk[path.stringID];
									} else {
										extS.log = l.logEnabled;
										AnimPatchBank temp = null;
										temp = extS.SerializeObject<AnimPatchBank>(temp);
										l.pbk[path.stringID] = temp;
										resources[j] = temp;
										l.print("Read:" + extS.Position + " - Length:" + extS.Length + " - " + (extS.Position == extS.Length ? "good!" : "bad!"));
									}
								});
								break;
						}
					}
				}
			}
		}
	}
}
