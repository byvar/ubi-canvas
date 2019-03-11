using UnityEngine;

namespace UbiArt.ITF {
	public partial class ContextIconsManager_Template : TemplateObj {
		[Serialize("menuId"     )] public StringID menuId;
		[Serialize("buttonNames")] public CList<ContextIconsManager_Template.ButtonName> buttonNames;
		[Serialize("lineIds"    )] public Placeholder lineIds;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(menuId));
				SerializeField(s, nameof(lineIds));
				SerializeField(s, nameof(buttonNames));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(menuId));
				SerializeField(s, nameof(lineIds));
				SerializeField(s, nameof(buttonNames));
			} else {
				SerializeField(s, nameof(menuId));
				SerializeField(s, nameof(buttonNames));
			}
		}
		public partial class ButtonName : CSerializable {
			[Serialize("names")] public CArray<string> names;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(names));
			}
		}
		public override uint? ClassCRC => 0x206358DA;
	}
}

