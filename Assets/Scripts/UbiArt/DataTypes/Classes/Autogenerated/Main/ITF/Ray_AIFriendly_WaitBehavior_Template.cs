namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIFriendly_WaitBehavior_Template : TemplateAIBehavior {
		public Placeholder idle;
		public Placeholder randomAction;
		public int triggerTarget;
		public float randomActionDelayMin;
		public float randomActionDelayMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			idle = s.SerializeObject<Placeholder>(idle, name: "idle");
			randomAction = s.SerializeObject<Placeholder>(randomAction, name: "randomAction");
			triggerTarget = s.Serialize<int>(triggerTarget, name: "triggerTarget");
			randomActionDelayMin = s.Serialize<float>(randomActionDelayMin, name: "randomActionDelayMin");
			randomActionDelayMax = s.Serialize<float>(randomActionDelayMax, name: "randomActionDelayMax");
		}
		public override uint? ClassCRC => 0xF99358B5;
	}
}

