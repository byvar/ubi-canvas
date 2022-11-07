namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class GiftSendingError : CSerializable {
		public Enum_cause cause;
		public online.DateTime time;
		public StringID pool;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			cause = s.Serialize<Enum_cause>(cause, name: "cause");
			time = s.SerializeObject<online.DateTime>(time, name: "time");
			pool = s.SerializeObject<StringID>(pool, name: "pool");
		}
		public enum Enum_cause {
			[Serialize("Unknown"                    )] Unknown = 0,
			[Serialize("RecipientMailboxFull"       )] RecipientMailboxFull = 1,
			[Serialize("RecipientMailboxFromYouFull")] RecipientMailboxFromYouFull = 2,
			[Serialize("TooMuchGiftSent"            )] TooMuchGiftSent = 3,
			[Serialize("TooMuchGiftSentToRecipient" )] TooMuchGiftSentToRecipient = 4,
		}
	}
}

