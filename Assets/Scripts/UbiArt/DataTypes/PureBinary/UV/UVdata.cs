namespace UbiArt.UV {
	public class UVdata : CSerializable {
		public CArrayO<Vec2d> uvs;
		public Vec2d uv0;
		public Vec2d uv1;

		protected override void SerializeImpl(CSerializerObject s) {
			if (s.Settings.engineVersion == Settings.EngineVersion.RO) {
				uv0 = s.SerializeObject<Vec2d>(uv0, name: "uv0");
				uv1 = s.SerializeObject<Vec2d>(uv1, name: "uv1");
			} else {
				uvs = s.SerializeObject<CArrayO<Vec2d>>(uvs, name: "uvs");
			}
		}
	}
}
