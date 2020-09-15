using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class BlendTreeNodeChooseBranch<T> : BlendTreeNodeBlend<T> {
		public CList<BlendLeaf> childData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			childData = s.SerializeObject<CList<BlendLeaf>>(childData, name: "childData");
		}
		public override uint? ClassCRC => 0xA91EE61E;
		
		[Games(GameFlags.All)]
		public partial class BlendLeaf : CSerializable {
			public CList<Criteria> criterias;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				criterias = s.SerializeObject<CList<Criteria>>(criterias, name: "criterias");
			}
		}
	}
}

