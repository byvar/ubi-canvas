using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_BreakableSequence : CSerializable {
		[Serialize("uint__0"                       )] public uint uint__0;
		[Serialize("float__1"                      )] public float float__1;
		[Serialize("CArray<W1W_BreakableParams>__2")] public CArray<W1W_BreakableParams> CArray_W1W_BreakableParams__2;
		[Serialize("bool__3"                       )] public bool bool__3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(CArray_W1W_BreakableParams__2));
				SerializeField(s, nameof(bool__3));
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(uint__0));
				SerializeField(s, nameof(float__1));
			}
		}
	}
}

