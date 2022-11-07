namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class userProfileShortData : CSerializable {
		public string pid;
		public string name;
		public string deviceCountry;
		public uint stars;
		public StringID costume;
		public string img;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			pid = s.Serialize<string>(pid, name: "pid");
			name = s.Serialize<string>(name, name: "name");
			deviceCountry = s.Serialize<string>(deviceCountry, name: "deviceCountry");
			stars = s.Serialize<uint>(stars, name: "stars");
			costume = s.SerializeObject<StringID>(costume, name: "costume");
			img = s.Serialize<string>(img, name: "img");
		}
		public override uint? ClassCRC => 0x12CC28F5;
	}
}

