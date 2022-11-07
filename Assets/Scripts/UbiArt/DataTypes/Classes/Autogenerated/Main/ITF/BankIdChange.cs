namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class BankIdChange : CSerializable {
		public StringID name;
		public CListO<IdRedirect> idRedirect;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
			idRedirect = s.SerializeObject<CListO<IdRedirect>>(idRedirect, name: "idRedirect");
		}
	}
}

