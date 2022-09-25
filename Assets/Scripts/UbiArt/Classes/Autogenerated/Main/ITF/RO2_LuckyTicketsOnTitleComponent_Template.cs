using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_LuckyTicketsOnTitleComponent_Template : ActorComponent_Template {
		public Path luckyTicketActorPath;
		public Path luckyTicketGreyActorPath;
		public float verticalOffset;
		public float spaceBetween;
		public float ticketUsedAlpha;
		public float fadeDuration;
		public float japaneseVerticalOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				luckyTicketActorPath = s.SerializeObject<Path>(luckyTicketActorPath, name: "luckyTicketActorPath");
				luckyTicketGreyActorPath = s.SerializeObject<Path>(luckyTicketGreyActorPath, name: "luckyTicketGreyActorPath");
				verticalOffset = s.Serialize<float>(verticalOffset, name: "verticalOffset");
				japaneseVerticalOffset = s.Serialize<float>(japaneseVerticalOffset, name: "japaneseVerticalOffset");
				spaceBetween = s.Serialize<float>(spaceBetween, name: "spaceBetween");
				ticketUsedAlpha = s.Serialize<float>(ticketUsedAlpha, name: "ticketUsedAlpha");
				fadeDuration = s.Serialize<float>(fadeDuration, name: "fadeDuration");
			} else {
				luckyTicketActorPath = s.SerializeObject<Path>(luckyTicketActorPath, name: "luckyTicketActorPath");
				luckyTicketGreyActorPath = s.SerializeObject<Path>(luckyTicketGreyActorPath, name: "luckyTicketGreyActorPath");
				verticalOffset = s.Serialize<float>(verticalOffset, name: "verticalOffset");
				spaceBetween = s.Serialize<float>(spaceBetween, name: "spaceBetween");
				ticketUsedAlpha = s.Serialize<float>(ticketUsedAlpha, name: "ticketUsedAlpha");
				fadeDuration = s.Serialize<float>(fadeDuration, name: "fadeDuration");
			}
		}
		public override uint? ClassCRC => 0xFB0D166B;
	}
}

