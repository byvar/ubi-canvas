namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class TRCLocalisation_Detail : CSerializable {
		public Enum_type type;
		public bool canBack;
		public SmartLocId message;
		public SmartLocId title;
		public SmartLocId buttonLeft;
		public SmartLocId buttonRight;
		public SmartLocId buttonMiddle;
		public Button defaultButton;
		public TRCRestart restart;
		public uint TRCError;
		public string messageText;
		public LocalisationId messageId;
		public LocalisationId buttonLeftId;
		public LocalisationId buttonRightId;
		public LocalisationId titleId;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL) {
				TRCError = s.Serialize<uint>(TRCError, name: "TRCError");
				messageText = s.Serialize<string>(messageText, name: "messageText");
				messageId = s.SerializeObject<LocalisationId>(messageId, name: "messageId");
				buttonLeftId = s.SerializeObject<LocalisationId>(buttonLeftId, name: "buttonLeftId");
				buttonRightId = s.SerializeObject<LocalisationId>(buttonRightId, name: "buttonRightId");
				titleId = s.SerializeObject<LocalisationId>(titleId, name: "titleId");
				message = s.SerializeObject<SmartLocId>(message, name: "message");
				title = s.SerializeObject<SmartLocId>(title, name: "title");
				buttonLeft = s.SerializeObject<SmartLocId>(buttonLeft, name: "buttonLeft");
				buttonRight = s.SerializeObject<SmartLocId>(buttonRight, name: "buttonRight");
				defaultButton = s.Serialize<Button>(defaultButton, name: "defaultButton");
			} else if (s.Settings.Game == Game.VH) {
				TRCError = s.Serialize<uint>(TRCError, name: "TRCError");
				messageText = s.Serialize<string>(messageText, name: "messageText");
				messageId = s.SerializeObject<LocalisationId>(messageId, name: "messageId");
				buttonLeftId = s.SerializeObject<LocalisationId>(buttonLeftId, name: "buttonLeftId");
				buttonRightId = s.SerializeObject<LocalisationId>(buttonRightId, name: "buttonRightId");
				titleId = s.SerializeObject<LocalisationId>(titleId, name: "titleId");
				message = s.SerializeObject<SmartLocId>(message, name: "message");
				title = s.SerializeObject<SmartLocId>(title, name: "title");
				buttonLeft = s.SerializeObject<SmartLocId>(buttonLeft, name: "buttonLeft");
				buttonRight = s.SerializeObject<SmartLocId>(buttonRight, name: "buttonRight");
				buttonMiddle = s.SerializeObject<SmartLocId>(buttonMiddle, name: "buttonMiddle");
				defaultButton = s.Serialize<Button>(defaultButton, name: "defaultButton");
			} else {
				type = s.Serialize<Enum_type>(type, name: "type");
				canBack = s.Serialize<bool>(canBack, name: "canBack");
				message = s.SerializeObject<SmartLocId>(message, name: "message");
				title = s.SerializeObject<SmartLocId>(title, name: "title");
				buttonLeft = s.SerializeObject<SmartLocId>(buttonLeft, name: "buttonLeft");
				buttonRight = s.SerializeObject<SmartLocId>(buttonRight, name: "buttonRight");
				buttonMiddle = s.SerializeObject<SmartLocId>(buttonMiddle, name: "buttonMiddle");
				defaultButton = s.Serialize<Button>(defaultButton, name: "defaultButton");
				restart = s.Serialize<TRCRestart>(restart, name: "restart");
			}
		}
		public enum Enum_type {
			[Serialize("Custom"     )] Custom = 0,
			[Serialize("OneButton"  )] OneButton = 1,
			[Serialize("TwoButton"  )] TwoButton = 2,
			[Serialize("ThreeButton")] ThreeButton = 3,
			[Serialize("Timer"      )] Timer = 4,
			[Serialize("FastTimer"  )] FastTimer = 5,
			[Serialize("NoButton"   )] NoButton = 6,
		}
		public enum Button {
			[Serialize("Button_None"  )] None = -1,
			[Serialize("Button_Left"  )] Left = 0,
			[Serialize("Button_Right" )] Right = 1,
			[Serialize("Button_Middle")] Middle = 2,
		}
		public enum TRCRestart {
			[Serialize("TRCRestart_NoRestart"              )] NoRestart = 0,
			[Serialize("TRCRestart_Restart"                )] Restart = 1,
			[Serialize("TRCRestart_RestartWithProgressLoss")] RestartWithProgressLoss = 2,
		}
	}
}

