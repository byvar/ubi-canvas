using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_FromChallengeComponent : ActorComponent {
		public CList<string> filter;
		public CList<CList<string>> filterOrder;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				filter = s.SerializeObject<CList<string>>(filter, name: "filter");
				filterOrder = s.SerializeObject<CList<CList<string>>>(filterOrder, name: "filterOrder");
			} else {
				filter = s.SerializeObject<CList<string>>(filter, name: "filter");
			}
		}
		public override uint? ClassCRC => 0xDB452847;
	}
}

