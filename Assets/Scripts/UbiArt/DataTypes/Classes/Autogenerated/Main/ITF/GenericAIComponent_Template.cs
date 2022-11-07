namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class GenericAIComponent_Template : AIComponent_Template {
		public Generic<TemplateAIBehavior> genericBehavior;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			genericBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(genericBehavior, name: "genericBehavior");
		}
		public override uint? ClassCRC => 0xCC485AD9;
	}
}

