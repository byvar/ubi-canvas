namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_StoreBundleLocInfo : CSerializable {
		public string StoreBundleTitle;
		public string StoreBundlePurchasedTitle;
		public string StoreBundlePurchasedDesc;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			StoreBundleTitle = s.Serialize<string>(StoreBundleTitle, name: "StoreBundleTitle");
			StoreBundlePurchasedTitle = s.Serialize<string>(StoreBundlePurchasedTitle, name: "StoreBundlePurchasedTitle");
			StoreBundlePurchasedDesc = s.Serialize<string>(StoreBundlePurchasedDesc, name: "StoreBundlePurchasedDesc");
		}
	}
}

