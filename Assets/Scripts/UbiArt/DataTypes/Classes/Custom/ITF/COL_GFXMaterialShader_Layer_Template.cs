using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_GFXMaterialShader_Layer_Template : CSerializable {
		public int Enabled;
		public Enum_TexAdressingMode TexAdressingModeU;
		public Enum_TexAdressingMode TexAdressingModeV;
		public int Filtering;
		public Color DiffuseColor;
		public Enum_TextureUsage TextureUsage;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Enabled = s.Serialize<int>(Enabled, name: "Enabled");
			TexAdressingModeU = s.Serialize<Enum_TexAdressingMode>(TexAdressingModeU, name: "TexAdressingModeU");
			TexAdressingModeV = s.Serialize<Enum_TexAdressingMode>(TexAdressingModeV, name: "TexAdressingModeV");
			Filtering = s.Serialize<int>(Filtering, name: "Filtering");
			DiffuseColor = s.SerializeObject<Color>(DiffuseColor, name: "DiffuseColor");
			TextureUsage = s.Serialize<Enum_TextureUsage>(TextureUsage, name: "TextureUsage");
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
