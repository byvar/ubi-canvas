using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class PlaySound_evtTemplate : SequenceEventWithActor_Template {
		public Path Sound;
		public SoundParams Params;
		public float Volume;
		public string Category;
		public int IsStrem;
		public StringID Category2;
		public int IsStream;
		public string Sound2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				Sound = s.SerializeObject<Path>(Sound, name: "Sound");
				Params = s.SerializeObject<SoundParams>(Params, name: "Params");
				Volume = s.Serialize<float>(Volume, name: "Volume");
				Category = s.Serialize<string>(Category, name: "Category");
				IsStrem = s.Serialize<int>(IsStrem, name: "IsStrem");
			} else if (Settings.s.game == Settings.Game.RL) {
				Sound = s.SerializeObject<Path>(Sound, name: "Sound");
				Params = s.SerializeObject<SoundParams>(Params, name: "Params");
				Volume = s.Serialize<float>(Volume, name: "Volume");
				Category2 = s.SerializeObject<StringID>(Category2, name: "Category2");
				IsStream = s.Serialize<int>(IsStream, name: "IsStream");
			} else if (Settings.s.game == Settings.Game.COL) {
				Sound2 = s.Serialize<string>(Sound2, name: "Sound2");
				Volume = s.Serialize<float>(Volume, name: "Volume");
				Category2 = s.SerializeObject<StringID>(Category2, name: "Category2");
				IsStream = s.Serialize<int>(IsStream, name: "IsStream");
			} else {
				Sound = s.SerializeObject<Path>(Sound, name: "Sound");
			}
		}
		public override uint? ClassCRC => 0x8AD848D9;
	}
}

