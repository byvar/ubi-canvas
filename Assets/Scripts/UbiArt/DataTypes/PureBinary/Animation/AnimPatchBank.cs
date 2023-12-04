namespace UbiArt.Animation {
	// See: ITF::AnimPatchBank::serialize
	// pbk.ckd file
	public class AnimPatchBank : CSerializable {
		public const uint VersionLegends = 0x10;
		public const uint VersionFiestaRun = 0xD;

		public uint version;
		public Link bankId;
		public float unk;
		public KeyArray<int> templateKeys;
		public CListO<AnimTemplate> templates;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			version = s.Serialize<uint>(version, name: "version");
			bankId = s.SerializeObject<Link>(bankId, name: "bankId");
			unk = s.Serialize<float>(unk, name: "unk");
			templateKeys = s.SerializeObject<KeyArray<int>>(templateKeys, name: "templateKeys");
			templates = s.SerializeObject<CListO<AnimTemplate>>(templates, name: "templates");
		}

		public void Reinit(Settings settings) {
			if (settings.Game == Game.RL) {
				if (version >= VersionLegends) {
					version = VersionLegends;
				}
			}
		}
		protected override void OnPreSerialize(CSerializerObject s) {
			base.OnPreSerialize(s);
			if (s.Context.HasSettings<ConversionSettings>()) {
				var conv = s.Context.GetSettings<ConversionSettings>();
				if (conv.OldSettings.EngineVersion <= EngineVersion.RO && s.Settings.EngineVersion > EngineVersion.RO) {
					version = VersionLegends;

					// Convert PBK
					ConvertOriginsPositionsToLegends(s);
				}
			}
			Reinit(s.Settings);
		}

		public void ConvertOriginsPositionsToLegends(CSerializerObject s) {
			var conv = s.Context.GetSettings<ConversionSettings>();
			var contextToUse = conv.OldContext ?? s.Context;

			if (templates != null) {
				foreach (var template in templates) {
					if (template?.bones != null) {
						var bones = template.bones;
						var bonesDyn = template?.bonesDyn;
						for (int i = 0; i < bones.Count; i++) {
							int parentIndex = -1;
							if (bones[i].parentKey.stringID != 0) {
								AnimBone parent = template.GetBoneFromLink(bones[i].parentKey);
								if (parent != null) {
									parentIndex = bones.IndexOf(parent);
								}
							}
							if (parentIndex != -1) {
								bonesDyn[i].PositionPreConversion = new Vec2d(bonesDyn[i].position.x, bonesDyn[i].position.y);
								//bonesDyn[i].position.x /= bonesDyn[parentIndex].boneLength;
								//bonesDyn[i].position.x += 1;
								//bonesDyn[i].position.x += bonesDyn[parentIndex].boneLength;
							}
						}
					}
					if (template?.bonesDyn != null) {
						foreach (var boneDyn in template.bonesDyn) {
							boneDyn.scale.x *= boneDyn.boneLength;
							//boneDyn.boneLength = 1f;
						}
					}
				}
			}
		}
	}
}
