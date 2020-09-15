using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class GameGlobalsDayOfWeekCondition : GameGlobalsCondition {
		public bool utc;
		public uint week;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			utc = s.Serialize<bool>(utc, name: "utc");
			week = s.Serialize<uint>(week, name: "week");
		}
		public override uint? ClassCRC => 0xEF90E84B;
	}
}

