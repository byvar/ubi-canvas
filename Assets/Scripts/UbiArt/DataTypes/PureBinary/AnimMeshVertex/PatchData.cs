namespace UbiArt.Animation {
	// See: ITF::PatchData::serialize
	public class PatchData : CSerializable {
		public ushort frame;
		public ushort mesh;
		public Vec2d[] points = new Vec2d[4];

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			frame = s.Serialize<ushort>(frame, name: "frame");
			mesh = s.Serialize<ushort>(mesh, name: "mesh");
			for (int i = 0; i < points.Length; i++) {
				points[i] = s.SerializeObject<Vec2d>(points[i], name: $"points[{i}]");
			}
		}
	}
}
