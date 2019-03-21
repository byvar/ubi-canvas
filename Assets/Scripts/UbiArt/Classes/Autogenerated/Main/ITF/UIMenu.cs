using System;
using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class UIMenu : UIItem {
		[Serialize("loadResource"  )] public bool loadResource;
		[Serialize("afxDuration"   )] public float afxDuration;
		[Serialize("menuType"      )] public MenuType menuType;
		[Serialize("menuType"      )] public MenuType2 menuType2;
		[Serialize("menuType"      )] public MenuType3 menuType3;
		[Serialize("fullscreenMenu")] public bool fullscreenMenu;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(loadResource));
				SerializeField(s, nameof(menuType2));
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(loadResource));
				SerializeField(s, nameof(afxDuration));
				SerializeField(s, nameof(menuType3));
			} else {
				SerializeField(s, nameof(loadResource));
				SerializeField(s, nameof(afxDuration));
				SerializeField(s, nameof(menuType));
				SerializeField(s, nameof(fullscreenMenu));
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

