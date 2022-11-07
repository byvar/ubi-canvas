namespace UbiArt.Animation {
	// See: ITF::AnimPolylineBank::serialize
	public class AnimPolylineBank : CSerializable {
		public CListO<AnimPolyline> polylines;
		public KeyArray<int> keys;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			polylines = s.SerializeObject<CListO<AnimPolyline>>(polylines, name: "polylines");
			keys = s.SerializeObject<KeyArray<int>>(keys, name: "keys");
		}
	}
}
