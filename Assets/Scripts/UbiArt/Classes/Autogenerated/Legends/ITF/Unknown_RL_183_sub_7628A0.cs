using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_183_sub_7628A0 : Unknown_RL_220_sub_A763E0 {
		[Serialize("maxSpeedToFocusCostumeFrame"      )] public float maxSpeedToFocusCostumeFrame;
		[Serialize("paintScale"                       )] public Vector2 paintScale;
		[Serialize("nodeDialogsDelay"                 )] public float nodeDialogsDelay;
		[Serialize("challengersDialogSeparator"       )] public string challengersDialogSeparator;
		[Serialize("challengersModeSeparator"         )] public string challengersModeSeparator;
		[Serialize("unlockingDuration"                )] public float unlockingDuration;
		[Serialize("unteasingDuration"                )] public float unteasingDuration;
		[Serialize("paintTransitionDuration"          )] public float paintTransitionDuration;
		[Serialize("invasionFrameDisplayDelay"        )] public uint invasionFrameDisplayDelay;
		[Serialize("HomeNodeDialog_Lock"              )] public EventInstructionDialog HomeNodeDialog_Lock;
		[Serialize("HomeNodeDialog_Challengers"       )] public EventInstructionDialog HomeNodeDialog_Challengers;
		[Serialize("HomeNodeDialog_DiamondCup"        )] public EventInstructionDialog HomeNodeDialog_DiamondCup;
		[Serialize("HomeNodeDialog_GoldCup"           )] public EventInstructionDialog HomeNodeDialog_GoldCup;
		[Serialize("HomeNodeDialog_SilverCup"         )] public EventInstructionDialog HomeNodeDialog_SilverCup;
		[Serialize("HomeNodeDialog_BronzeCup"         )] public EventInstructionDialog HomeNodeDialog_BronzeCup;
		[Serialize("HomeNodeDialog_Teaser_Day"        )] public EventInstructionDialog HomeNodeDialog_Teaser_Day;
		[Serialize("HomeNodeDialog_Teaser_Hour"       )] public EventInstructionDialog HomeNodeDialog_Teaser_Hour;
		[Serialize("HomeNodeDialog_Teaser_Minute"     )] public EventInstructionDialog HomeNodeDialog_Teaser_Minute;
		[Serialize("HomeNodeDialog_Teaser_Second"     )] public EventInstructionDialog HomeNodeDialog_Teaser_Second;
		[Serialize("HomeNodeDialog_FriendChallengers" )] public EventInstructionDialog HomeNodeDialog_FriendChallengers;
		[Serialize("HomeNodeDialog_TotalChallengers"  )] public EventInstructionDialog HomeNodeDialog_TotalChallengers;
		[Serialize("HomeNodeDialog_CostumeDescription")] public EventInstructionDialog HomeNodeDialog_CostumeDescription;
		[Serialize("HomeNodeDialog_Highlight"         )] public EventInstructionDialog HomeNodeDialog_Highlight;
		[Serialize("HomeNodeDialog_NeedOnline"        )] public EventInstructionDialog HomeNodeDialog_NeedOnline;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(maxSpeedToFocusCostumeFrame));
			SerializeField(s, nameof(paintScale));
			SerializeField(s, nameof(nodeDialogsDelay));
			SerializeField(s, nameof(challengersDialogSeparator));
			SerializeField(s, nameof(challengersModeSeparator));
			SerializeField(s, nameof(unlockingDuration));
			SerializeField(s, nameof(unteasingDuration));
			SerializeField(s, nameof(paintTransitionDuration));
			SerializeField(s, nameof(invasionFrameDisplayDelay));
			SerializeField(s, nameof(HomeNodeDialog_Lock));
			SerializeField(s, nameof(HomeNodeDialog_Challengers));
			SerializeField(s, nameof(HomeNodeDialog_DiamondCup));
			SerializeField(s, nameof(HomeNodeDialog_GoldCup));
			SerializeField(s, nameof(HomeNodeDialog_SilverCup));
			SerializeField(s, nameof(HomeNodeDialog_BronzeCup));
			SerializeField(s, nameof(HomeNodeDialog_Teaser_Day));
			SerializeField(s, nameof(HomeNodeDialog_Teaser_Hour));
			SerializeField(s, nameof(HomeNodeDialog_Teaser_Minute));
			SerializeField(s, nameof(HomeNodeDialog_Teaser_Second));
			SerializeField(s, nameof(HomeNodeDialog_FriendChallengers));
			SerializeField(s, nameof(HomeNodeDialog_TotalChallengers));
			SerializeField(s, nameof(HomeNodeDialog_CostumeDescription));
			SerializeField(s, nameof(HomeNodeDialog_Highlight));
			SerializeField(s, nameof(HomeNodeDialog_NeedOnline));
		}
		public override uint? ClassCRC => 0x426FB0B9;
	}
}

