using System;
using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class UIMenu : UIItem {
		public bool loadResource;
		public float afxDuration;
		public MenuType menuType;
		public MenuType2 menuType2;
		public MenuType3 menuType3;
		public bool fullscreenMenu;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.COL) {
				loadResource = s.Serialize<bool>(loadResource, name: "loadResource");
				menuType2 = s.Serialize<MenuType2>(menuType2, name: "menuType");
			} else if (s.Settings.game == Settings.Game.VH) {
				loadResource = s.Serialize<bool>(loadResource, name: "loadResource");
				afxDuration = s.Serialize<float>(afxDuration, name: "afxDuration");
				menuType3 = s.Serialize<MenuType3>(menuType3, name: "menuType");
			} else {
				loadResource = s.Serialize<bool>(loadResource, name: "loadResource");
				afxDuration = s.Serialize<float>(afxDuration, name: "afxDuration");
				menuType = s.Serialize<MenuType>(menuType, name: "menuType");
				fullscreenMenu = s.Serialize<bool>(fullscreenMenu, name: "fullscreenMenu");
			}
		}
		[Flags]
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
		[Flags]
		public enum MenuType2 {
			[Serialize("MenuType_None"                             )] None = 0,
			[Serialize("MenuType_InputListener"                    )] InputListener = 2,
			[Serialize("MenuType_JustDisplay"                      )] JustDisplay = 1,
			[Serialize("MenuType_JustDisplayCanNotBeMasked"        )] JustDisplayCanNotBeMasked = 257,
			[Serialize("MenuType_InputListenerWithBack"            )] InputListenerWithBack = 10,
			[Serialize("MenuType_InputListenerWithExit"            )] InputListenerWithExit = 42,
			[Serialize("MenuType_InputListenerWithHiddenBack"      )] InputListenerWithHiddenBack = 26,
			[Serialize("MenuType_InputListenerWithBackAndAfx"      )] InputListenerWithBackAndAfx = 14,
			[Serialize("MenuType_InputListenerWithExitAndAfx"      )] InputListenerWithExitAndAfx = 46,
			[Serialize("MenuType_InputListenerWithHiddenBackAndAfx")] InputListenerWithHiddenBackAndAfx = 30,
			[Serialize("MenuType_InputListenerWithoutBackAndAfx"   )] InputListenerWithoutBackAndAfx = 6,
			[Serialize("MenuType_JustDisplayAndInputListenerWithHiddenBackAndAfxCanNotBeMasked")] JustDisplayAndInputListenerWithHiddenBackAndAfxCanNotBeMasked = 287, // Custom name
		}
		[Flags]
		public enum MenuType3 {
			[Serialize("MenuType_None"                             )] None = 0,
			[Serialize("MenuType_InputListener"                    )] InputListener = 2,
			[Serialize("MenuType_JustDisplay"                      )] JustDisplay = 1,
			[Serialize("MenuType_JustDisplayCanNotBeMasked"        )] JustDisplayCanNotBeMasked = 257,
			[Serialize("MenuType_InputListenerCannotBeMasked"      )] InputListenerCannotBeMasked = 258,
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
		public override uint? ClassCRC => 0xDBD29D70;
	}
}

