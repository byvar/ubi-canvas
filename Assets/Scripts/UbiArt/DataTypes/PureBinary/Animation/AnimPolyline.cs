namespace UbiArt.Animation {
	// See: ITF::AnimPolyline::serialize
	public class AnimPolyline : CSerializable {
		public CListO<AnimPolylinePoint> points;
		public KeyArray<int> keys;
		public StringID name;
		public bool loop;
		public uint unk2;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			points = s.SerializeObject<CListO<AnimPolylinePoint>>(points, name: "points");
			keys = s.SerializeObject<KeyArray<int>>(keys, name: "keys");
			name = s.SerializeObject<StringID>(name, name: "name");
			loop = s.Serialize<bool>(loop, name: "loop");
			unk2 = s.Serialize<uint>(unk2, name: "unk2");
		}
	}
}
