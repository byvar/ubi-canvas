namespace UbiArt.Animation {
	// See: ITF::AnimTrackFrameSoundEvents::serialize
	public class AnimTrackFrameSoundEvents : CSerializable {
		public StringID sid;
		public float unk0;
		public uint unk1;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sid = s.SerializeObject<StringID>(sid, name: "sid");
			unk0 = s.Serialize<float>(unk0, name: "unk0");
			unk1 = s.Serialize<uint>(unk1, name: "unk1");
		}
	}
}
