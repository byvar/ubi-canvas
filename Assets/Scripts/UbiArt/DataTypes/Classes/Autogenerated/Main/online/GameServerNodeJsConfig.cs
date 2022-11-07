namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class GameServerNodeJsConfig : CSerializable {
		public CMap<string, string> redirections;
		public CMap<string, string> urls;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			redirections = s.SerializeObject<CMap<string, string>>(redirections, name: "redirections");
			urls = s.SerializeObject<CMap<string, string>>(urls, name: "urls");
		}
	}
}

