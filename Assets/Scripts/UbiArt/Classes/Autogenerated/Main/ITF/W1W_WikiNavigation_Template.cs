using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_WikiNavigation_Template : ActorComponent_Template {
		[Serialize("CArray<uint>__0")] public CArray<uint> CArray_uint__0;
		[Serialize("CArray<uint>__1")] public CArray<uint> CArray_uint__1;
		[Serialize("Color__2"       )] public Color Color__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(CArray_uint__0));
			SerializeField(s, nameof(CArray_uint__1));
			SerializeField(s, nameof(Color__2));
		}
		public override uint? ClassCRC => 0x0FC4B7A7;
	}
}

