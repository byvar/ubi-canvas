using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_OceanSpiderAIComponent : RO2_SimpleAIComponent {
		[Serialize("waitForTrigger")] public bool waitForTrigger;
		[Serialize("bubblePrize"   )] public uint bubblePrize;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(waitForTrigger));
				if (s.HasFlags(SerializeFlags.Default)) {
					if (s.HasFlags(SerializeFlags.Editor)) {
						SerializeFieldAsChoiceList(s, nameof(bubblePrize));
					} else {
						SerializeField(s, nameof(bubblePrize));
					}
				}
			} else {
				SerializeField(s, nameof(waitForTrigger));
				if (s.HasFlags(SerializeFlags.Default)) {
					if (s.HasFlags(SerializeFlags.Editor)) {
						SerializeFieldAsChoiceList(s, nameof(bubblePrize));
					} else {
						SerializeField(s, nameof(bubblePrize));
					}
				}
			}
		}
		public override uint? ClassCRC => 0xA46CFA6F;
	}
}

