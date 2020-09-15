using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventSetBusFilter : Event {
		public StringID bus;
		public int changeFrequency;
		public float frequency;
		public int changeType;
		public FilterType type;
		public FilterType2 type2;
		public int changeQ;
		public float Q;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				bus = s.SerializeObject<StringID>(bus, name: "bus");
				changeFrequency = s.Serialize<int>(changeFrequency, name: "changeFrequency");
				frequency = s.Serialize<float>(frequency, name: "frequency");
				changeType = s.Serialize<int>(changeType, name: "changeType");
				type = s.Serialize<FilterType>(type, name: "type");
				changeQ = s.Serialize<int>(changeQ, name: "changeQ");
				Q = s.Serialize<float>(Q, name: "Q");
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				bus = s.SerializeObject<StringID>(bus, name: "bus");
				frequency = s.Serialize<float>(frequency, name: "frequency");
				type2 = s.Serialize<FilterType2>(type2, name: "type2");
			} else {
			}
		}
		public enum FilterType {
			[Serialize("FilterType_LowPass" )] LowPass = 0,
			[Serialize("FilterType_BandPass")] BandPass = 1,
			[Serialize("FilterType_HighPass")] HighPass = 2,
			[Serialize("FilterType_Notch"   )] Notch = 3,
			[Serialize("FilterType_None"    )] None = 4,
		}
		public enum FilterType2 {
			[Serialize("FilterType_LowPass")] LowPass = 0,
			[Serialize("FilterType_BandPass")] BandPass = 1,
			[Serialize("FilterType_HighPass")] HighPass = 2,
		}
		public override uint? ClassCRC => 0x136F9CA4;
	}
}

