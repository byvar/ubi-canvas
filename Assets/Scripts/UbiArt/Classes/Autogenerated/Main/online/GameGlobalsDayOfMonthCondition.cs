using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class GameGlobalsDayOfMonthCondition : GameGlobalsCondition {
		public uint start;
		public uint end;
		public bool utc;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			start = s.Serialize<uint>(start, name: "start");
			end = s.Serialize<uint>(end, name: "end");
			utc = s.Serialize<bool>(utc, name: "utc");
		}
		public override uint? ClassCRC => 0x1314DF6B;
	}
}

