using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BubblePrize_Template : CSerializable {
		[Serialize("contentList"    )] public CList<BubblePrizeContent_Template> contentList;
		[Serialize("isHeart"        )] public bool isHeart;
		[Serialize("isSkullCoin"    )] public bool isSkullCoin;
		[Serialize("redBankChangeId")] public StringID redBankChangeId;
		[Serialize("preSpawn"       )] public bool preSpawn;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(contentList));
			SerializeField(s, nameof(isHeart));
			SerializeField(s, nameof(isSkullCoin));
			SerializeField(s, nameof(redBankChangeId));
			SerializeField(s, nameof(preSpawn));
		}
	}
}

