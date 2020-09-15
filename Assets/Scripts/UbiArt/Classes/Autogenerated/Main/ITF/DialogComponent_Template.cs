using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class DialogComponent_Template : DialogBaseComponent_Template {
		public CArray<Generic<InstructionDialog>> instructionList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				instructionList = s.SerializeObject<CArray<Generic<InstructionDialog>>>(instructionList, name: "instructionList");
			}
		}
		public override uint? ClassCRC => 0x19DAB058;
	}
}

