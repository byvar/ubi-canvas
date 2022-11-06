using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class DialogSoundDescriptorComponent_Template : ActorComponent_Template {
		public CListO<DialogSoundDescriptorElement> DescriptorList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.COL) {
			} else {
				DescriptorList = s.SerializeObject<CListO<DialogSoundDescriptorElement>>(DescriptorList, name: "DescriptorList");
			}
		}
		public override uint? ClassCRC => 0xD4B2FEBB;
	}
}

