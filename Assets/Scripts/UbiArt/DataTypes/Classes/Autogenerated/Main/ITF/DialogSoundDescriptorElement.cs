namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class DialogSoundDescriptorElement : CSerializable {
		public uint Mood;
		public StringID SoundDescriptor;
		public float Repeat = 1f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Mood = s.Serialize<uint>(Mood, name: "Mood");
			SoundDescriptor = s.SerializeObject<StringID>(SoundDescriptor, name: "SoundDescriptor");
			Repeat = s.Serialize<float>(Repeat, name: "Repeat");
		}
	}
}

