using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIPerformHitPunchAction_Template : Ray_AIPerformHitAction_Template {
		[Serialize("shape"      )] public Generic<PhysShape> shape;
		[Serialize("shapeOffset")] public Vec2d shapeOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(shape));
			SerializeField(s, nameof(shapeOffset));
		}
		public override uint? ClassCRC => 0x828DF883;
	}
}

