using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BTActionAlerted : CSerializable {
		[Serialize("detectionShape")] public Placeholder detectionShape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(detectionShape));
		}
		public override uint? ClassCRC => 0xFF483937;
	}
}

