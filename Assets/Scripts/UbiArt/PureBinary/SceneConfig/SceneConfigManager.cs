namespace UbiArt.SceneConfig {
	public class SceneConfigManager : CSerializable {
		[Serialize("unk"        )] public uint unk;
		[Serialize("dataversion")] public uint dataversion;
		[Serialize("sgsMap"     )] public CMapGeneric<StringID, ITF.SceneConfig> sgsMap;

		protected override void SerializeImpl(CSerializerObject s) {
			SerializeField(s, nameof(unk));
			SerializeField(s, nameof(dataversion));
			SerializeField(s, nameof(sgsMap));
		}
	}
}
