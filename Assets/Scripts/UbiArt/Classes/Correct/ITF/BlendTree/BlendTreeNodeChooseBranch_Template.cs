using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class BlendTreeNodeChooseBranch_Template<T> : BlendTreeNodeBlend_Template<T> {
		[Serialize("blendTime"        )] public float blendTime;
		[Serialize("startingLeaf"     )] public uint startingLeaf;
		[Serialize("leafsCriterias"   )] public CList<BlendLeaf> leafsCriterias;
		[Serialize("noUpdateInactive" )] public bool noUpdateInactive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(blendTime));
			SerializeField(s, nameof(startingLeaf));
			SerializeField(s, nameof(leafsCriterias));
			SerializeField(s, nameof(noUpdateInactive));
		}
		public override uint? ClassCRC => 0x9627D8B1;

		[Games(GameFlags.All)]
		public partial class BlendLeaf : CSerializable {
			[Serialize("criterias")] public CList<CriteriaDesc> criterias;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(criterias));
			}
		}
	}
}

