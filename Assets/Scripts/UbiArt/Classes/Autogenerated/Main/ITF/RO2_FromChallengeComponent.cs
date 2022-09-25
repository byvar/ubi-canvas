using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_FromChallengeComponent : ActorComponent {
		public CListP<string> filter;
		public CListO<CListP<string>> filterOrder;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				filter = s.SerializeObject<CListP<string>>(filter, name: "filter");
				filterOrder = s.SerializeObject<CListO<CListP<string>>>(filterOrder, name: "filterOrder");
			} else {
				filter = s.SerializeObject<CListP<string>>(filter, name: "filter");
			}
		}
		public override uint? ClassCRC => 0xDB452847;
	}
}

