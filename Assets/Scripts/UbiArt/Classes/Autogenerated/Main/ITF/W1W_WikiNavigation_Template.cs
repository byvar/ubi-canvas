using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_WikiNavigation_Template : ActorComponent_Template {
		public CArrayP<uint> CArray_uint__0;
		public CArrayP<uint> CArray_uint__1;
		public Color Color__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			CArray_uint__0 = s.SerializeObject<CArrayP<uint>>(CArray_uint__0, name: "CArray<uint>__0");
			CArray_uint__1 = s.SerializeObject<CArrayP<uint>>(CArray_uint__1, name: "CArray<uint>__1");
			Color__2 = s.SerializeObject<Color>(Color__2, name: "Color__2");
		}
		public override uint? ClassCRC => 0x0FC4B7A7;
	}
}

