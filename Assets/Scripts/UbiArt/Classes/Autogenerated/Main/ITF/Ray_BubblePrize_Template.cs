using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class Ray_BubblePrize_Template : CSerializable {
		[Serialize("contentList")] public CList<BubblePrizeContent_Template> contentList;		
		[Serialize("contentChangeDelay")] public float contentChangeDelay;
		[Serialize("isHeart"           )] public bool isHeart;
		[Serialize("isSkullCoin"       )] public bool isSkullCoin;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(contentList));
			SerializeField(s, nameof(contentChangeDelay));
			SerializeField(s, nameof(isHeart));
			SerializeField(s, nameof(isSkullCoin));
		}
	}
}

