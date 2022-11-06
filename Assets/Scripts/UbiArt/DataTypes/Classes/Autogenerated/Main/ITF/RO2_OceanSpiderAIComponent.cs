using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_OceanSpiderAIComponent : RO2_SimpleAIComponent {
		public bool waitForTrigger;
		public uint bubblePrize;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			waitForTrigger = s.Serialize<bool>(waitForTrigger, name: "waitForTrigger");
			if (s.HasFlags(SerializeFlags.Default)) {
				if (s.HasFlags(SerializeFlags.Editor)) {
					bubblePrize = s.SerializeChoiceList<uint>(bubblePrize, name: "bubblePrize");
				} else {
					bubblePrize = s.Serialize<uint>(bubblePrize, name: "bubblePrize");
				}
			}
		}
		public override uint? ClassCRC => 0xA46CFA6F;
	}
}

