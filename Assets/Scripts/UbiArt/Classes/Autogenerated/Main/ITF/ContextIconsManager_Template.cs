using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class ContextIconsManager_Template : TemplateObj {
		public StringID menuId;
		public CListO<ContextIconsManager_Template.ButtonName> buttonNames;
		public CArrayO<LocalisationId> lineIds;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH) {
				menuId = s.SerializeObject<StringID>(menuId, name: "menuId");
				lineIds = s.SerializeObject<CArrayO<LocalisationId>>(lineIds, name: "lineIds");
				buttonNames = s.SerializeObject<CListO<ContextIconsManager_Template.ButtonName>>(buttonNames, name: "buttonNames");
			} else if (Settings.s.game == Settings.Game.COL) {
				menuId = s.SerializeObject<StringID>(menuId, name: "menuId");
			} else {
				menuId = s.SerializeObject<StringID>(menuId, name: "menuId");
				buttonNames = s.SerializeObject<CListO<ContextIconsManager_Template.ButtonName>>(buttonNames, name: "buttonNames");
			}
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class ButtonName : CSerializable {
			public CArrayP<string> names;
			public CArrayP<string> CArray_string__0;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				if (Settings.s.game == Settings.Game.VH) {
					CArray_string__0 = s.SerializeObject<CArrayP<string>>(CArray_string__0, name: "CArray_string__0");
				} else {
					names = s.SerializeObject<CArrayP<string>>(names, name: "names");
					names = s.SerializeObject<CArrayP<string>>(names, name: "names");
				}
			}
		}
		public override uint? ClassCRC => 0x206358DA;
	}
}

