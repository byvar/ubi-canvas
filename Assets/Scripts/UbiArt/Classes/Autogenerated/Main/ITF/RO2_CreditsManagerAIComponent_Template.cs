using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_CreditsManagerAIComponent_Template : ActorComponent_Template {
		public CListO<CreditsLine> creditsList;
		public Path gmatPath;
		public bool isTriggered;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			creditsList = s.SerializeObject<CListO<CreditsLine>>(creditsList, name: "creditsList");
			gmatPath = s.SerializeObject<Path>(gmatPath, name: "gmatPath");
			isTriggered = s.Serialize<bool>(isTriggered, name: "isTriggered");
		}
		public override uint? ClassCRC => 0xB0A62194;
	}
}

