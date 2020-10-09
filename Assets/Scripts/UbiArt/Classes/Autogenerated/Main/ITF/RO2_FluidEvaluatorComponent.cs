using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.VH | GameFlags.RA)]
	public partial class RO2_FluidEvaluatorComponent : ActorComponent {
		public EditableShape shape;
		public uint BottomRowOffset;
		public uint CellNbToValidateRow;
		public float BlendCoeff;
		public float CellPercentValidation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				shape = s.SerializeObject<EditableShape>(shape, name: "shape");
				BottomRowOffset = s.Serialize<uint>(BottomRowOffset, name: "BottomRowOffset");
				CellNbToValidateRow = s.Serialize<uint>(CellNbToValidateRow, name: "CellNbToValidateRow");
				BlendCoeff = s.Serialize<float>(BlendCoeff, name: "BlendCoeff");
				CellPercentValidation = s.Serialize<float>(CellPercentValidation, name: "CellPercentValidation");
			}
		}
		public override uint? ClassCRC => 0x5A86CDC6;
	}
}

