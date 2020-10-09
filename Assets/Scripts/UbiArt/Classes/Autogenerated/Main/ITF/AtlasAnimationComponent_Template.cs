using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class AtlasAnimationComponent_Template : GraphicComponent_Template {
		public Path texture;
		public GFXMaterialSerializable material;
		public float playRate;
		public float width;
		public float height;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				texture = s.SerializeObject<Path>(texture, name: "texture");
				playRate = s.Serialize<float>(playRate, name: "playRate");
				width = s.Serialize<float>(width, name: "width");
				height = s.Serialize<float>(height, name: "height");
			} else {
				if (s.HasFlags(SerializeFlags.Flags8)) {
					texture = s.SerializeObject<Path>(texture, name: "texture");
				}
				material = s.SerializeObject<GFXMaterialSerializable>(material, name: "material");
				playRate = s.Serialize<float>(playRate, name: "playRate");
				width = s.Serialize<float>(width, name: "width");
				height = s.Serialize<float>(height, name: "height");
			}
		}
		public override uint? ClassCRC => 0x90B7EDA3;
	}
}

