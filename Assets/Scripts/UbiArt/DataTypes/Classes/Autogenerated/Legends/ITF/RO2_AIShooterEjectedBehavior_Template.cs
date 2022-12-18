namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_AIShooterEjectedBehavior_Template : TemplateAIBehavior {
		public Generic<AIAction_Template> ejectAction;
		public int destroyOnEjectActionsEnd;
		public int killOnEnd;
		public uint hitNumber;
		public StringID hitNumberNextBhvName;
		public StringID ejectActionNextBhvName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ejectAction = s.SerializeObject<Generic<AIAction_Template>>(ejectAction, name: "ejectAction");
			destroyOnEjectActionsEnd = s.Serialize<int>(destroyOnEjectActionsEnd, name: "destroyOnEjectActionsEnd");
			killOnEnd = s.Serialize<int>(killOnEnd, name: "killOnEnd");
			hitNumber = s.Serialize<uint>(hitNumber, name: "hitNumber");
			hitNumberNextBhvName = s.SerializeObject<StringID>(hitNumberNextBhvName, name: "hitNumberNextBhvName");
			ejectActionNextBhvName = s.SerializeObject<StringID>(ejectActionNextBhvName, name: "ejectActionNextBhvName");
		}
		public override uint? ClassCRC => 0xFA11E863;
	}
}

