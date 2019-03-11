using UnityEngine;

namespace UbiArt.ITF {
	public partial class DialogComponent_Template : DialogBaseComponent_Template {
		[Serialize("instructionList")] public CArray<Generic<InstructionDialog>> instructionList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(instructionList));
		}
		public override uint? ClassCRC => 0x19DAB058;
	}
}

