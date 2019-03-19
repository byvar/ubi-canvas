using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_GFXMaterialShader_Layer_Template : CSerializable {
		[Serialize("Enabled")] public int Enabled;
		[Serialize("TexAdressingModeU")] public Enum_TexAdressingMode TexAdressingModeU;
		[Serialize("TexAdressingModeV")] public Enum_TexAdressingMode TexAdressingModeV;
		[Serialize("Filtering")] public int Filtering;
		[Serialize("DiffuseColor")] public Color DiffuseColor;
		[Serialize("TextureUsage")] public Enum_TextureUsage TextureUsage;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Enabled));
			SerializeField(s, nameof(TexAdressingModeU));
			SerializeField(s, nameof(TexAdressingModeV));
			SerializeField(s, nameof(Filtering));
			SerializeField(s, nameof(DiffuseColor));
			SerializeField(s, nameof(TextureUsage));
		}
		public enum Enum_TexAdressingMode {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public enum Enum_TextureUsage {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_5")] Value_5 = 5,
			[Serialize("Value_6")] Value_6 = 6,
		}
	}
}
