using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIPerformHitPunchAction_Template : Ray_AIPerformHitAction_Template {
		public Generic<PhysShape> shape;
		public Vec2d shapeOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			shape = s.SerializeObject<Generic<PhysShape>>(shape, name: "shape");
			shapeOffset = s.SerializeObject<Vec2d>(shapeOffset, name: "shapeOffset");
		}
		public override uint? ClassCRC => 0x828DF883;
	}
}

