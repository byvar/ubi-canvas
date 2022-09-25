using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class DialogComponent_Template : DialogBaseComponent_Template {
		public CArrayO<Generic<InstructionDialog>> instructionList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.COL) {
			} else {
				instructionList = s.SerializeObject<CArrayO<Generic<InstructionDialog>>>(instructionList, name: "instructionList");
			}
		}
		public override uint? ClassCRC => 0x19DAB058;
	}
}

