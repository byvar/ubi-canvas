using UnityEngine;

namespace UbiArt.online {
	public partial class GameFriend : CSerializable {
		[Serialize("pid"           )] public string pid;
		[Serialize("sns_identity"  )] public SocialNetworkIdentity sns_identity;
		[Serialize("name"          )] public string name;
		[Serialize("costume"       )] public StringID costume;
		[Serialize("lastConnection")] public online.DateTime lastConnection;
		[Serialize("stars"         )] public uint stars;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(pid));
			SerializeField(s, nameof(sns_identity));
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(costume));
			SerializeField(s, nameof(lastConnection));
			SerializeField(s, nameof(stars));
		}
	}
}

