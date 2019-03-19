using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class SlotLinkParams : LinkCode {
		[Serialize("token")] public SocialNetworkIdentity token;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(token));
		}
		public override uint? ClassCRC => 0x03A3047D;
	}
}

