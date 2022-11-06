using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_JalapenoKingAiComponent_Template : AIComponent_Template {
		public Generic<Event> deathReward;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			deathReward = s.SerializeObject<Generic<Event>>(deathReward, name: "deathReward");
		}
		public override uint? ClassCRC => 0x182D7E15;
	}
}

