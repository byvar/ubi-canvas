using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class GameFriend : CSerializable {
		public string pid;
		public SocialNetworkIdentity sns_identity;
		public string name;
		public StringID costume;
		public online.DateTime lastConnection;
		public uint stars;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			pid = s.Serialize<string>(pid, name: "pid");
			sns_identity = s.SerializeObject<SocialNetworkIdentity>(sns_identity, name: "sns_identity");
			name = s.Serialize<string>(name, name: "name");
			costume = s.SerializeObject<StringID>(costume, name: "costume");
			lastConnection = s.SerializeObject<online.DateTime>(lastConnection, name: "lastConnection");
			stars = s.Serialize<uint>(stars, name: "stars");
		}
	}
}

