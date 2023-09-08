namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_HomeNodeComponent_Template : RO2_HomeComponent_Template {
		public float maxSpeedToFocusCostumeFrame = 1f;
		public Vec2d paintScale;
		public float nodeDialogsDelay;
		public string challengersDialogSeparator;
		public string challengersModeSeparator;
		public float unlockingDuration;
		public float unteasingDuration;
		public float paintTransitionDuration;
		public uint invasionFrameDisplayDelay;
		public EventInstructionDialog HomeNodeDialog_Lock;
		public EventInstructionDialog HomeNodeDialog_Challengers;
		public EventInstructionDialog HomeNodeDialog_DiamondCup;
		public EventInstructionDialog HomeNodeDialog_GoldCup;
		public EventInstructionDialog HomeNodeDialog_SilverCup;
		public EventInstructionDialog HomeNodeDialog_BronzeCup;
		public EventInstructionDialog HomeNodeDialog_Teaser_Day;
		public EventInstructionDialog HomeNodeDialog_Teaser_Hour;
		public EventInstructionDialog HomeNodeDialog_Teaser_Minute;
		public EventInstructionDialog HomeNodeDialog_Teaser_Second;
		public EventInstructionDialog HomeNodeDialog_FriendChallengers;
		public EventInstructionDialog HomeNodeDialog_TotalChallengers;
		public EventInstructionDialog HomeNodeDialog_CostumeDescription;
		public EventInstructionDialog HomeNodeDialog_Highlight;
		public EventInstructionDialog HomeNodeDialog_NeedOnline;
		public EventInstructionDialog HomeNodeDialog_NotAvailableInMultiplayer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Platform != GamePlatform.Vita) {
				maxSpeedToFocusCostumeFrame = s.Serialize<float>(maxSpeedToFocusCostumeFrame, name: "maxSpeedToFocusCostumeFrame");
			}
			paintScale = s.SerializeObject<Vec2d>(paintScale, name: "paintScale");
			nodeDialogsDelay = s.Serialize<float>(nodeDialogsDelay, name: "nodeDialogsDelay");
			challengersDialogSeparator = s.Serialize<string>(challengersDialogSeparator, name: "challengersDialogSeparator");
			challengersModeSeparator = s.Serialize<string>(challengersModeSeparator, name: "challengersModeSeparator");
			unlockingDuration = s.Serialize<float>(unlockingDuration, name: "unlockingDuration");
			unteasingDuration = s.Serialize<float>(unteasingDuration, name: "unteasingDuration");
			paintTransitionDuration = s.Serialize<float>(paintTransitionDuration, name: "paintTransitionDuration");
			if (s.Settings.Platform != GamePlatform.Vita) {
				invasionFrameDisplayDelay = s.Serialize<uint>(invasionFrameDisplayDelay, name: "invasionFrameDisplayDelay");
			}
			HomeNodeDialog_Lock = s.SerializeObject<EventInstructionDialog>(HomeNodeDialog_Lock, name: "HomeNodeDialog_Lock");
			HomeNodeDialog_Challengers = s.SerializeObject<EventInstructionDialog>(HomeNodeDialog_Challengers, name: "HomeNodeDialog_Challengers");
			HomeNodeDialog_DiamondCup = s.SerializeObject<EventInstructionDialog>(HomeNodeDialog_DiamondCup, name: "HomeNodeDialog_DiamondCup");
			HomeNodeDialog_GoldCup = s.SerializeObject<EventInstructionDialog>(HomeNodeDialog_GoldCup, name: "HomeNodeDialog_GoldCup");
			HomeNodeDialog_SilverCup = s.SerializeObject<EventInstructionDialog>(HomeNodeDialog_SilverCup, name: "HomeNodeDialog_SilverCup");
			HomeNodeDialog_BronzeCup = s.SerializeObject<EventInstructionDialog>(HomeNodeDialog_BronzeCup, name: "HomeNodeDialog_BronzeCup");
			HomeNodeDialog_Teaser_Day = s.SerializeObject<EventInstructionDialog>(HomeNodeDialog_Teaser_Day, name: "HomeNodeDialog_Teaser_Day");
			HomeNodeDialog_Teaser_Hour = s.SerializeObject<EventInstructionDialog>(HomeNodeDialog_Teaser_Hour, name: "HomeNodeDialog_Teaser_Hour");
			HomeNodeDialog_Teaser_Minute = s.SerializeObject<EventInstructionDialog>(HomeNodeDialog_Teaser_Minute, name: "HomeNodeDialog_Teaser_Minute");
			HomeNodeDialog_Teaser_Second = s.SerializeObject<EventInstructionDialog>(HomeNodeDialog_Teaser_Second, name: "HomeNodeDialog_Teaser_Second");
			HomeNodeDialog_FriendChallengers = s.SerializeObject<EventInstructionDialog>(HomeNodeDialog_FriendChallengers, name: "HomeNodeDialog_FriendChallengers");
			HomeNodeDialog_TotalChallengers = s.SerializeObject<EventInstructionDialog>(HomeNodeDialog_TotalChallengers, name: "HomeNodeDialog_TotalChallengers");
			HomeNodeDialog_CostumeDescription = s.SerializeObject<EventInstructionDialog>(HomeNodeDialog_CostumeDescription, name: "HomeNodeDialog_CostumeDescription");
			HomeNodeDialog_Highlight = s.SerializeObject<EventInstructionDialog>(HomeNodeDialog_Highlight, name: "HomeNodeDialog_Highlight");
			HomeNodeDialog_NeedOnline = s.SerializeObject<EventInstructionDialog>(HomeNodeDialog_NeedOnline, name: "HomeNodeDialog_NeedOnline");

			if (s.Settings.Platform == GamePlatform.Vita) {
				HomeNodeDialog_NotAvailableInMultiplayer = s.SerializeObject<EventInstructionDialog>(HomeNodeDialog_NotAvailableInMultiplayer, name: "HomeNodeDialog_NotAvailableInMultiplayer");
			}
		}
		public override uint? ClassCRC => 0x426FB0B9;
	}
}

