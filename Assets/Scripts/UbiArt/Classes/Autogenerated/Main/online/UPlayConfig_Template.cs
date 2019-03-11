using UnityEngine;

namespace UbiArt.online {
	public partial class UPlayConfig_Template : ITF.TemplateObj {
		[Serialize("AutoHandleActions"    )] public bool AutoHandleActions;
		[Serialize("AutoShowActionsUI"    )] public bool AutoShowActionsUI;
		[Serialize("RichPresenceId"       )] public int RichPresenceId;
		[Serialize("IsJapaneseSku"        )] public bool IsJapaneseSku;
		[Serialize("CompleteGameBoot"     )] public bool CompleteGameBoot;
		[Serialize("UseKinect"            )] public bool UseKinect;
		[Serialize("BrowserInviteArgument")] public string BrowserInviteArgument;
		[Serialize("BrowserAppPath"       )] public string BrowserAppPath;
		[Serialize("GameAppArguments"     )] public string GameAppArguments;
		[Serialize("GameAppPath"          )] public string GameAppPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(AutoHandleActions));
			SerializeField(s, nameof(AutoShowActionsUI));
			SerializeField(s, nameof(RichPresenceId));
			SerializeField(s, nameof(IsJapaneseSku));
			SerializeField(s, nameof(CompleteGameBoot));
			SerializeField(s, nameof(UseKinect));
			SerializeField(s, nameof(BrowserInviteArgument));
			SerializeField(s, nameof(BrowserAppPath));
			SerializeField(s, nameof(GameAppArguments));
			SerializeField(s, nameof(GameAppPath));
		}
		public override uint? ClassCRC => 0x447F6015;
	}
}

