using UnityEngine;

namespace UbiArt.ITF {
	public partial class BTDeciderHasFact_Template : BTDecider_Template {
		[Serialize("factsHave"   )] public Placeholder factsHave;
		[Serialize("factsNotHave")] public Placeholder factsNotHave;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(factsHave));
				SerializeField(s, nameof(factsNotHave));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(factsHave));
				SerializeField(s, nameof(factsNotHave));
			} else {
			}
		}
		public override uint? ClassCRC => 0x8C782467;
	}
}

