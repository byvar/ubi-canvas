using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class ContextIconsManager_Template : TemplateObj {
		public StringID menuId;
		public CList<ContextIconsManager_Template.ButtonName> buttonNames;
		public CArray<LocalisationId> lineIds;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH) {
				menuId = s.SerializeObject<StringID>(menuId, name: "menuId");
				lineIds = s.SerializeObject<CArray<LocalisationId>>(lineIds, name: "lineIds");
				buttonNames = s.SerializeObject<CList<ContextIconsManager_Template.ButtonName>>(buttonNames, name: "buttonNames");
			} else if (Settings.s.game == Settings.Game.COL) {
				menuId = s.SerializeObject<StringID>(menuId, name: "menuId");
			} else {
				menuId = s.SerializeObject<StringID>(menuId, name: "menuId");
				buttonNames = s.SerializeObject<CList<ContextIconsManager_Template.ButtonName>>(buttonNames, name: "buttonNames");
			}
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class ButtonName : CSerializable {
			public CArray<string> names;
			public CArray<string> CArray_string__0;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				if (Settings.s.game == Settings.Game.VH) {
					CArray_string__0 = s.SerializeObject<CArray<string>>(CArray_string__0, name: "CArray_string__0");
				} else {
					names = s.SerializeObject<CArray<string>>(names, name: "names");
					names = s.SerializeObject<CArray<string>>(names, name: "names");
				}
			}
		}
		public override uint? ClassCRC => 0x206358DA;
	}
}

