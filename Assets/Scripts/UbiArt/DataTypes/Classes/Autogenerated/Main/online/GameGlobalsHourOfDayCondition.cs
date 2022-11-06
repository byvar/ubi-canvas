using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class GameGlobalsHourOfDayCondition : GameGlobalsCondition {
		public uint startHour;
		public uint startMinute;
		public uint endHour;
		public uint endMinute;
		public bool utc;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			startHour = s.Serialize<uint>(startHour, name: "startHour");
			startMinute = s.Serialize<uint>(startMinute, name: "startMinute");
			endHour = s.Serialize<uint>(endHour, name: "endHour");
			endMinute = s.Serialize<uint>(endMinute, name: "endMinute");
			utc = s.Serialize<bool>(utc, name: "utc");
		}
		public override uint? ClassCRC => 0x67E5BF69;
	}
}

