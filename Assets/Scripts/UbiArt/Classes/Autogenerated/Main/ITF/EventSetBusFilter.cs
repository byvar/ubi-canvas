using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventSetBusFilter : Event {
		[Serialize("bus"            )] public StringID bus;
		[Serialize("changeFrequency")] public int changeFrequency;
		[Serialize("frequency"      )] public float frequency;
		[Serialize("changeType"     )] public int changeType;
		[Serialize("type"           )] public FilterType type;
		[Serialize("changeQ"        )] public int changeQ;
		[Serialize("Q"              )] public float Q;
		[Serialize("sender"         )] public uint sender;
		[Serialize("type"           )] public Enum_type type;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(bus));
				SerializeField(s, nameof(changeFrequency));
				SerializeField(s, nameof(frequency));
				SerializeField(s, nameof(changeType));
				SerializeField(s, nameof(type));
				SerializeField(s, nameof(changeQ));
				SerializeField(s, nameof(Q));
			} else if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(bus));
				SerializeField(s, nameof(changeFrequency));
				SerializeField(s, nameof(frequency));
				SerializeField(s, nameof(changeType));
				SerializeField(s, nameof(type));
				SerializeField(s, nameof(changeQ));
				SerializeField(s, nameof(Q));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(frequency));
				SerializeField(s, nameof(type));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(bus));
				SerializeField(s, nameof(frequency));
				SerializeField(s, nameof(type));
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
		public enum FilterType {
			[Serialize("FilterType_LowPass" )] LowPass = 0,
			[Serialize("FilterType_BandPass")] BandPass = 1,
			[Serialize("FilterType_HighPass")] HighPass = 2,
			[Serialize("FilterType_Notch"   )] Notch = 3,
			[Serialize("FilterType_None"    )] None = 4,
		}
		public enum Enum_type {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public enum Enum_type {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0x136F9CA4;
	}
}

