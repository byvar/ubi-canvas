using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class VertexPCBT : CSerializable {
		public Vec3d pos;
		public ColorInteger color;
		public uint blendIndices;
		public Vec2d uv;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			pos = s.SerializeObject<Vec3d>(pos, name: "pos");
			color = s.SerializeObject<ColorInteger>(color, name: "color");
			blendIndices = s.Serialize<uint>(blendIndices, name: "blendIndices");
			uv = s.SerializeObject<Vec2d>(uv, name: "uv");
		}
	}
}

