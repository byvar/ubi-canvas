namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_SpecialPackSave : CSerializable {
		public online.DateTime lastTimeShownInShop;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			lastTimeShownInShop = s.SerializeObject<online.DateTime>(lastTimeShownInShop, name: "lastTimeShownInShop");
		}
	}
}

