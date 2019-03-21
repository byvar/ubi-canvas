using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MultiTextureGraphicComponent_Template : GraphicComponent_Template {
		[Serialize("textureList")] public CList<TextureGraphicComponent_Template> textureList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(textureList));
		}
		public override uint? ClassCRC => 0x7FC5EE01;
	}
}

