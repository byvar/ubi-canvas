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
				if (conv.OldSettings.EngineVersion <= EngineVersion.RO && conv.OldSettings.EngineVersion > EngineVersion.RO) {
					version = VersionLegends;

					// Convert PBK
					if (templates != null) {
						foreach (var template in templates) {
							if (template?.bonesDyn != null) {
								foreach (var boneDyn in template.bonesDyn) {
									boneDyn.scale.x *= boneDyn.xScale;
									boneDyn.xScale = 1f;
								}
							}
						}
					}
				}
			}
			Reinit(s.Settings);
		}
	}
}
