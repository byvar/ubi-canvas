namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR | GameFlags.LegendsAndUp)]
	public partial class PlaySound_evtTemplate : SequenceEventWithActor_Template {
		public Path Sound;
		public SoundParams Params;
		public float Volume;
		public string Category;
		public int IsStrem;
		public StringID Category2 = new StringID("SFX");
		public int IsStream;
		public string Sound2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RFR || s.Settings.Game == Game.RO) {
				Sound = s.SerializeObject<Path>(Sound, name: "Sound");
				Params = s.SerializeObject<SoundParams>(Params, name: "Params");
				Volume = s.Serialize<float>(Volume, name: "Volume");
				Category = s.Serialize<string>(Category, name: "Category");
				IsStrem = s.Serialize<int>(IsStrem, name: "IsStrem");
			} else if (s.Settings.Game == Game.RL) {
				Sound = s.SerializeObject<Path>(Sound, name: "Sound");
				Params = s.SerializeObject<SoundParams>(Params, name: "Params");
				Volume = s.Serialize<float>(Volume, name: "Volume");
				Category2 = s.SerializeObject<StringID>(Category2, name: "Category");
				IsStream = s.Serialize<int>(IsStream, name: "IsStream");
			} else if (s.Settings.Game == Game.COL) {
				Sound2 = s.Serialize<string>(Sound2, name: "Sound");
				Volume = s.Serialize<float>(Volume, name: "Volume");
				Category2 = s.SerializeObject<StringID>(Category2, name: "Category");
				IsStream = s.Serialize<int>(IsStream, name: "IsStream");
			} else {
				Sound = s.SerializeObject<Path>(Sound, name: "Sound");
			}
		}
		public override uint? ClassCRC => 0x8AD848D9;
	}
}

