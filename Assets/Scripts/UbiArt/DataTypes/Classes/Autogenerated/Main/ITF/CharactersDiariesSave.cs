namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class CharactersDiariesSave : CSerializable {
		public CArrayO<ListPageRead> CArray_ListPageRead__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			CArray_ListPageRead__0 = s.SerializeObject<CArrayO<ListPageRead>>(CArray_ListPageRead__0, name: "CArray<ListPageRead>__0");
		}
	}
}

