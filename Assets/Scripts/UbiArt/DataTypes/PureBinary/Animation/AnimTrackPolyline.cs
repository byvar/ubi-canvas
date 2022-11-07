namespace UbiArt.Animation {
	// See: ITF::AnimTrackPolyline::serialize
	public class AnimTrackPolyline : CSerializable {
		public float unk;
		public CListO<StringID> entries;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			unk = s.Serialize<float>(unk, name: "unk");
			entries = s.SerializeObject<CListO<StringID>>(entries, name: "entries");
		}
	}
}
