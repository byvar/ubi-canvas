using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class BlendTreeNodeChooseBranch_Template<T> : BlendTreeNodeBlend_Template<T> {
		public float blendTime;
		public uint startingLeaf;
		public CListO<BlendLeaf> leafsCriterias;
		public bool noUpdateInactive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			blendTime = s.Serialize<float>(blendTime, name: "blendTime");
			startingLeaf = s.Serialize<uint>(startingLeaf, name: "startingLeaf");
			leafsCriterias = s.SerializeObject<CListO<BlendLeaf>>(leafsCriterias, name: "leafsCriterias");
			noUpdateInactive = s.Serialize<bool>(noUpdateInactive, name: "noUpdateInactive");
		}
		public override uint? ClassCRC => 0x9627D8B1;

		[Games(GameFlags.All)]
		public partial class BlendLeaf : CSerializable {
			public CListO<CriteriaDesc> criterias;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				criterias = s.SerializeObject<CListO<CriteriaDesc>>(criterias, name: "criterias");
			}
		}
	}
}

