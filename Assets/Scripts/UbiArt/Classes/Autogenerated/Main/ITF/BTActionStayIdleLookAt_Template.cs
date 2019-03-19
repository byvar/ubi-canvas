using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class BTActionStayIdleLookAt_Template : BTActionStayIdle_Template {
		[Serialize("pickableFact")] public StringID pickableFact;
		[Serialize("posFact"     )] public StringID posFact;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(pickableFact));
			SerializeField(s, nameof(posFact));
		}
		public override uint? ClassCRC => 0x2D50410F;
	}
}

