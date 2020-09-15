using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class GameGlobalsEndDateCondition : GameGlobalsCondition {
		public online.DateTime end;
		public bool utc;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			end = s.SerializeObject<online.DateTime>(end, name: "end");
			utc = s.Serialize<bool>(utc, name: "utc");
		}
		public override uint? ClassCRC => 0xFA33FBDB;
	}
}

