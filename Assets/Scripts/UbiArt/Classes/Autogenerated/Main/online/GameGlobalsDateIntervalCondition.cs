using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class GameGlobalsDateIntervalCondition : GameGlobalsCondition {
		public online.DateTime start;
		public online.DateTime end;
		public bool utc;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			start = s.SerializeObject<online.DateTime>(start, name: "start");
			end = s.SerializeObject<online.DateTime>(end, name: "end");
			utc = s.Serialize<bool>(utc, name: "utc");
		}
		public override uint? ClassCRC => 0x70781E25;
	}
}

