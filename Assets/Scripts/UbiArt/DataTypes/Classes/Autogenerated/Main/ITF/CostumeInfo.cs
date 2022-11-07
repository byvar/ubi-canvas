namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class CostumeInfo : CSerializable {
		public StringID StringID__0;
		public uint uint__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			StringID__0 = s.SerializeObject<StringID>(StringID__0, name: "StringID__0");
			uint__1 = s.Serialize<uint>(uint__1, name: "uint__1");
		}
	}
}

