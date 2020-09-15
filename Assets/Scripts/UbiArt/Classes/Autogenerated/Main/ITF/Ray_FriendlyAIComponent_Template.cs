using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_FriendlyAIComponent_Template : Ray_GroundAIComponent_Template {
		public Placeholder waitBehavior;
		public Placeholder triggerBehavior;
		public Placeholder exitBehavior;
		public Placeholder pedestalBehavior;
		public Placeholder jumpBehavior;
		public Placeholder gotoBehavior;
		public Placeholder followBehavior;
		public Placeholder danceBehavior;
		public float followDetectDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			waitBehavior = s.SerializeObject<Placeholder>(waitBehavior, name: "waitBehavior");
			triggerBehavior = s.SerializeObject<Placeholder>(triggerBehavior, name: "triggerBehavior");
			exitBehavior = s.SerializeObject<Placeholder>(exitBehavior, name: "exitBehavior");
			pedestalBehavior = s.SerializeObject<Placeholder>(pedestalBehavior, name: "pedestalBehavior");
			jumpBehavior = s.SerializeObject<Placeholder>(jumpBehavior, name: "jumpBehavior");
			gotoBehavior = s.SerializeObject<Placeholder>(gotoBehavior, name: "gotoBehavior");
			followBehavior = s.SerializeObject<Placeholder>(followBehavior, name: "followBehavior");
			danceBehavior = s.SerializeObject<Placeholder>(danceBehavior, name: "danceBehavior");
			followDetectDistance = s.Serialize<float>(followDetectDistance, name: "followDetectDistance");
		}
		public override uint? ClassCRC => 0x246AC14F;
	}
}

