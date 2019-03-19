using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class BlendTreeNodeBlendBranches<T> : BlendTreeNodeBlend<T> {
		[Serialize("leafData")] public CList<BlendLeaf> leafData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(leafData));
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

