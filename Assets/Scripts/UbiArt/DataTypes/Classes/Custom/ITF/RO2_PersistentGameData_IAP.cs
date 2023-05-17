namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_PersistentGameData_IAP : CSerializable {
		public CListP<string> disabledAds;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			disabledAds = s.SerializeObject<CListP<string>>(disabledAds, name: "disabledAds");
		}
	}
}

