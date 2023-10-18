namespace UbiArt.Animation {
	// See: ITF::FrameMeshInfo::serialize
	public class FrameMeshInfo : CSerializable {
		public uint patchIndex;
		public uint patchesCount;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			patchIndex = s.Serialize<uint>(patchIndex, name: "patchIndex");
			patchesCount = s.Serialize<uint>(patchesCount, name: "patchesCount");
		}
	}
}
