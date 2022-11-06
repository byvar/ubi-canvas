using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class ListPageRead : CSerializable {
		public CArrayP<uint> CArray_uint__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			CArray_uint__0 = s.SerializeObject<CArrayP<uint>>(CArray_uint__0, name: "CArray<uint>__0");
		}
	}
}

