using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class ListPageRead : CSerializable {
		public CArray<uint> CArray_uint__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			CArray_uint__0 = s.SerializeObject<CArray<uint>>(CArray_uint__0, name: "CArray_uint__0");
		}
	}
}

