using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_TextureImageComponent : TextureGraphicComponent {
		[Serialize("offsetAfterLoading"          )] public Vector2 offsetAfterLoading;
		[Serialize("AllowDeloadTextureOnInactive")] public bool AllowDeloadTextureOnInactive;
		[Serialize("AllowAutomaticShow"          )] public bool AllowAutomaticShow;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(offsetAfterLoading));
			SerializeField(s, nameof(AllowDeloadTextureOnInactive));
			SerializeField(s, nameof(AllowAutomaticShow));
		}
		public override uint? ClassCRC => 0x2B83E1A7;
	}
}

