namespace UbiArt.Animation {
	// See: ITF::AnimTrackBML::serialize
	public class AnimTrackBML : CSerializable {
		public float frame;
		public CListO<Entry> entries;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			frame = s.Serialize<float>(frame, name: "frame");
			entries = s.SerializeObject<CListO<Entry>>(entries, name: "entries");
		}

		public class Entry : CSerializable {
			public StringID textureBankId;
			public StringID templateId;

			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				textureBankId = s.SerializeObject<StringID>(textureBankId, name: "textureBankId");
				templateId = s.SerializeObject<StringID>(templateId, name: "templateId");
			}
		}
		/*
		Example (from yellow_afraid_to_red_afraid.anm.ckd):
		00000000 00000004 93267C52 40B0FAC4 93267C52 4000C95C 93267C52 F6DD2736 93267C52 07A08511
		40000000 00000004 93267C52 40B0FAC4 93267C52 4000C95C 93267C52 F6DD2736 93267C52 7D85DF00
		40A00000 00000004 93267C52 40B0FAC4 93267C52 4000C95C 93267C52 F6DD2736 93267C52 07A08511
		41000000 00000004 93267C52 40B0FAC4 93267C52 4000C95C 93267C52 F6DD2736 93267C52 7D85DF00
		41100000 00000004 93267C52 7C215FF2 93267C52 546CB87B 93267C52 CA574892 93267C52 7C1129DA
		41300000 00000004 93267C52 7C215FF2 93267C52 546CB87B 93267C52 CA574892 93267C52 99CB2DF4
		41600000 00000004 93267C52 7C215FF2 93267C52 546CB87B 93267C52 CA574892 93267C52 7C1129DA
		41880000 00000004 93267C52 7C215FF2 93267C52 546CB87B 93267C52 CA574892 93267C52 99CB2DF4
		*/
	}
}
