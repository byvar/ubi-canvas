using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIPerformHitPunchAction_Template : Ray_AIPerformHitAction_Template {
		[Serialize("shape"      )] public Placeholder shape;
		[Serialize("shapeOffset")] public Vector2 shapeOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(shape));
			SerializeField(s, nameof(shapeOffset));
		}
		public override uint? ClassCRC => 0x828DF883;
	}
}

