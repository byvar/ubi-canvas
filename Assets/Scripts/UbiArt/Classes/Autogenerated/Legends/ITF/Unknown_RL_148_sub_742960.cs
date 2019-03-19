using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_148_sub_742960 : CSerializable {
		[Serialize("textTitleNameLeft"        )] public StringID textTitleNameLeft;
		[Serialize("textDateNameLeft"         )] public StringID textDateNameLeft;
		[Serialize("textTitleName"            )] public StringID textTitleName;
		[Serialize("textDateName"             )] public StringID textDateName;
		[Serialize("textTitleNameRight"       )] public StringID textTitleNameRight;
		[Serialize("textDateNameRight"        )] public StringID textDateNameRight;
		[Serialize("itemArrowUpName"          )] public StringID itemArrowUpName;
		[Serialize("itemArrowDownName"        )] public StringID itemArrowDownName;
		[Serialize("itemFriendsName"          )] public StringID itemFriendsName;
		[Serialize("itemfavoriteName"         )] public StringID itemfavoriteName;
		[Serialize("itemMyScoreName"          )] public StringID itemMyScoreName;
		[Serialize("itemTitleInsideboxName"   )] public StringID itemTitleInsideboxName;
		[Serialize("itemSwitchLeaderboardName")] public StringID itemSwitchLeaderboardName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(textTitleNameLeft));
			SerializeField(s, nameof(textDateNameLeft));
			SerializeField(s, nameof(textTitleName));
			SerializeField(s, nameof(textDateName));
			SerializeField(s, nameof(textTitleNameRight));
			SerializeField(s, nameof(textDateNameRight));
			SerializeField(s, nameof(itemArrowUpName));
			SerializeField(s, nameof(itemArrowDownName));
			SerializeField(s, nameof(itemFriendsName));
			SerializeField(s, nameof(itemfavoriteName));
			SerializeField(s, nameof(itemMyScoreName));
			SerializeField(s, nameof(itemTitleInsideboxName));
			SerializeField(s, nameof(itemSwitchLeaderboardName));
		}
		public override uint? ClassCRC => 0x839BE1C8;
	}
}

