using UnityEngine;

namespace UbiArt.online {
	public partial class GiftSendingError : CSerializable {
		[Serialize("cause")] public Enum_cause cause;
		[Serialize("time" )] public online.DateTime time;
		[Serialize("pool" )] public StringID pool;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(cause));
			SerializeField(s, nameof(time));
			SerializeField(s, nameof(pool));
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

