using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_MobileVersionFilterComponent_Template : ActorComponent_Template {
		public uint uint__0;
		public CArrayP<uint> CArray_uint__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			uint__0 = s.Serialize<uint>(uint__0, name: "uint__0");
			CArray_uint__1 = s.SerializeObject<CArrayP<uint>>(CArray_uint__1, name: "CArray<uint>__1");
		}
		public override uint? ClassCRC => 0x7665E29A;
	}
}

