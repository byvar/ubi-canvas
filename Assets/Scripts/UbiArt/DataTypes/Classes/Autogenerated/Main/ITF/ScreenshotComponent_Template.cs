using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class ScreenshotComponent_Template : ActorComponent_Template {
		public FontTextArea.Style fontStyle;
		public uint renderStep;
		public string text;
		public Vec2d size;
		public Vec2d logoPosition;
		public Vec2d logoSize;
		public Vec2d textPosition;
		public GFXMaterialSerializable material;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			fontStyle = s.SerializeObject<FontTextArea.Style>(fontStyle, name: "fontStyle");
			renderStep = s.Serialize<uint>(renderStep, name: "renderStep");
			text = s.Serialize<string>(text, name: "text");
			size = s.SerializeObject<Vec2d>(size, name: "size");
			logoPosition = s.SerializeObject<Vec2d>(logoPosition, name: "logoPosition");
			logoSize = s.SerializeObject<Vec2d>(logoSize, name: "logoSize");
			textPosition = s.SerializeObject<Vec2d>(textPosition, name: "textPosition");
			material = s.SerializeObject<GFXMaterialSerializable>(material, name: "material");
		}
		public override uint? ClassCRC => 0xC7689FDA;
	}
}

