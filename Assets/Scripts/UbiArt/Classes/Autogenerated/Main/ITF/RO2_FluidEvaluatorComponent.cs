using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_FluidEvaluatorComponent : ActorComponent {
		[Serialize("shape"                )] public EditableShape shape;
		[Serialize("BottomRowOffset"      )] public uint BottomRowOffset;
		[Serialize("CellNbToValidateRow"  )] public uint CellNbToValidateRow;
		[Serialize("BlendCoeff"           )] public float BlendCoeff;
		[Serialize("CellPercentValidation")] public float CellPercentValidation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(shape));
				SerializeField(s, nameof(BottomRowOffset));
				SerializeField(s, nameof(CellNbToValidateRow));
				SerializeField(s, nameof(BlendCoeff));
				SerializeField(s, nameof(CellPercentValidation));
			}
		}
		public override uint? ClassCRC => 0x5A86CDC6;
	}
}

