using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class GameGlobalsStartDateCondition : GameGlobalsCondition {
		public online.DateTime start;
		public bool utc;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			start = s.SerializeObject<online.DateTime>(start, name: "start");
			utc = s.Serialize<bool>(utc, name: "utc");
		}
		public override uint? ClassCRC => 0x6EBA0BB4;
	}
}

