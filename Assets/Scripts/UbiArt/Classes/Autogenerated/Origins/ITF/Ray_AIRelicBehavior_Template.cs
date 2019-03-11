using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIRelicBehavior_Template : BlendTreeNodeTemplate<Q23ITF14AnimTreeResult> {
		[Serialize("relicIndex")] public bool relicIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(relicIndex));
		}
		public override uint? ClassCRC => 0x8F5D37B9;
	}
}

