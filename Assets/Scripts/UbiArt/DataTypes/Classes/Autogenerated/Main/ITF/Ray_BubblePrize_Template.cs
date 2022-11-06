using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class Ray_BubblePrize_Template : CSerializable {
		public CListO<BubblePrizeContent_Template> contentList;		
		public float contentChangeDelay;
		public bool isHeart;
		public bool isSkullCoin;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			contentList = s.SerializeObject<CListO<BubblePrizeContent_Template>>(contentList, name: "contentList");
			contentChangeDelay = s.Serialize<float>(contentChangeDelay, name: "contentChangeDelay");
			isHeart = s.Serialize<bool>(isHeart, name: "isHeart");
			isSkullCoin = s.Serialize<bool>(isSkullCoin, name: "isSkullCoin");
		}
	}
}

