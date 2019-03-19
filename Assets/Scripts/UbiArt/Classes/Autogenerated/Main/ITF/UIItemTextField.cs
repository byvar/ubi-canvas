using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class UIItemTextField : UIItemBasic {
		[Serialize("isPassword"       )] public bool isPassword;
		[Serialize("dialogMaxChar"    )] public uint dialogMaxChar;
		[Serialize("dialogAcceptSpace")] public bool dialogAcceptSpace;
		[Serialize("dialogNameRaw"    )] public string dialogNameRaw;
		[Serialize("dialogNameLoc"    )] public LocalisationId dialogNameLoc;
		[Serialize("style"            )] public InputAdapter__VK_style style;
		[Serialize("style"            )] public Enum_style style;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(isPassword), boolAsByte: true);
					SerializeField(s, nameof(dialogMaxChar));
					SerializeField(s, nameof(dialogAcceptSpace));
					SerializeField(s, nameof(dialogNameRaw));
					SerializeField(s, nameof(dialogNameLoc));
					SerializeField(s, nameof(style));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(isPassword));
					SerializeField(s, nameof(dialogMaxChar));
					SerializeField(s, nameof(dialogAcceptSpace));
					SerializeField(s, nameof(dialogNameRaw));
					SerializeField(s, nameof(dialogNameLoc));
					SerializeField(s, nameof(style));
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
		public enum Enum_style {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public override uint? ClassCRC => 0x51955F73;
	}
}

