namespace UbiArt.SceneConfig {
	public class SceneConfigManager : CSerializable {
		[Serialize("unk"        )] public uint unk;
		[Serialize("dataversion")] public uint dataversion;
		[Serialize("sgsMap"     )] public CMapGeneric<StringID, ITF.SceneConfig> sgsMap;
		[Serialize("sgsMap"     )] public SgsKey sgsMapAdv;

		protected override void SerializeImpl(CSerializerObject s) {
			if(Settings.s.game == Settings.Game.RA) {
				s.SerializePureBinary<uint>(ref unk, name: "unk");
				SerializeField(s, nameof(sgsMapAdv));
			} else {
				SerializeField(s, nameof(unk));
				SerializeField(s, nameof(dataversion));
				SerializeField(s, nameof(sgsMap));
			}
		}

		public class SgsKey : CSerializable {
			[Serialize("Keys")] public CMap<StringID, Generic<ITF.SceneConfig>> Keys;

			protected override void SerializeImpl(CSerializerObject s) {
				SerializeField(s, nameof(Keys));
			}

			public override string ClassName => "SceneConfigManager::SgsKey";

			//public override uint? ClassCRC => new StringID("SceneConfigManager::SgsKey");
		}
	}
}
