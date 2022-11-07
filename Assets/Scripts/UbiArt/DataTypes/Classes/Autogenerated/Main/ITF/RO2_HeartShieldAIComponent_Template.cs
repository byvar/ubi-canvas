namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_HeartShieldAIComponent_Template : RO2_SimpleAIComponent_Template {
		public Generic<TemplateAIBehavior> appearBehavior;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			appearBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(appearBehavior, name: "appearBehavior");
		}
		public override uint? ClassCRC => 0xAE0697CD;
	}
}

