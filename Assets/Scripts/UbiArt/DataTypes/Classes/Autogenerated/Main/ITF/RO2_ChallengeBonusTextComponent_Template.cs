namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_ChallengeBonusTextComponent_Template : ActorComponent_Template {
		public StringID rulesAnim;
		public StringID rulesHideAnim;
		public StringID looseAnim;
		public StringID winAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			rulesAnim = s.SerializeObject<StringID>(rulesAnim, name: "rulesAnim");
			rulesHideAnim = s.SerializeObject<StringID>(rulesHideAnim, name: "rulesHideAnim");
			looseAnim = s.SerializeObject<StringID>(looseAnim, name: "looseAnim");
			winAnim = s.SerializeObject<StringID>(winAnim, name: "winAnim");
		}
		public override uint? ClassCRC => 0xA5BF10DA;
	}
}

