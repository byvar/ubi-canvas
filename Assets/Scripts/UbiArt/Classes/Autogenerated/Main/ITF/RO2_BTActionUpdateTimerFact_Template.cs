using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionUpdateTimerFact_Template : BTAction_Template {
		[Serialize("fact")] public StringID fact;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(fact));
		}
		public override uint? ClassCRC => 0xA15C9B6E;
	}
}

