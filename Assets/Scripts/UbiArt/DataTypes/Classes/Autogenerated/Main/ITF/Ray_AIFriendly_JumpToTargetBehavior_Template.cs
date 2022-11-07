namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIFriendly_JumpToTargetBehavior_Template : TemplateAIBehavior {
		public Placeholder jump;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			jump = s.SerializeObject<Placeholder>(jump, name: "jump");
		}
		public override uint? ClassCRC => 0xF1567739;
	}
}

