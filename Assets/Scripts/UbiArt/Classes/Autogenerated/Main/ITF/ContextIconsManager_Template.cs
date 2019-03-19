using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class ContextIconsManager_Template : TemplateObj {
		[Serialize("menuId"     )] public StringID menuId;
		[Serialize("buttonNames")] public CList<ContextIconsManager_Template.ButtonName> buttonNames;
		[Serialize("lineIds"    )] public CArray<LocalisationId> lineIds;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(menuId));
				SerializeField(s, nameof(lineIds));
				SerializeField(s, nameof(buttonNames));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(menuId));
			} else {
				SerializeField(s, nameof(menuId));
				SerializeField(s, nameof(buttonNames));
			}
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class ButtonName : CSerializable {
			[Serialize("names"            )] public CArray<string> names;
			[Serialize("CArray<string>__0")] public CArray<string> CArray_string__0;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				if (Settings.s.game == Settings.Game.VH) {
					SerializeField(s, nameof(CArray_string__0));
				} else {
					SerializeField(s, nameof(names));
					SerializeField(s, nameof(names));
				}
			}
		}
		public override uint? ClassCRC => 0x206358DA;
	}
}

