using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class StatInfos : CSerializable {
		public StringID id;
		public Color color;
		public SmartLocId statName;
		public SmartLocId name;
		public SmartLocId leaderboardTitle;
		public StringID leaderboardTitleIcon;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			id = s.SerializeObject<StringID>(id, name: "id");
			color = s.SerializeObject<Color>(color, name: "color");
			statName = s.SerializeObject<SmartLocId>(statName, name: "statName");
			name = s.SerializeObject<SmartLocId>(name, name: "name");
			leaderboardTitle = s.SerializeObject<SmartLocId>(leaderboardTitle, name: "leaderboardTitle");
			leaderboardTitleIcon = s.SerializeObject<StringID>(leaderboardTitleIcon, name: "leaderboardTitleIcon");
		}
	}
}

