namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class SlotCreateParams : userProfileOtherData {
		public uint askedSlot;
		public SocialNetworkIdentity token;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			askedSlot = s.Serialize<uint>(askedSlot, name: "askedSlot");
			token = s.SerializeObject<SocialNetworkIdentity>(token, name: "token");
		}
	}
}

