using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_WikiShortcutCollectible_Template : ActorComponent_Template {
		public CArrayP<uint> CArray_uint__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			CArray_uint__0 = s.SerializeObject<CArrayP<uint>>(CArray_uint__0, name: "CArray_uint__0");
		}
		public override uint? ClassCRC => 0xCBE9AD84;
	}
}

