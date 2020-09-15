using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
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
		public uint uint__0;
		public string string__1;
		public LocalisationId LocalisationId__2;
		public LocalisationId LocalisationId__3;
		public LocalisationId LocalisationId__4;
		public LocalisationId LocalisationId__5;
		public SmartLocId SmartLocId__6;
		public SmartLocId SmartLocId__7;
		public SmartLocId SmartLocId__8;
		public SmartLocId SmartLocId__9;
		public SmartLocId SmartLocId__10;
		public Enum_VH_0 Enum_VH_0__11;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				uint__0 = s.Serialize<uint>(uint__0, name: "uint__0");
				string__1 = s.Serialize<string>(string__1, name: "string__1");
				LocalisationId__2 = s.SerializeObject<LocalisationId>(LocalisationId__2, name: "LocalisationId__2");
				LocalisationId__3 = s.SerializeObject<LocalisationId>(LocalisationId__3, name: "LocalisationId__3");
				LocalisationId__4 = s.SerializeObject<LocalisationId>(LocalisationId__4, name: "LocalisationId__4");
				LocalisationId__5 = s.SerializeObject<LocalisationId>(LocalisationId__5, name: "LocalisationId__5");
				SmartLocId__6 = s.SerializeObject<SmartLocId>(SmartLocId__6, name: "SmartLocId__6");
				SmartLocId__7 = s.SerializeObject<SmartLocId>(SmartLocId__7, name: "SmartLocId__7");
				SmartLocId__8 = s.SerializeObject<SmartLocId>(SmartLocId__8, name: "SmartLocId__8");
				SmartLocId__9 = s.SerializeObject<SmartLocId>(SmartLocId__9, name: "SmartLocId__9");
				SmartLocId__10 = s.SerializeObject<SmartLocId>(SmartLocId__10, name: "SmartLocId__10");
				Enum_VH_0__11 = s.Serialize<Enum_VH_0>(Enum_VH_0__11, name: "Enum_VH_0__11");
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
		public enum Enum_VH_0 {
			[Serialize("Value__1")] Value__1 = -1,
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
		}
	}
}

