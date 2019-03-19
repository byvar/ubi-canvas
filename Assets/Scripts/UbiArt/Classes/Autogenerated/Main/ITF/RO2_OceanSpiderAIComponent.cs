using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_OceanSpiderAIComponent : RO2_SimpleAIComponent {
		[Serialize("waitForTrigger")] public bool waitForTrigger;
		[Serialize("bubblePrize"   )] public Enum_bubblePrize bubblePrize;
		[Serialize("bubblePrize"   )] public uint bubblePrize;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(waitForTrigger));
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(bubblePrize));
					SerializeField(s, nameof(bubblePrize));
				}
			} else {
				SerializeField(s, nameof(waitForTrigger));
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(bubblePrize));
					SerializeField(s, nameof(bubblePrize));
				}
			}
		}
		public enum Enum_bubblePrize {
		}
		public enum Enum_bubblePrize {
			[Serialize("Value_v8")] Value_v8 = v8,
		}
		public override uint? ClassCRC => 0xA46CFA6F;
	}
}

