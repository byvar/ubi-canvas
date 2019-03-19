using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class GameServerNodeJsConfig : CSerializable {
		[Serialize("redirections")] public CMap<string, string> redirections;
		[Serialize("urls"        )] public CMap<string, string> urls;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(redirections));
			SerializeField(s, nameof(urls));
		}
	}
}

