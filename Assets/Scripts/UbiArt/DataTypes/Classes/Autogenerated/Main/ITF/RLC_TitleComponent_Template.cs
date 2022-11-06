using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_TitleComponent_Template : ActorComponent_Template {
		public Path titleEFIGTextureBank;
		public Path titleArabicTextureBank;
		public Path titleJapaneseTextureBank;
		public Path titleCoreanTextureBank;
		public Path titleChineseTextureBank;
		public Path titleRussianTextureBank;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			titleEFIGTextureBank = s.SerializeObject<Path>(titleEFIGTextureBank, name: "titleEFIGTextureBank");
			titleArabicTextureBank = s.SerializeObject<Path>(titleArabicTextureBank, name: "titleArabicTextureBank");
			titleJapaneseTextureBank = s.SerializeObject<Path>(titleJapaneseTextureBank, name: "titleJapaneseTextureBank");
			titleCoreanTextureBank = s.SerializeObject<Path>(titleCoreanTextureBank, name: "titleCoreanTextureBank");
			titleChineseTextureBank = s.SerializeObject<Path>(titleChineseTextureBank, name: "titleChineseTextureBank");
			titleRussianTextureBank = s.SerializeObject<Path>(titleRussianTextureBank, name: "titleRussianTextureBank");
		}
		public override uint? ClassCRC => 0x2B6EF50B;
	}
}

