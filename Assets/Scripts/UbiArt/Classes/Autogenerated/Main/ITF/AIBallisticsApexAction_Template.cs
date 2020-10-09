using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.LegendsAndUp)]
	public partial class AIBallisticsApexAction_Template : AIBallisticsAction_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x24AE934A;
	}
}

