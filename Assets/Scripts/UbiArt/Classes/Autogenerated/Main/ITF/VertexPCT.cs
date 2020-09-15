using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class VertexPCT : CSerializable {
		public Vec3d pos;
		public ColorInteger color;
		public Vec2d uv;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			pos = s.SerializeObject<Vec3d>(pos, name: "pos");
			color = s.SerializeObject<ColorInteger>(color, name: "color");
			uv = s.SerializeObject<Vec2d>(uv, name: "uv");
		}
	}
}

