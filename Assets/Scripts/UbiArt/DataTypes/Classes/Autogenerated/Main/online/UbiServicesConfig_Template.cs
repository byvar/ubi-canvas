namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class UbiServicesConfig_Template : ITF.TemplateObj {
		public string ApplicationId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ApplicationId = s.Serialize<string>(ApplicationId, name: "ApplicationId");
		}
		public override uint? ClassCRC => 0x49FF8E91;
	}
}

