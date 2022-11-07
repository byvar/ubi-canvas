namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class BlendTreeNodeChooseBranch<T> : BlendTreeNodeBlend<T> {
		public CListO<BlendLeaf> childData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			childData = s.SerializeObject<CListO<BlendLeaf>>(childData, name: "childData");
		}
		public override uint? ClassCRC => 0xA91EE61E;
		
		[Games(GameFlags.All)]
		public partial class BlendLeaf : CSerializable {
			public CListO<Criteria> criterias;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				criterias = s.SerializeObject<CListO<Criteria>>(criterias, name: "criterias");
			}
		}
	}
}

