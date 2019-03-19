using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class GiftPoolConfig : CSerializable {
		[Serialize("messageType"                            )] public string messageType;
		[Serialize("messageAskType"                         )] public string messageAskType;
		[Serialize("timeToGetAskGift"                       )] public online.TimeInterval timeToGetAskGift;
		[Serialize("timeToGetGift"                          )] public online.TimeInterval timeToGetGift;
		[Serialize("restrictAskDuration"                    )] public online.TimeInterval restrictAskDuration;
		[Serialize("restrictDuration"                       )] public online.TimeInterval restrictDuration;
		[Serialize("maxGiftSentPerRestrictInterval"         )] public uint maxGiftSentPerRestrictInterval;
		[Serialize("maxGiftSentPerPlayerPerRestrictInterval")] public uint maxGiftSentPerPlayerPerRestrictInterval;
		[Serialize("maxGiftSentPerPlayerPending"            )] public uint maxGiftSentPerPlayerPending;
		[Serialize("maxGiftReceivedPerRestrictInterval"     )] public uint maxGiftReceivedPerRestrictInterval;
		[Serialize("maxGiftReceivedPending"                 )] public uint maxGiftReceivedPending;
		[Serialize("maxGiftAskPending"                      )] public uint maxGiftAskPending;
		[Serialize("KEY"                                    )] public StringID KEY;
		[Serialize("currentGiftKeyStringID"                 )] public StringID currentGiftKeyStringID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(messageType));
			SerializeField(s, nameof(messageAskType));
			SerializeField(s, nameof(timeToGetAskGift));
			SerializeField(s, nameof(timeToGetGift));
			SerializeField(s, nameof(restrictAskDuration));
			SerializeField(s, nameof(restrictDuration));
			SerializeField(s, nameof(maxGiftSentPerRestrictInterval));
			SerializeField(s, nameof(maxGiftSentPerPlayerPerRestrictInterval));
			SerializeField(s, nameof(maxGiftSentPerPlayerPending));
			SerializeField(s, nameof(maxGiftReceivedPerRestrictInterval));
			SerializeField(s, nameof(maxGiftReceivedPending));
			SerializeField(s, nameof(maxGiftAskPending));
			SerializeField(s, nameof(KEY));
			SerializeField(s, nameof(KEY));
			SerializeField(s, nameof(currentGiftKeyStringID));
		}
	}
}

