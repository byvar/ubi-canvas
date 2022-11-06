using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_148_sub_742960 : CSerializable {
		public StringID textTitleNameLeft;
		public StringID textDateNameLeft;
		public StringID textTitleName;
		public StringID textDateName;
		public StringID textTitleNameRight;
		public StringID textDateNameRight;
		public StringID itemArrowUpName;
		public StringID itemArrowDownName;
		public StringID itemFriendsName;
		public StringID itemfavoriteName;
		public StringID itemMyScoreName;
		public StringID itemTitleInsideboxName;
		public StringID itemSwitchLeaderboardName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			textTitleNameLeft = s.SerializeObject<StringID>(textTitleNameLeft, name: "textTitleNameLeft");
			textDateNameLeft = s.SerializeObject<StringID>(textDateNameLeft, name: "textDateNameLeft");
			textTitleName = s.SerializeObject<StringID>(textTitleName, name: "textTitleName");
			textDateName = s.SerializeObject<StringID>(textDateName, name: "textDateName");
			textTitleNameRight = s.SerializeObject<StringID>(textTitleNameRight, name: "textTitleNameRight");
			textDateNameRight = s.SerializeObject<StringID>(textDateNameRight, name: "textDateNameRight");
			itemArrowUpName = s.SerializeObject<StringID>(itemArrowUpName, name: "itemArrowUpName");
			itemArrowDownName = s.SerializeObject<StringID>(itemArrowDownName, name: "itemArrowDownName");
			itemFriendsName = s.SerializeObject<StringID>(itemFriendsName, name: "itemFriendsName");
			itemfavoriteName = s.SerializeObject<StringID>(itemfavoriteName, name: "itemfavoriteName");
			itemMyScoreName = s.SerializeObject<StringID>(itemMyScoreName, name: "itemMyScoreName");
			itemTitleInsideboxName = s.SerializeObject<StringID>(itemTitleInsideboxName, name: "itemTitleInsideboxName");
			itemSwitchLeaderboardName = s.SerializeObject<StringID>(itemSwitchLeaderboardName, name: "itemSwitchLeaderboardName");
		}
		public override uint? ClassCRC => 0x839BE1C8;
	}
}

