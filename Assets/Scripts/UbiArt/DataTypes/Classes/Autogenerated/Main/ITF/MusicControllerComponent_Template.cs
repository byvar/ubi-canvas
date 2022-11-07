namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class MusicControllerComponent_Template : CSerializable {
		public Placeholder musicVolume;
		public uint metronomeType;
		public Placeholder inputs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			musicVolume = s.SerializeObject<Placeholder>(musicVolume, name: "musicVolume");
			metronomeType = s.Serialize<uint>(metronomeType, name: "metronomeType");
			inputs = s.SerializeObject<Placeholder>(inputs, name: "inputs");
		}
		public override uint? ClassCRC => 0xFBE85770;
	}
}

