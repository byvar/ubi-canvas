using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class ScreenshotComponent_Template : ActorComponent_Template {
		[Serialize("fontStyle"   )] public FontTextArea.Style fontStyle;
		[Serialize("renderStep"  )] public uint renderStep;
		[Serialize("text"        )] public string text;
		[Serialize("size"        )] public Vec2d size;
		[Serialize("logoPosition")] public Vec2d logoPosition;
		[Serialize("logoSize"    )] public Vec2d logoSize;
		[Serialize("textPosition")] public Vec2d textPosition;
		[Serialize("material"    )] public GFXMaterialSerializable material;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(fontStyle));
			SerializeField(s, nameof(renderStep));
			SerializeField(s, nameof(text));
			SerializeField(s, nameof(size));
			SerializeField(s, nameof(logoPosition));
			SerializeField(s, nameof(logoSize));
			SerializeField(s, nameof(textPosition));
			SerializeField(s, nameof(material));
		}
		public override uint? ClassCRC => 0xC7689FDA;
	}
}

