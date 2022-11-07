namespace UbiArt.Localisation {
	// See: ITF::LocAudio::serialize
	public class LocAudio : CSerializable {
		public uint unk;
		public string text;
		public byte unk0;
		public byte unk1;
		public byte unk2;
		public byte unk3;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			unk = s.Serialize<uint>(unk, name: "unk");
			text = s.Serialize<string>(text, name: "text");
			unk0 = s.Serialize<byte>(unk0, name: "unk0");
			unk1 = s.Serialize<byte>(unk1, name: "unk1");
			unk2 = s.Serialize<byte>(unk2, name: "unk2");
			unk3 = s.Serialize<byte>(unk3, name: "unk3");
		}
	}
}
