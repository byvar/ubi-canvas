using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class BlendTreeNodeAddBranch<T> : BlendTreeNodeBlend<T> {
		[Serialize("prevWeights"     )] public CArray<float> prevWeights;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(prevWeights));
		}
		public override uint? ClassCRC => 0x9CBF6243;
	}
}

