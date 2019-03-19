using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_PauseMenu_Template : CSerializable {
		[Serialize("skillPtsCountOffsetX")] public float skillPtsCountOffsetX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(skillPtsCountOffsetX));
		}
		public override uint? ClassCRC => 0x4D11593D;
	}
}

