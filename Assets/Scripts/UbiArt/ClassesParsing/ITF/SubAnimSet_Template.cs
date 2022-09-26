﻿using UbiArt.Animation;
using UnityEngine;

namespace UbiArt.ITF {
	public partial class SubAnimSet_Template {
		public ICSerializable[] resources;

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (s.Settings.engineVersion <= Settings.EngineVersion.RO && IsFirstLoad) {
				Context l = s.Context;
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
										l.SystemLog?.LogInfo("Read:" + extS.CurrentPointer + " - Length:" + extS.Length + " - " + (extS.CurrentPointer == extS.Length ? "good!" : "bad!"));
									}
								});
								break;
							case 6:
								l.Load(path, (extS) => {
									if (l.anm.ContainsKey(path.stringID)) {
										resources[j] = l.anm[path.stringID];
									} else {
										AnimTrack temp = null;
										temp = extS.SerializeObject<AnimTrack>(temp);
										l.anm[path.stringID] = temp;
										resources[j] = temp;
										l.SystemLog?.LogInfo("Read:" + extS.CurrentPointer + " - Length:" + extS.Length + " - " + (extS.CurrentPointer == extS.Length ? "good!" : "bad!"));
									}
								});
								break;
							case 7:
								l.Load(path, (extS) => {
									if (l.skl.ContainsKey(path.stringID)) {
										resources[j] = l.skl[path.stringID];
									} else {
										AnimSkeleton temp = null;
										temp = extS.SerializeObject<AnimSkeleton>(temp);
										l.skl[path.stringID] = temp;
										resources[j] = temp;
										l.SystemLog?.LogInfo("Read:" + extS.CurrentPointer + " - Length:" + extS.Length + " - " + (extS.CurrentPointer == extS.Length ? "good!" : "bad!"));
									}
								});
								break;
							case 8:
								l.Load(path, (extS) => {
									if (l.pbk.ContainsKey(path.stringID)) {
										resources[j] = l.pbk[path.stringID];
									} else {
										AnimPatchBank temp = null;
										temp = extS.SerializeObject<AnimPatchBank>(temp);
										l.pbk[path.stringID] = temp;
										resources[j] = temp;
										l.SystemLog?.LogInfo("Read:" + extS.CurrentPointer + " - Length:" + extS.Length + " - " + (extS.CurrentPointer == extS.Length ? "good!" : "bad!"));
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
