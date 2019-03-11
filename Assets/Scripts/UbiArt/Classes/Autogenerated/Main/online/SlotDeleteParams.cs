using UnityEngine;

namespace UbiArt.online {
	public partial class SlotDeleteParams : SaveIdentifier {
		[Serialize("token")] public SocialNetworkIdentity token;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(token));
		}
		public override uint? ClassCRC => 0xA916FF26;
	}
}

