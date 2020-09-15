using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIStoneManAttackBehavior_Template : TemplateAIBehavior {
		public Placeholder respawnBoulder;
		public Placeholder idle;
		public Placeholder anticipation;
		public Placeholder sleep;
		public Placeholder wakeUp;
		public Placeholder launchActions;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			respawnBoulder = s.SerializeObject<Placeholder>(respawnBoulder, name: "respawnBoulder");
			idle = s.SerializeObject<Placeholder>(idle, name: "idle");
			anticipation = s.SerializeObject<Placeholder>(anticipation, name: "anticipation");
			sleep = s.SerializeObject<Placeholder>(sleep, name: "sleep");
			wakeUp = s.SerializeObject<Placeholder>(wakeUp, name: "wakeUp");
			launchActions = s.SerializeObject<Placeholder>(launchActions, name: "launchActions");
		}
		public override uint? ClassCRC => 0x8DE04F71;
	}
}

