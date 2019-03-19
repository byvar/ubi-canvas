using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class GFX_Vector4 : CSerializable {
		[Serialize("x")] public float x;
		[Serialize("y")] public float y;
		[Serialize("z")] public float z;
		[Serialize("w")] public float w;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(x));
			SerializeField(s, nameof(y));
			SerializeField(s, nameof(z));
			SerializeField(s, nameof(w));
		}
	}
}

