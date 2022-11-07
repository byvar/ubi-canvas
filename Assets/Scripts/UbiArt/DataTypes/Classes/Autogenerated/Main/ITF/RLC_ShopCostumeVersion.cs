namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_ShopCostumeVersion : CSerializable {
		public StringID costumeID;
		public uint tradeVersion;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			costumeID = s.SerializeObject<StringID>(costumeID, name: "costumeID");
			tradeVersion = s.Serialize<uint>(tradeVersion, name: "tradeVersion");
		}
	}
}

