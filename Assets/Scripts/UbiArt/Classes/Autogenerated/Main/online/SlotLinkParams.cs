using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class SlotLinkParams : LinkCode {
		public SocialNetworkIdentity token;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			token = s.SerializeObject<SocialNetworkIdentity>(token, name: "token");
		}
		public override uint? ClassCRC => 0x03A3047D;
	}
}

