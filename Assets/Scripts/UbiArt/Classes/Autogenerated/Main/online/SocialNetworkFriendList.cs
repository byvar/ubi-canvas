using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class SocialNetworkFriendList : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
	}
}

