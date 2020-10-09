using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class UIItemTextField : UIItemBasic {
		public bool isPassword;
		public uint dialogMaxChar;
		public bool dialogAcceptSpace;
		public string dialogNameRaw;
		public LocalisationId dialogNameLoc;
		public InputAdapter__VK_style style;
		public InputAdapter__VK_style2 style2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					isPassword = s.Serialize<bool>(isPassword, name: "isPassword", options: CSerializerObject.Options.BoolAsByte);
					dialogMaxChar = s.Serialize<uint>(dialogMaxChar, name: "dialogMaxChar");
					dialogAcceptSpace = s.Serialize<bool>(dialogAcceptSpace, name: "dialogAcceptSpace");
					dialogNameRaw = s.Serialize<string>(dialogNameRaw, name: "dialogNameRaw");
					dialogNameLoc = s.SerializeObject<LocalisationId>(dialogNameLoc, name: "dialogNameLoc");
					style2 = s.Serialize<InputAdapter__VK_style2>(style2, name: "style");
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					isPassword = s.Serialize<bool>(isPassword, name: "isPassword");
					dialogMaxChar = s.Serialize<uint>(dialogMaxChar, name: "dialogMaxChar");
					dialogAcceptSpace = s.Serialize<bool>(dialogAcceptSpace, name: "dialogAcceptSpace");
					dialogNameRaw = s.Serialize<string>(dialogNameRaw, name: "dialogNameRaw");
					dialogNameLoc = s.SerializeObject<LocalisationId>(dialogNameLoc, name: "dialogNameLoc");
					style = s.Serialize<InputAdapter__VK_style>(style, name: "style");
				}
			}
		}
		public enum InputAdapter__VK_style {
			[Serialize("InputAdapter::VK_style_full" )] full = 0,
			[Serialize("InputAdapter::VK_style_num"  )] num = 1,
			[Serialize("InputAdapter::VK_style_email")] email = 2,
			[Serialize("InputAdapter::VK_style_latin")] latin = 3,
			[Serialize("InputAdapter::VK_style_url"  )] url = 4,
		}
		public enum InputAdapter__VK_style2 {
			[Serialize("InputAdapter::VK_style_full")] full = 0,
			[Serialize("InputAdapter::VK_style_num")] num = 1,
			[Serialize("InputAdapter::VK_style_email")] email = 2,
			[Serialize("InputAdapter::VK_style_latin")] latin = 3,
		}
		public override uint? ClassCRC => 0x51955F73;
	}
}

