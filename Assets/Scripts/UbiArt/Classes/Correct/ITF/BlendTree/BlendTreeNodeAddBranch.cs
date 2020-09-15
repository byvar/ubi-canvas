using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class BlendTreeNodeAddBranch<T> : BlendTreeNodeBlend<T> {
		public CArray<float> prevWeights;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			prevWeights = s.SerializeObject<CArray<float>>(prevWeights, name: "prevWeights");
		}
		public override uint? ClassCRC => 0x9CBF6243;
	}
}

