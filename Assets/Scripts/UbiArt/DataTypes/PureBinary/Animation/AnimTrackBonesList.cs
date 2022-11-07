namespace UbiArt.Animation {
	// See: ITF::AnimTrackBonesList::serialize
	public class AnimTrackBonesList : CSerializable {
		public ushort startPAS;
		public ushort amountPAS;
		public ushort startZAL;
		public ushort amountZAL;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			startPAS = s.Serialize<ushort>(startPAS, name: "startPAS");
			amountPAS = s.Serialize<ushort>(amountPAS, name: "amountPAS");
			startZAL = s.Serialize<ushort>(startZAL, name: "startZAL");
			amountZAL = s.Serialize<ushort>(amountZAL, name: "amountZAL");
		}
	}
}
