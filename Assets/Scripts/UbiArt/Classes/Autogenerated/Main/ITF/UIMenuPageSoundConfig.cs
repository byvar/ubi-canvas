using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class UIMenuPageSoundConfig : CSerializable {
		public StringID pageName;
		public CList<UIMenuActionSound> actionSoundList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			pageName = s.SerializeObject<StringID>(pageName, name: "pageName");
			actionSoundList = s.SerializeObject<CList<UIMenuActionSound>>(actionSoundList, name: "actionSoundList");
		}
	}
}

