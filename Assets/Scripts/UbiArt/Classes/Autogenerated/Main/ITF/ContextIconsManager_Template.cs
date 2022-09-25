using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR | GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class ContextIconsManager_Template : TemplateObj {
		public StringID menuId;
		public CListO<ContextIconsManager_Template.ButtonName> buttonNames;
		public CArrayO<LocalisationId> lineIds;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RO || s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.VH) {
				menuId = s.SerializeObject<StringID>(menuId, name: "menuId");
				lineIds = s.SerializeObject<CArrayO<LocalisationId>>(lineIds, name: "lineIds");
				buttonNames = s.SerializeObject<CListO<ContextIconsManager_Template.ButtonName>>(buttonNames, name: "buttonNames");
			} else if (s.Settings.game == Settings.Game.COL) {
				menuId = s.SerializeObject<StringID>(menuId, name: "menuId");
			} else {
				menuId = s.SerializeObject<StringID>(menuId, name: "menuId");
				buttonNames = s.SerializeObject<CListO<ContextIconsManager_Template.ButtonName>>(buttonNames, name: "buttonNames");
			}
		}
		[Games(GameFlags.VH | GameFlags.RA)]
		public partial class ButtonName : CSerializable {
			public CArrayP<string> names;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				names = s.SerializeObject<CArrayP<string>>(names, name: "names");
			}
		}
		public override uint? ClassCRC => 0x206358DA;
	}
}

