namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class BTNodeTemplate_Ref : CSerializable {
		public StringID nameId;
		public Generic<BTNode_Template> node;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			nameId = s.SerializeObject<StringID>(nameId, name: "nameId");
			node = s.SerializeObject<Generic<BTNode_Template>>(node, name: "node");
		}
	}
}

