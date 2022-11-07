namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_BTDeciderFindTargetAttackPos_Template : BTDecider_Template {
		public StringID factTarget;
		public StringID factPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			factTarget = s.SerializeObject<StringID>(factTarget, name: "factTarget");
			factPos = s.SerializeObject<StringID>(factPos, name: "factPos");
		}
		public override uint? ClassCRC => 0x2691BE2C;
	}
}

