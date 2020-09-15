using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class DialogSoundDescriptorComponent_Template : ActorComponent_Template {
		public CList<DialogSoundDescriptorElement> DescriptorList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				DescriptorList = s.SerializeObject<CList<DialogSoundDescriptorElement>>(DescriptorList, name: "DescriptorList");
			}
		}
		public override uint? ClassCRC => 0xD4B2FEBB;
	}
}

