using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class UIMenuPageSoundConfig : CSerializable {
		[Serialize("pageName"       )] public StringID pageName;
		[Serialize("actionSoundList")] public CList<UIMenuActionSound> actionSoundList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(pageName));
			SerializeField(s, nameof(actionSoundList));
		}
	}
}

