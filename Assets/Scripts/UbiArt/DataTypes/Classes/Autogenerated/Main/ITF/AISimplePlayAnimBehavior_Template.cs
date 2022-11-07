namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class AISimplePlayAnimBehavior_Template : TemplateAIBehavior {
		public Generic<AIPlayAnimAction_Template> playAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			playAnim = s.SerializeObject<Generic<AIPlayAnimAction_Template>>(playAnim, name: "playAnim");
		}
		public override uint? ClassCRC => 0xE1DF1C45;
	}
}

