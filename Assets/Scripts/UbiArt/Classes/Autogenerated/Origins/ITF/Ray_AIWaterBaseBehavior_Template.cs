using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIWaterBaseBehavior_Template : BlendTreeNodeTemplate<Q23ITF14AnimTreeResult> {
		[Serialize("gravityMultiplier")] public float gravityMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(gravityMultiplier));
		}
		public override uint? ClassCRC => 0xB6B5A38A;
	}
}

