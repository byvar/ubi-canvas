using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_LuckyTicketsOnTitleComponent_Template : ActorComponent_Template {
		[Serialize("luckyTicketActorPath"    )] public Path luckyTicketActorPath;
		[Serialize("luckyTicketGreyActorPath")] public Path luckyTicketGreyActorPath;
		[Serialize("verticalOffset"          )] public float verticalOffset;
		[Serialize("spaceBetween"            )] public float spaceBetween;
		[Serialize("ticketUsedAlpha"         )] public float ticketUsedAlpha;
		[Serialize("fadeDuration"            )] public float fadeDuration;
		[Serialize("japaneseVerticalOffset"  )] public float japaneseVerticalOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(luckyTicketActorPath));
				SerializeField(s, nameof(luckyTicketGreyActorPath));
				SerializeField(s, nameof(verticalOffset));
				SerializeField(s, nameof(japaneseVerticalOffset));
				SerializeField(s, nameof(spaceBetween));
				SerializeField(s, nameof(ticketUsedAlpha));
				SerializeField(s, nameof(fadeDuration));
			} else {
				SerializeField(s, nameof(luckyTicketActorPath));
				SerializeField(s, nameof(luckyTicketGreyActorPath));
				SerializeField(s, nameof(verticalOffset));
				SerializeField(s, nameof(spaceBetween));
				SerializeField(s, nameof(ticketUsedAlpha));
				SerializeField(s, nameof(fadeDuration));
			}
		}
		public override uint? ClassCRC => 0xFB0D166B;
	}
}

