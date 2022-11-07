namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class VertexPNC3T : CSerializable {
		public Vec3d pos;
		public ColorInteger color;
		public Vec2d uv1;
		public GFX_Vector4 uv2;
		public GFX_Vector4 uv3;
		public Vec2d uv4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			pos = s.SerializeObject<Vec3d>(pos, name: "pos");
			color = s.SerializeObject<ColorInteger>(color, name: "color");
			uv1 = s.SerializeObject<Vec2d>(uv1, name: "uv1");
			uv2 = s.SerializeObject<GFX_Vector4>(uv2, name: "uv2");
			uv3 = s.SerializeObject<GFX_Vector4>(uv3, name: "uv3");
			uv4 = s.SerializeObject<Vec2d>(uv4, name: "uv4");
		}
	}
}

