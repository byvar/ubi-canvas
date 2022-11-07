namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class gameGlobalsData : CSerializable {
		public string variables;
		public StringID KEY;
		public online.DateTime versionTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			variables = s.Serialize<string>(variables, name: "variables");
			KEY = s.SerializeObject<StringID>(KEY, name: "KEY");
			KEY = s.SerializeObject<StringID>(KEY, name: "KEY");
			versionTime = s.SerializeObject<online.DateTime>(versionTime, name: "versionTime");
		}
	}
}

