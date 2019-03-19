using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_Mission_Guard_Enemy_CheckAIFact : RLC_Mission_Guard {
		[Serialize("AIFact")] public StringID AIFact;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(AIFact));
		}
		public override uint? ClassCRC => 0x2D0A7A35;
	}
}

