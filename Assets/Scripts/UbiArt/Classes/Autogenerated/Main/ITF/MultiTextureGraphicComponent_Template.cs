using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MultiTextureGraphicComponent_Template : GraphicComponent_Template {
		public CListO<TextureGraphicComponent_Template> textureList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			textureList = s.SerializeObject<CListO<TextureGraphicComponent_Template>>(textureList, name: "textureList");
		}
		public override uint? ClassCRC => 0x7FC5EE01;
	}
}

