namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_AISleepBehavior_Template : TemplateAIBehavior {
		public Generic<AIAction_Template> idle;
		public Generic<AIAction_Template> wakeUp;
		public bool deactivatePhysics;
		public bool wakeUpOnTrigger;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			idle = s.SerializeObject<Generic<AIAction_Template>>(idle, name: "idle");
			wakeUp = s.SerializeObject<Generic<AIAction_Template>>(wakeUp, name: "wakeUp");
			deactivatePhysics = s.Serialize<bool>(deactivatePhysics, name: "deactivatePhysics");
			wakeUpOnTrigger = s.Serialize<bool>(wakeUpOnTrigger, name: "wakeUpOnTrigger");
		}
		public override uint? ClassCRC => 0xD6B8A43F;
	}
}

