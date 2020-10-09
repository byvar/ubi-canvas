using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_AISleepBehavior_Template : TemplateAIBehavior {
		public Generic<AIAction_Template> idle;
		public Generic<AIAction_Template> wakeUp;
		public int deactivatePhysics;
		public int wakeUpOnTrigger;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			idle = s.SerializeObject<Generic<AIAction_Template>>(idle, name: "idle");
			wakeUp = s.SerializeObject<Generic<AIAction_Template>>(wakeUp, name: "wakeUp");
			deactivatePhysics = s.Serialize<int>(deactivatePhysics, name: "deactivatePhysics");
			wakeUpOnTrigger = s.Serialize<int>(wakeUpOnTrigger, name: "wakeUpOnTrigger");
		}
		public override uint? ClassCRC => 0xD9DEB640;
	}
}

