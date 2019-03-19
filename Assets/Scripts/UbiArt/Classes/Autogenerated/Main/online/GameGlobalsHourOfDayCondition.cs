using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class GameGlobalsHourOfDayCondition : GameGlobalsCondition {
		[Serialize("startHour"  )] public uint startHour;
		[Serialize("startMinute")] public uint startMinute;
		[Serialize("endHour"    )] public uint endHour;
		[Serialize("endMinute"  )] public uint endMinute;
		[Serialize("utc"        )] public bool utc;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(startHour));
			SerializeField(s, nameof(startMinute));
			SerializeField(s, nameof(endHour));
			SerializeField(s, nameof(endMinute));
			SerializeField(s, nameof(utc));
		}
		public override uint? ClassCRC => 0x67E5BF69;
	}
}

