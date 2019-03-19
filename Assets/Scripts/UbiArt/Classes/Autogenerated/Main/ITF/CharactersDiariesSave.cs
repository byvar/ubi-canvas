using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class CharactersDiariesSave : CSerializable {
		[Serialize("CArray<ListPageRead>__0")] public CArray<ListPageRead> CArray_ListPageRead__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(CArray_ListPageRead__0));
		}
	}
}

