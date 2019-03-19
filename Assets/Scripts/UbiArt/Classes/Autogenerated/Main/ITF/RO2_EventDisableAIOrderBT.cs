using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_EventDisableAIOrderBT : Event {
		[Serialize("disable")] public bool disable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(disable));
		}
		public override uint? ClassCRC => 0x412CEF32;
	}
}

