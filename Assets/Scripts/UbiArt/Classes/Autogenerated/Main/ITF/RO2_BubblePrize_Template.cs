using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_BubblePrize_Template : CSerializable {
		public CListO<BubblePrizeContent_Template> contentList;
		public bool isHeart;
		public bool isSkullCoin;
		public StringID redBankChangeId;
		public bool preSpawn;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			contentList = s.SerializeObject<CListO<BubblePrizeContent_Template>>(contentList, name: "contentList");
			isHeart = s.Serialize<bool>(isHeart, name: "isHeart");
			isSkullCoin = s.Serialize<bool>(isSkullCoin, name: "isSkullCoin");
			redBankChangeId = s.SerializeObject<StringID>(redBankChangeId, name: "redBankChangeId");
			preSpawn = s.Serialize<bool>(preSpawn, name: "preSpawn");
		}
	}
}

