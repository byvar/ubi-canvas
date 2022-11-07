namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class EventMusicCustomCue : Event {
		public METRONOME_TYPE Metronome;
		public StringID Cue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Metronome = s.Serialize<METRONOME_TYPE>(Metronome, name: "Metronome");
			Cue = s.SerializeObject<StringID>(Cue, name: "Cue");
		}
		public enum METRONOME_TYPE {
			[Serialize("METRONOME_TYPE_DEFAULT" )] DEFAULT = 0,
			[Serialize("METRONOME_TYPE_MENU"    )] MENU = 1,
			[Serialize("METRONOME_TYPE_GAMEPLAY")] GAMEPLAY = 2,
			[Serialize("METRONOME_TYPE_INVALID" )] INVALID = 4,
		}
		public override uint? ClassCRC => 0xCE3CE051;
	}
}

