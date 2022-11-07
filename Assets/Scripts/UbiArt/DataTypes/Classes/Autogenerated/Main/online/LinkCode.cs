namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class LinkCode : CSerializable {
		public uint slot;
		public string profileId;
		public string code;
		public uint ttl;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			slot = s.Serialize<uint>(slot, name: "slot");
			profileId = s.Serialize<string>(profileId, name: "profileId");
			code = s.Serialize<string>(code, name: "code");
			ttl = s.Serialize<uint>(ttl, name: "ttl");
		}
		public override uint? ClassCRC => 0x1038C063;
	}
}

