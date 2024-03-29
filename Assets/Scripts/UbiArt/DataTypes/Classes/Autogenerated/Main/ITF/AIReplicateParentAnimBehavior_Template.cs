namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class AIReplicateParentAnimBehavior_Template : TemplateAIBehavior {
		public bool useParentBind;
		public StringID defaultAnim;
		public CListO<StringID> animsToAvoid;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			useParentBind = s.Serialize<bool>(useParentBind, name: "useParentBind");
			defaultAnim = s.SerializeObject<StringID>(defaultAnim, name: "defaultAnim");
			animsToAvoid = s.SerializeObject<CListO<StringID>>(animsToAvoid, name: "animsToAvoid");
		}
		public override uint? ClassCRC => 0x445E5733;
	}
}

