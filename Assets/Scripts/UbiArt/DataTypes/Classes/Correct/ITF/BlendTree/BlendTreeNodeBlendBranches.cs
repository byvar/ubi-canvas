using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class BlendTreeNodeBlendBranches<T> : BlendTreeNodeBlend<T> {
		public CListO<BlendLeaf> leafData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			leafData = s.SerializeObject<CListO<BlendLeaf>>(leafData, name: "leafData");
		}
		public override uint? ClassCRC => 0x26E3AEE1;

		[Games(GameFlags.All)]
		public partial class BlendLeaf : CSerializable {
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
			}
		}
	}
}

