namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class GiftPoolConfig : CSerializable {
		public string messageType;
		public string messageAskType;
		public online.TimeInterval timeToGetAskGift;
		public online.TimeInterval timeToGetGift;
		public online.TimeInterval restrictAskDuration;
		public online.TimeInterval restrictDuration;
		public uint maxGiftSentPerRestrictInterval;
		public uint maxGiftSentPerPlayerPerRestrictInterval;
		public uint maxGiftSentPerPlayerPending;
		public uint maxGiftReceivedPerRestrictInterval;
		public uint maxGiftReceivedPending;
		public uint maxGiftAskPending;
		public StringID KEY;
		public StringID currentGiftKeyStringID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			messageType = s.Serialize<string>(messageType, name: "messageType");
			messageAskType = s.Serialize<string>(messageAskType, name: "messageAskType");
			timeToGetAskGift = s.SerializeObject<online.TimeInterval>(timeToGetAskGift, name: "timeToGetAskGift");
			timeToGetGift = s.SerializeObject<online.TimeInterval>(timeToGetGift, name: "timeToGetGift");
			restrictAskDuration = s.SerializeObject<online.TimeInterval>(restrictAskDuration, name: "restrictAskDuration");
			restrictDuration = s.SerializeObject<online.TimeInterval>(restrictDuration, name: "restrictDuration");
			maxGiftSentPerRestrictInterval = s.Serialize<uint>(maxGiftSentPerRestrictInterval, name: "maxGiftSentPerRestrictInterval");
			maxGiftSentPerPlayerPerRestrictInterval = s.Serialize<uint>(maxGiftSentPerPlayerPerRestrictInterval, name: "maxGiftSentPerPlayerPerRestrictInterval");
			maxGiftSentPerPlayerPending = s.Serialize<uint>(maxGiftSentPerPlayerPending, name: "maxGiftSentPerPlayerPending");
			maxGiftReceivedPerRestrictInterval = s.Serialize<uint>(maxGiftReceivedPerRestrictInterval, name: "maxGiftReceivedPerRestrictInterval");
			maxGiftReceivedPending = s.Serialize<uint>(maxGiftReceivedPending, name: "maxGiftReceivedPending");
			maxGiftAskPending = s.Serialize<uint>(maxGiftAskPending, name: "maxGiftAskPending");
			KEY = s.SerializeObject<StringID>(KEY, name: "KEY");
			KEY = s.SerializeObject<StringID>(KEY, name: "KEY");
			currentGiftKeyStringID = s.SerializeObject<StringID>(currentGiftKeyStringID, name: "currentGiftKeyStringID");
		}
	}
}

