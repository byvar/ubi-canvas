namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class gameGlobalsData : CSerializable {
		public string variables;
		public CMap<StringID, GameGlobalsFile> overrides;
		public online.DateTime versionTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			variables = s.Serialize<string>(variables, name: "variables");
			overrides = s.SerializeObject<CMap<StringID, GameGlobalsFile>>(overrides, name: "overrides");
			versionTime = s.SerializeObject<online.DateTime>(versionTime, name: "versionTime");
		}
	}
}

