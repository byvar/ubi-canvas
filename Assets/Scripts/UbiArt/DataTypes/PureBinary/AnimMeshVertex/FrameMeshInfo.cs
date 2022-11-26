namespace UbiArt.Animation {
	// See: ITF::FrameMeshInfo::serialize
	public class FrameMeshInfo : CSerializable {
		public uint frame;
		public uint mesh;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			frame = s.Serialize<uint>(frame, name: "frame");
			mesh = s.Serialize<uint>(mesh, name: "mesh");
		}
	}
}
