using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_Mission_Guard_Enemy_CheckAIFact : RLC_Mission_Guard {
		public StringID AIFact;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			AIFact = s.SerializeObject<StringID>(AIFact, name: "AIFact");
		}
		public override uint? ClassCRC => 0x2D0A7A35;
	}
}

