namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTDeciderFindTargetAttackPos_Template : BTDecider_Template {
		public StringID factTarget;
		public StringID factPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			factTarget = s.SerializeObject<StringID>(factTarget, name: "factTarget");
			factPos = s.SerializeObject<StringID>(factPos, name: "factPos");
		}
		public override uint? ClassCRC => 0xD0B345FC;
	}
}

