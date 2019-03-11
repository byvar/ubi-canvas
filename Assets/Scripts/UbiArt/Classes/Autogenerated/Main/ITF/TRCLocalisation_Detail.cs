using UnityEngine;

namespace UbiArt.ITF {
	public partial class TRCLocalisation_Detail : CSerializable {
		[Serialize("type"         )] public Enum_type type;
		[Serialize("canBack"      )] public bool canBack;
		[Serialize("message"      )] public SmartLocId message;
		[Serialize("title"        )] public SmartLocId title;
		[Serialize("buttonLeft"   )] public SmartLocId buttonLeft;
		[Serialize("buttonRight"  )] public SmartLocId buttonRight;
		[Serialize("buttonMiddle" )] public SmartLocId buttonMiddle;
		[Serialize("defaultButton")] public Button defaultButton;
		[Serialize("restart"      )] public TRCRestart restart;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
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

