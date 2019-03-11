using UnityEngine;

namespace UbiArt.online {
	public partial class DateTime : CSerializable {
		[Serialize("value")] public ulong value;
		[Serialize("year")] public uint year;
		[Serialize("month")] public uint month;
		[Serialize("day")] public uint day;
		[Serialize("hour")] public uint hour;
		[Serialize("minute")] public uint minute;
		[Serialize("second")] public uint second;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8)) {
				SerializeField(s, nameof(value));
			}
			SerializeField(s, nameof(year));
			SerializeField(s, nameof(month));
			SerializeField(s, nameof(day));
			SerializeField(s, nameof(hour));
			SerializeField(s, nameof(minute));
			SerializeField(s, nameof(second));
		}
	}
}

