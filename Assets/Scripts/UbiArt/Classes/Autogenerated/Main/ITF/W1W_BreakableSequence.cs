using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_BreakableSequence : CSerializable {
		public uint uint__0;
		public float float__1;
		public CArrayO<W1W_BreakableParams> CArray_W1W_BreakableParams__2;
		public bool bool__3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				CArray_W1W_BreakableParams__2 = s.SerializeObject<CArrayO<W1W_BreakableParams>>(CArray_W1W_BreakableParams__2, name: "CArray<W1W_BreakableParams>__2");
				bool__3 = s.Serialize<bool>(bool__3, name: "bool__3");
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				uint__0 = s.Serialize<uint>(uint__0, name: "uint__0");
				float__1 = s.Serialize<float>(float__1, name: "float__1");
			}
		}
	}
}

