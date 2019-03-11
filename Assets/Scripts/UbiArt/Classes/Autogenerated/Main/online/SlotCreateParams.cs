using UnityEngine;

namespace UbiArt.online {
	public partial class SlotCreateParams : userProfileOtherData {
		[Serialize("askedSlot")] public uint askedSlot;
		[Serialize("token"    )] public SocialNetworkIdentity token;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(askedSlot));
			SerializeField(s, nameof(token));
		}
	}
}

