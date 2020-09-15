using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_StargateComponent_Template : ActorComponent_Template {
		public Generic<PhysShape> detectShape;
		public Generic<PhysShape> pressUpShape;
		public Path flashFX;
		public Path flashFXStart;
		public Vec3d flashOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			detectShape = s.SerializeObject<Generic<PhysShape>>(detectShape, name: "detectShape");
			pressUpShape = s.SerializeObject<Generic<PhysShape>>(pressUpShape, name: "pressUpShape");
			flashFX = s.SerializeObject<Path>(flashFX, name: "flashFX");
			flashFXStart = s.SerializeObject<Path>(flashFXStart, name: "flashFXStart");
			flashOffset = s.SerializeObject<Vec3d>(flashOffset, name: "flashOffset");
		}
		public override uint? ClassCRC => 0x59B9970A;
	}
}

