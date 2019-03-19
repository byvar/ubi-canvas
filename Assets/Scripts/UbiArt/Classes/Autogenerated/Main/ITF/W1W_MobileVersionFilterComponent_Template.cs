using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_MobileVersionFilterComponent_Template : ActorComponent_Template {
		[Serialize("uint__0"        )] public uint uint__0;
		[Serialize("CArray<uint>__1")] public CArray<uint> CArray_uint__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(uint__0));
			SerializeField(s, nameof(CArray_uint__1));
		}
		public override uint? ClassCRC => 0x7665E29A;
	}
}

