namespace UbiArt.Animation {
	// See: ITF::AnimTrackPolyline::serialize
	public class AnimTrackPolyline : CSerializable {
		public float frame;
		public CListO<StringID> entries;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			frame = s.Serialize<float>(frame, name: "frame");
			entries = s.SerializeObject<CListO<StringID>>(entries, name: "entries");
		}
	}
}
