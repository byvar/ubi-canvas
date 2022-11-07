namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class FacebookConfig_Template : ITF.TemplateObj {
		public string AppId;
		public string RedirectUri;
		public string Permissions;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			AppId = s.Serialize<string>(AppId, name: "AppId");
			RedirectUri = s.Serialize<string>(RedirectUri, name: "RedirectUri");
			Permissions = s.Serialize<string>(Permissions, name: "Permissions");
		}
		public override uint? ClassCRC => 0x90E25A13;
	}
}

