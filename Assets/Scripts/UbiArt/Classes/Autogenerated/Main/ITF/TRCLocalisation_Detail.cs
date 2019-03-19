using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class TRCLocalisation_Detail : CSerializable {
		[Serialize("type"             )] public Enum_type type;
		[Serialize("canBack"          )] public bool canBack;
		[Serialize("message"          )] public SmartLocId message;
		[Serialize("title"            )] public SmartLocId title;
		[Serialize("buttonLeft"       )] public SmartLocId buttonLeft;
		[Serialize("buttonRight"      )] public SmartLocId buttonRight;
		[Serialize("buttonMiddle"     )] public SmartLocId buttonMiddle;
		[Serialize("defaultButton"    )] public Button defaultButton;
		[Serialize("restart"          )] public TRCRestart restart;
		[Serialize("uint__0"          )] public uint uint__0;
		[Serialize("string__1"        )] public string string__1;
		[Serialize("LocalisationId__2")] public LocalisationId LocalisationId__2;
		[Serialize("LocalisationId__3")] public LocalisationId LocalisationId__3;
		[Serialize("LocalisationId__4")] public LocalisationId LocalisationId__4;
		[Serialize("LocalisationId__5")] public LocalisationId LocalisationId__5;
		[Serialize("SmartLocId__6"    )] public SmartLocId SmartLocId__6;
		[Serialize("SmartLocId__7"    )] public SmartLocId SmartLocId__7;
		[Serialize("SmartLocId__8"    )] public SmartLocId SmartLocId__8;
		[Serialize("SmartLocId__9"    )] public SmartLocId SmartLocId__9;
		[Serialize("SmartLocId__10"   )] public SmartLocId SmartLocId__10;
		[Serialize("Enum_VH_0__11"    )] public Enum_VH_0 Enum_VH_0__11;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(uint__0));
				SerializeField(s, nameof(string__1));
				SerializeField(s, nameof(LocalisationId__2));
				SerializeField(s, nameof(LocalisationId__3));
				SerializeField(s, nameof(LocalisationId__4));
				SerializeField(s, nameof(LocalisationId__5));
				SerializeField(s, nameof(SmartLocId__6));
				SerializeField(s, nameof(SmartLocId__7));
				SerializeField(s, nameof(SmartLocId__8));
				SerializeField(s, nameof(SmartLocId__9));
				SerializeField(s, nameof(SmartLocId__10));
				SerializeField(s, nameof(Enum_VH_0__11));
			} else {
				SerializeField(s, nameof(type));
				SerializeField(s, nameof(canBack));
				SerializeField(s, nameof(message));
				SerializeField(s, nameof(title));
				SerializeField(s, nameof(buttonLeft));
				SerializeField(s, nameof(buttonRight));
				SerializeField(s, nameof(buttonMiddle));
				SerializeField(s, nameof(defaultButton));
				SerializeField(s, nameof(restart));
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
		public enum Enum_VH_0 {
			[Serialize("Value__1")] Value__1 = -1,
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
		}
	}
}

