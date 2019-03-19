using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class GameGlobalsDayOfMonthCondition : GameGlobalsCondition {
		[Serialize("start")] public uint start;
		[Serialize("end"  )] public uint end;
		[Serialize("utc"  )] public bool utc;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(start));
			SerializeField(s, nameof(end));
			SerializeField(s, nameof(utc));
		}
		public override uint? ClassCRC => 0x1314DF6B;
	}
}

