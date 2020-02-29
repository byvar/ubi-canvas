using UnityEngine;

namespace UbiArt.online {
	public partial class TimeInterval : CSerializable {
		[Serialize("value")] public ulong value;
		[Serialize("day")] public uint day;
		[Serialize("hour")] public uint hour;
		[Serialize("minute")] public uint minute;
		[Serialize("second")] public uint second;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasSerializerFlags(CSerializerObject.Flags.Flags0)) {
				SerializeField(s, nameof(value));
			} else {
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(value));
				}
				SerializeField(s, nameof(day));
				SerializeField(s, nameof(hour));
				SerializeField(s, nameof(minute));
				SerializeField(s, nameof(second));
			}
		}
	}
}

