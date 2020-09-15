using UnityEngine;

namespace UbiArt.online {
	public partial class DateTime : CSerializable {
		public ulong value;
		public uint year;
		public uint month;
		public uint day;
		public uint hour;
		public uint minute;
		public uint second;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8) || Settings.s.game != Settings.Game.RA) {
				value = s.Serialize<ulong>(value, name: "value");
			}
			if (Settings.s.game == Settings.Game.RA) {
				year = s.Serialize<uint>(year, name: "year");
				month = s.Serialize<uint>(month, name: "month");
				day = s.Serialize<uint>(day, name: "day");
				hour = s.Serialize<uint>(hour, name: "hour");
				minute = s.Serialize<uint>(minute, name: "minute");
				second = s.Serialize<uint>(second, name: "second");
			}
		}
	}
}

