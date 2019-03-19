using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BTActionRangeAttack : CSerializable {
		[Serialize("detectionShape")] public Placeholder detectionShape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(detectionShape));
			}
		}
		public override uint? ClassCRC => 0x5373166E;
	}
}

