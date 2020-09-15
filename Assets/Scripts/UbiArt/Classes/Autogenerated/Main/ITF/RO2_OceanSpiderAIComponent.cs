using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_OceanSpiderAIComponent : RO2_SimpleAIComponent {
		public bool waitForTrigger;
		public uint bubblePrize;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				waitForTrigger = s.Serialize<bool>(waitForTrigger, name: "waitForTrigger");
				if (s.HasFlags(SerializeFlags.Default)) {
					if (s.HasFlags(SerializeFlags.Editor)) {
						SerializeFieldAsChoiceList(s, nameof(bubblePrize));
					} else {
						bubblePrize = s.Serialize<uint>(bubblePrize, name: "bubblePrize");
					}
				}
			} else {
				waitForTrigger = s.Serialize<bool>(waitForTrigger, name: "waitForTrigger");
				if (s.HasFlags(SerializeFlags.Default)) {
					if (s.HasFlags(SerializeFlags.Editor)) {
						SerializeFieldAsChoiceList(s, nameof(bubblePrize));
					} else {
						bubblePrize = s.Serialize<uint>(bubblePrize, name: "bubblePrize");
					}
				}
			}
		}
		public override uint? ClassCRC => 0xA46CFA6F;
	}
}

