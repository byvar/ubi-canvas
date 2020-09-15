using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class UPlayConfig_Template : ITF.TemplateObj {
		public bool AutoHandleActions;
		public bool AutoShowActionsUI;
		public int RichPresenceId;
		public bool IsJapaneseSku;
		public bool CompleteGameBoot;
		public bool UseKinect;
		public string BrowserInviteArgument;
		public string BrowserAppPath;
		public string GameAppArguments;
		public string GameAppPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			AutoHandleActions = s.Serialize<bool>(AutoHandleActions, name: "AutoHandleActions");
			AutoShowActionsUI = s.Serialize<bool>(AutoShowActionsUI, name: "AutoShowActionsUI");
			RichPresenceId = s.Serialize<int>(RichPresenceId, name: "RichPresenceId");
			IsJapaneseSku = s.Serialize<bool>(IsJapaneseSku, name: "IsJapaneseSku");
			CompleteGameBoot = s.Serialize<bool>(CompleteGameBoot, name: "CompleteGameBoot");
			UseKinect = s.Serialize<bool>(UseKinect, name: "UseKinect");
			BrowserInviteArgument = s.Serialize<string>(BrowserInviteArgument, name: "BrowserInviteArgument");
			BrowserAppPath = s.Serialize<string>(BrowserAppPath, name: "BrowserAppPath");
			GameAppArguments = s.Serialize<string>(GameAppArguments, name: "GameAppArguments");
			GameAppPath = s.Serialize<string>(GameAppPath, name: "GameAppPath");
		}
		public override uint? ClassCRC => 0x447F6015;
	}
}

