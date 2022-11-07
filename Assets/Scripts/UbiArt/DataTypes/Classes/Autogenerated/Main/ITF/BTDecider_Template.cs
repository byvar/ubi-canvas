namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class BTDecider_Template : BTNode_Template {
		public CListO<BTNodeTemplate_Ref> nodes;
		public bool reevaluate;
		public CArrayO<StringID> clearFacts;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			nodes = s.SerializeObject<CListO<BTNodeTemplate_Ref>>(nodes, name: "nodes");
			clearFacts = s.SerializeObject<CArrayO<StringID>>(clearFacts, name: "clearFacts");
			reevaluate = s.Serialize<bool>(reevaluate, name: "reevaluate");
		}
		public override uint? ClassCRC => 0x1F80085C;
	}
}

