using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class AFX_NoiseParam : CSerializable {
		[Serialize("use"        )] public bool use;
		[Serialize("blendFactor")] public float blendFactor;
		[Serialize("size"       )] public float size;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(use));
			SerializeField(s, nameof(blendFactor));
			SerializeField(s, nameof(size));
		}
	}
}

