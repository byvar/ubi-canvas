using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class CharactersDiariesSave : CSerializable {
		public CArray<ListPageRead> CArray_ListPageRead__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			CArray_ListPageRead__0 = s.SerializeObject<CArray<ListPageRead>>(CArray_ListPageRead__0, name: "CArray_ListPageRead__0");
		}
	}
}

