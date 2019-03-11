using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_TitleComponent_Template : ActorComponent_Template {
		[Serialize("titleEFIGTextureBank"    )] public Path titleEFIGTextureBank;
		[Serialize("titleArabicTextureBank"  )] public Path titleArabicTextureBank;
		[Serialize("titleJapaneseTextureBank")] public Path titleJapaneseTextureBank;
		[Serialize("titleCoreanTextureBank"  )] public Path titleCoreanTextureBank;
		[Serialize("titleChineseTextureBank" )] public Path titleChineseTextureBank;
		[Serialize("titleRussianTextureBank" )] public Path titleRussianTextureBank;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(titleEFIGTextureBank));
			SerializeField(s, nameof(titleArabicTextureBank));
			SerializeField(s, nameof(titleJapaneseTextureBank));
			SerializeField(s, nameof(titleCoreanTextureBank));
			SerializeField(s, nameof(titleChineseTextureBank));
			SerializeField(s, nameof(titleRussianTextureBank));
		}
		public override uint? ClassCRC => 0x2B6EF50B;
	}
}

