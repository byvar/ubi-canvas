using UnityEngine;

namespace UbiArt.ITF {
	public partial class UIMenu : UIItem {
		[Serialize("loadResource"  )] public bool loadResource;
		[Serialize("afxDuration"   )] public float afxDuration;
		[Serialize("menuType"      )] public MenuType menuType;
		[Serialize("fullscreenMenu")] public bool fullscreenMenu;
		[Serialize("menuType"      )] public Enum_menuType menuType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(loadResource));
				SerializeField(s, nameof(menuType));
			} else {
				SerializeField(s, nameof(loadResource));
				SerializeField(s, nameof(afxDuration));
				SerializeField(s, nameof(menuType));
				SerializeField(s, nameof(fullscreenMenu));
			}
		}
		public enum MenuType {
			[Serialize("MenuType_None"                             )] None = 0,
			[Serialize("MenuType_InputListener"                    )] InputListener = 2,
			[Serialize("MenuType_JustDisplay"                      )] JustDisplay = 1,
			[Serialize("MenuType_JustDisplayCanNotBeMasked"        )] JustDisplayCanNotBeMasked = 257,
			[Serialize("MenuType_InputListenerCannotBeMasked"      )] InputListenerCannotBeMasked = 258,
			[Serialize("MenuType_TouchListenerCannotBeMasked"      )] TouchListenerCannotBeMasked = 322,
			[Serialize("MenuType_InputListenerWithBack"            )] InputListenerWithBack = 10,
			[Serialize("MenuType_InputListenerWithExit"            )] InputListenerWithExit = 42,
			[Serialize("MenuType_InputListenerWithHiddenBack"      )] InputListenerWithHiddenBack = 26,
			[Serialize("MenuType_InputListenerWithBackAndAfx"      )] InputListenerWithBackAndAfx = 14,
			[Serialize("MenuType_InputListenerWithExitAndAfx"      )] InputListenerWithExitAndAfx = 46,
			[Serialize("MenuType_InputListenerWithHiddenBackAndAfx")] InputListenerWithHiddenBackAndAfx = 30,
			[Serialize("MenuType_InputListenerWithoutBackAndAfx"   )] InputListenerWithoutBackAndAfx = 6,
			[Serialize("MenuType_InputListenerAlways"              )] InputListenerAlways = 1026,
			[Serialize("MenuType_InputListenerAlwaysWithHiddenBack")] InputListenerAlwaysWithHiddenBack = 1050,
		}
		public enum Enum_menuType {
			[Serialize("Value_0"  )] Value_0 = 0,
			[Serialize("Value_2"  )] Value_2 = 2,
			[Serialize("Value_1"  )] Value_1 = 1,
			[Serialize("Value_257")] Value_257 = 257,
			[Serialize("Value_10" )] Value_10 = 10,
			[Serialize("Value_42" )] Value_42 = 42,
			[Serialize("Value_26" )] Value_26 = 26,
			[Serialize("Value_14" )] Value_14 = 14,
			[Serialize("Value_46" )] Value_46 = 46,
			[Serialize("Value_30" )] Value_30 = 30,
			[Serialize("Value_6"  )] Value_6 = 6,
			[Serialize("Value_287")] Value_287 = 287,
		}
		public override uint? ClassCRC => 0xDBD29D70;
	}
}

